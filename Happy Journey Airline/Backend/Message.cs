using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Message
    {
        private int messageId;
        private string content;
        private int senderId;
        private int receiverId;
        private DateTime timestamp;

        public Message()
        {
        }

        public Message(string content, int senderId, int receiverId)
        {
            this.messageId = messageId++;
            this.content = content;
            this.senderId = senderId;
            this.receiverId = receiverId;
            this.timestamp = DateTime.Now;
        }

        public string Content { get; set; }

        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public DateTime Timestamp { get; set; }

        public void sendMessage(string content, int senderId, int receiverId)
        {
            //Validate input parameters
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Messqage cannot be empty", nameof(content));
            }

            if (senderId <= 0)
            {
                throw new ArgumentException("Sender ID is invalid.", nameof(senderId));
            }

            if (receiverId <= 0)
            {
                throw new ArgumentException("Receiver ID is invalid.", nameof(receiverId));
            }

            try
            {
                //Create new message object
                Message message = new Message(content, senderId, receiverId);

                //Save the message to the database
                message.saveMessage();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while sending the message: " + ex.Message);
            }
        }

        public void saveMessage()
        {
            string m1;
            try
            {
                string query = "INSERT INTO Message (content, dender_id, receiver_id, timestamp) VALUES (@content, @senderId, @receiverId, @timestamp)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                command.Parameters.AddWithValue("@content", content);
                command.Parameters.AddWithValue("@sender_id", senderId);
                command.Parameters.AddWithValue("@receiver_id", receiverId);
                command.Parameters.AddWithValue("@timestamp", timestamp);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                m1 = "Error saving message: " + ex.Message;
            }
            finally
            {
                DBManager.getInstance("").CloseConnection();
            }
        }

        public DataTable getMessages(int userId)
        {
            string message;

            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM Message WHERE receiver_id = @userId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                command.Parameters.AddWithValue("@user_id", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                message = "Error retrieving messages: " + ex.Message;
            }
            finally
            {
                DBManager.getInstance("").CloseConnection();
            }
            return table;
        }
    }
}
