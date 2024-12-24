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
    public partial class CreateSubscription : Form
    {
        public CreateSubscription()
        {
            InitializeComponent();
        }

        private void sublbl_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSubscriptionsScreen().Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subNametxt.Text))
            {
                lblName.Text = "Name is required.";
                return;
            }

            if (!int.TryParse(subPricetxt.Text, out int price) || price <= 0)
            {
                lblPrice.Text = "Price must be a positive number.";
                return;
            }

            if (!DateTime.TryParse(datestart.Text, out DateTime start) || !DateTime.TryParse(dateEnd.Text, out DateTime end))
            {
                lblStart.Text = "Invalid start or end date.";
                return;
            }

            if (start >= end)
            {
                lblStart.Text = "Start date must be before the end date.";
                return;
            }

            if (string.IsNullOrWhiteSpace(destxt.Text))
            {
                lblDesc.Text = "Description is required.";
                return;
            }

            try
            {
                string query = "INSERT INTO [dbo].[Subscription] ([subscription_name]  ,[start_date] ,[end_date], [description])  VALUES (@subscription_name, @start_date, @end_date, @description)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@subscription_name", subNametxt.Text);
                command.Parameters.AddWithValue("@start_date", start);
                command.Parameters.AddWithValue("@end_date", end);
                command.Parameters.AddWithValue("@subscription_price", subPricetxt.Text);
                command.Parameters.AddWithValue("@description", destxt.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Subscription created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        private void subPricetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
