using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Backend;

namespace Happy_Journey_Airline.Frontend
{
    public partial class AdminSubscribersSubscription : Form
    {
        public AdminSubscribersSubscription()
        {
            InitializeComponent();
          
        }

        private void subscribersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid(GlobalUser.LoggedInUser.UserId);
            
        }

        private void LoadGrid(int travelerId)
        {
            try
            {
                string query = "SELECT ss.[subscriber_id], u.[first_name], u.[last_name], s.[subscription_id], s.[subscription_name], s.[start_date], s.[end_date], s.[description] FROM ([dbo].[SUBSCRIPTION] s INNER JOIN [dbo].[SUBSCRIBER SUBSCRIPTION] ss ON s.[subscription_id] = ss.[subscription_id]) INNER JOIN [dbo].[USER] u ON u.[user_id] = ss.[subscriber_id]";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                subscribersGrid.DataSource = dataTable;

                //int selectedRowIndex = subscribersGrid.SelectedCells[0].RowIndex;
                //int subscriptionId = Convert.ToInt32(subscribersGrid.Rows[selectedRowIndex].Cells["subscription_id"].Value);
                //saveData(travelerId, subscriptionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void saveData(int travelerId, int subscriptionId)
        {
            try
            {
                if (GlobalUser.IsLoggedIn)
                {
                    travelerId = GlobalUser.LoggedInUser.UserId; // Use the logged-in user's ID

                    // Check if a cell is selected
                    if (subscribersGrid.SelectedCells.Count > 0)
                    {
                        // Get the index of the selected row
                        int selectedRowIndex = subscribersGrid.SelectedCells[0].RowIndex;

                        // Retrieve the SubscriptionId from the selected row
                        subscriptionId = Convert.ToInt32(subscribersGrid.Rows[selectedRowIndex].Cells["subscription_id"].Value);


                        DateTime start = (DateTime)subscribersGrid.Rows[selectedRowIndex].Cells["start_date"].Value;


                        DateTime end = (DateTime)subscribersGrid.Rows[selectedRowIndex].Cells["end_date"].Value;


                        string desc = Convert.ToString(subscribersGrid.Rows[selectedRowIndex].Cells["description"].Value);


                        string subName = Convert.ToString(subscribersGrid.Rows[selectedRowIndex].Cells["subscription_name"].Value);

                        string query = "INSERT INTO [dbo].[SUBSCRIBER SUBSCRIPTION] (subscription_id, subscriber_id) VALUES (@subscription_id, @traveler_id)";

                        SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                        command.Parameters.AddWithValue("@subscription_id", subscriptionId);
                        command.Parameters.AddWithValue("@subscriber_id", travelerId);


                        command.ExecuteNonQuery();

                        // Now you can use the subscriberId and subscriptionId as needed
                        MessageBox.Show($"Traveler ID: {travelerId}, Selected Subscription ID: {subscriptionId}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        private void AdminSubscribersSubscription_Load(object sender, EventArgs e)
        {
            LoadGrid(GlobalUser.LoggedInUser.UserId);

            if (GlobalUser.IsLoggedIn)
            {
                LoadGrid(GlobalUser.LoggedInUser.UserId);
            }
            //saveData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }
    }
}
