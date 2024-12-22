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
    public partial class AdminMessage : Form
    {
        private User currentUser;

        public AdminMessage()
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadTravelers();
        }

        public AdminMessage(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadTravelers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //hellooo
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void AdminMessage_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminRecievedMessage().Show();

        }

        private void LoadTravelers()
        {
            List<TravelerObserver> travelers = getTravelers();

            if (travelers.Count > 0)
            {
                cmbReceiver.DataSource = travelers;
                cmbReceiver.DisplayMember = "FullName";
                cmbReceiver.ValueMember = "UserId";
            }
            else
            {
                //No travelers found.
            }
        }

        private List<TravelerObserver> getTravelers()
        {
            List<TravelerObserver> travelers = new List<TravelerObserver>();
            try
            {
                string query = "SELECT [user_id], [first_name] + ' ' + [last_name] AS FullName FROM [dbo].[User] WHERE [role]='Traveler'";
                
                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    TravelerObserver traveler = new TravelerObserver
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString()
                    };

                    travelers.Add(traveler);
                }
                if (travelers.Count == 0)
                {
                    MessageBox.Show("No travelers found.");
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

        private int GetCurrentAdminById()
        {
            if (currentUser != null && currentUser.Role == "Admin")
            {
                //return the admin's id
                return currentUser.UserId;
            }
            else
            {
                throw new UnauthorizedAccessException("The current user isn't an admin");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int receiverID = (int)cmbReceiver.SelectedValue;
            string messageContent = txtMessage.Text;

            try
            {
                //get the current admin id 
                int adminId = GetCurrentAdminById();

                Message message = new Message();

                message.sendMessage(messageContent, adminId, receiverID);

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
