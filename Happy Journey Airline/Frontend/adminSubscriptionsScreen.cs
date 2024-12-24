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

namespace Happy_Journey_Airline
{
    public partial class adminSubscriptionsScreen : Form
    {
        public adminSubscriptionsScreen()
        {
            InitializeComponent();
        }

        private void adminSubscriptionsScreen_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateSubscription().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (subscriptiongrid.CurrentRow != null)
            {
                int subscriptionId = Convert.ToInt32(subscriptiongrid.CurrentRow.Cells["subscription_id"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                
                if (confirm == DialogResult.Yes)
                {
                    deleteSubscription(subscriptionId);
                }
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void SubGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid();
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

                subscriptiongrid.DataSource = dataTable;

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

        private void deleteSubscription(int subscriptionId)
        {
            string query = "DELETE FROM [dbo].[SUBSCRIPTION] WHERE subscription_id = @subscription_id";

            SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

            command.Parameters.AddWithValue("@subscription_id", subscriptionId);

            command.ExecuteNonQuery();
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new UpdateSubscription().Show();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    //new UpdateSubscription().Show();
        //}

    }
}
