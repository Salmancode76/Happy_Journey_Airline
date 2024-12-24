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
            List<Message> messages = new List<Message>();
            try
            {
                string query = "SELECT content, sender_id, receiver_id FROM MESSAGE";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Message message = new Message
                    {
                        Content = reader["content"].ToString(),
                        SenderId = Convert.ToInt32(reader["sender_id"]),
                        ReceiverId = Convert.ToInt32(reader["receiver_id"])
                    };
                    messages.Add(message);
                }
                RmsgGrid.DataSource = messages;
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMessage().Show();
        }
    }
}
