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
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class UserMessage : Form
    {
        public UserMessage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TravellerRecievedMsg().Show();

        }

        private void LoadTravelers()
        {
            List<Administrator> admins = getAdmin();

            comboReceiver.DataSource = admins;
            comboReceiver.DisplayMember = "FullName";
            comboReceiver.ValueMember = "UserId";
        }

        private List<Administrator> getAdmin()
        {
            List<Administrator> travelers = new List<Administrator>();
            try
            {
                string query = "SELECT user_id, first_name + ' ' + last_name AS FullName FROM User WHERE role='Admin'";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Administrator administrator = new Administrator
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString()
                    };

                    travelers.Add(administrator);
                }
            }
            catch (Exception ex)
            {
                //error label "Error retrieving travelers: " + ex.Message 
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
            return travelers;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            int receiverID = (int)comboReceiver.SelectedValue;
            string messageContent = txtMessage.Text;

            try
            {
                //get the current admin id 
                //int adminId = ();

                Message message = new Message();

                //message.sendMessage(messageContent, adminId, receiverID);

                MessageBox.Show("Message  sent successfully");
            }
            catch (UnauthorizedAccessException ex)
            {
                //"Error" + ex.Message
            }
            catch (Exception ex)
            {
                // "Error: " + ex.Message
            }
        }
    }
}
