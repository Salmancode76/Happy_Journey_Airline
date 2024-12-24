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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }
    }
}
