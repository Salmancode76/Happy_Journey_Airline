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
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class UserSubscriptionScreen : Form
    {
        public UserSubscriptionScreen()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void LoadGrid()
        {
            try
            {
                string query = "SELECT * FROM [dbo].[SUBSCRIPTION]";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                subscriptionGrid.DataSource = dataTable;

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

        private void UserSubscriptionScreen_Load(object sender, EventArgs e)
        {
            LoadGrid();
            //AdminSubscribersSubscription admin = new AdminSubscribersSubscription();
        }

        private void subscribeBttn_Click(object sender, EventArgs e)
        {
            // Check if a subscription is selected
            if (GlobalUser.IsLoggedIn)
            {
                int travelerId = GlobalUser.LoggedInUser.userId; // Use the logged-in user's ID
                int subscriptionId = GetSelectedSubscriptionId();

                bool success = SaveSubscriberSubscription(travelerId, subscriptionId);
                if (success)
                {
                    MessageBox.Show("Subscribed successfully!");
                }
            }
            else
            {
                MessageBox.Show("User is not logged in.");
            }
        }

        private int GetSelectedSubscriptionId()
        {
            // Check if a subscription is selected
            if (subscriptionGrid.CurrentRow != null)
            {
                // Retrieve the SubscriptionId from the selected row
                return Convert.ToInt32(subscriptionGrid.CurrentRow.Cells["subscription_id"].Value);
            }

            // If no row is selected, return -1 or throw an exception
            throw new InvalidOperationException("No subscription is selected.");
        }

        private bool SaveSubscriberSubscription(int travelerId, int subscriptionId)
        {
            try
            {
                travelerId = GlobalUser.LoggedInUser.userId;

                if (subscriptionGrid.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select a subscription.");
                    return false;
                }

                int selectedRowIndex = subscriptionGrid.SelectedCells[0].RowIndex;

                if (selectedRowIndex < 0 || selectedRowIndex >= subscriptionGrid.Rows.Count)
                {
                    MessageBox.Show("Selected row index is out of range.");
                    return false;
                }

                // Retrieve the SubscriptionId from the selected row
                subscriptionId = Convert.ToInt32(subscriptionGrid.Rows[selectedRowIndex].Cells["subscription_id"].Value);

                string query = "INSERT INTO [dbo].[Subscriber Subscription] (subscriber_id, subscription_id) VALUES (@subscriber_id, @subscription_id)";

                SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());
                
                cmd.Parameters.AddWithValue("@subscriber_id", travelerId);
                cmd.Parameters.AddWithValue("@subscription_id", subscriptionId);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        
        
    }
}
