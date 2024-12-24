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
    public partial class UserMessage : Form
    {
        private User currentUser;

        public UserMessage()
        {
            InitializeComponent();
            this.currentUser = GlobalUser.LoggedInUser ?? throw new ArgumentNullException(nameof(currentUser), "Current user cannot be null");
        }

        public UserMessage(User currentUser)
        {
            InitializeComponent();
            this.currentUser = GlobalUser.LoggedInUser ?? throw new ArgumentNullException(nameof(currentUser), "Current user cannot be null");
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
            List<User> admins = getAdmin();

            comboReceiver.DataSource = admins;
            comboReceiver.DisplayMember = "FullName";
            comboReceiver.ValueMember = "UserId";
        }

        private List<User> getAdmin()
        {
            List<User> admins = new List<User>();
            try
            {
                string query = "SELECT [user_id], [first_name], [last_name] FROM [dbo].[User] WHERE [role]='Admin'";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User administrator = new User
                    {
                        UserId = Convert.ToInt32(reader["user_id"]),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString()
                    };

                    admins.Add(administrator);
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
            return admins;
        }

        private int GetCurrentTravelerById()
        {
            if (string.Equals(currentUser.Role, "Traveler", StringComparison.OrdinalIgnoreCase))
            {
                return GlobalUser.LoggedInUser.userId; // Return the user's ID
            }
            else
            {
               throw new UnauthorizedAccessException("T user isn't a traveler.");
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            // Validate receiver selection and message input
            if (comboReceiver.SelectedValue == null)
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
                receiverID = (int)comboReceiver.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Invalid receiver selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the current admin ID
                int travelerId = GetCurrentTravelerById();

                // Create a new Message object and send the message
                Message message = new Message();
                message.sendMessage(messageContent, receiverID);

                // Show success message
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtMessage.Clear();
                comboReceiver.SelectedIndex = -1;
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

        private void UserMessage_Load(object sender, EventArgs e)
        {
            LoadTravelers();
        }
    }
}
