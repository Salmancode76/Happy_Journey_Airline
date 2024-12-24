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
    public partial class AdminMessage : Form
    {
        private User currentUser;

        public AdminMessage()
        {
            InitializeComponent();
            this.currentUser = GlobalUser.LoggedInUser ?? throw new ArgumentNullException(nameof(currentUser), "Current user cannot be null");
            LoadTravelers();
        }

        public AdminMessage(User currentUser)
        {
            InitializeComponent();
            this.currentUser = GlobalUser.LoggedInUser ?? throw new ArgumentNullException(nameof(currentUser), "Current user cannot be null");
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
            LoadTravelers();
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
            List<User> travelers = getTravelers();

            cmbReceiver.DataSource = travelers;
            cmbReceiver.DisplayMember = "FullName";
            cmbReceiver.ValueMember = "UserId";
        }

        private List<User> getTravelers()
        {
            List<User> travelers = new List<User>();
            try
            {
                string query = "SELECT [user_id], [first_name], [last_name] FROM [dbo].[User] WHERE [role]='Traveler'";
                
                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    User traveler = new User
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
                errlbl.Text = "Error retrieving travelers: " + ex.Message;
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
            return travelers;
        }


        private int GetCurrentAdminById()
        {
            if (currentUser.Role == "Admin")
            {
                return currentUser.userId; // Return the admin's ID
            }

            throw new UnauthorizedAccessException("The current user isn't an admin.");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Validate receiver selection and message input
            if (cmbReceiver.SelectedValue == null)
            {
                MessageBox.Show("Please select a receiver.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please enter a message.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve values
            int receiverID;
            string messageContent = txtMessage.Text.Trim();

            try
            {
                receiverID = (int)cmbReceiver.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Invalid receiver selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the current admin ID
                int adminId = GetCurrentAdminById();

                // Create a new Message object and send the message
                Message message = new Message();
                message.sendMessage(messageContent, receiverID);

                // Show success message
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtMessage.Clear();
                cmbReceiver.SelectedIndex = -1;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
