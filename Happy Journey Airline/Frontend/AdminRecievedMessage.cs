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
    public partial class AdminRecievedMessage : Form
    {
        public AdminRecievedMessage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadMessages()
        {
            List<dynamic> messages = new List<dynamic>();
            try
            {
                string query = "SELECT m.[sender_id], u.[role], u.[first_name], u.[last_name], m.[content], m.[receiver_id] FROM [dbo].[MESSAGE] m INNER JOIN [dbo].[USER] u ON m.[sender_id] = u.[user_id] WHERE u.[role] = 'Traveler' AND m.[receiver_id] = @receiver_id";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                if (GlobalUser.IsLoggedIn)
                {
                    command.Parameters.AddWithValue("@receiver_id", GlobalUser.LoggedInUser.userId);
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var message = new 
                    {
                        SenderId = Convert.ToInt32(reader["sender_id"]),
                        Role = reader["role"].ToString(),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString(),
                        Content = reader["content"].ToString(),
                        ReceiverId = Convert.ToInt32(reader["receiver_id"])
                    };
                    messages.Add(message);
                }
                if (messages.Count == 0)
                {
                    msglbl.Text = "No messages received.";
                }
                else
                {
                    RmsgGrid.DataSource = messages;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMessage().Show();
        }

        private void AdminRecievedMessage_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }
}
