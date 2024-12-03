using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Payment
    {
        protected int paymentId;
        protected double amount;
        protected DateTime date;

        public Payment()
        {
        }

        public Payment(int paymentId, double amount, DateTime date)
        {
            this.paymentId = paymentId;
            this.amount = amount;
            this.date = date;
        }

        public int PaymentId { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public virtual void makePayment(double amount, int userId)
        {
            try
            {
                //Fetch the user balance
                string query = "SELECT balance FROM User WHERE user_id = @userId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                command.Parameters.AddWithValue("@userId", userId);

                double currentBalance = (double)command.ExecuteScalar();

                //check if the user has enough balance
                if (currentBalance < amount)
                {
                    throw new Exception("Insufficient balance.");
                }

                //Deduct the amount from user's balance
                string updateQuery = "UPDATE User SET balance = balance - @amount WHERE user_id = @userId";
                command = new SqlCommand(updateQuery);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@user_id", userId);
                command.ExecuteNonQuery();

                //check if the user's balance is below 100, add 5000
                string updateQuery1 = "UPDATE User SET balance = balance + 5000 WHERE user_id = @userId AND balance <= 100";
                command = new SqlCommand(updateQuery1);
                command.Parameters.AddWithValue("@user_id", userId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in the payment process: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance("").CloseConnection();
            }
        }
    }
}
