using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class CreditCard : Payment
    {
        private int creditCardId;
        private string cardHolder;
        private int cardNumber;
        private DateTime expirationDate;
        private int cvv;

        public CreditCard()
        {
        }

        public CreditCard(int creditCardId, string cardHolder, int cardNumber, DateTime expirationDate, int cvv)
        {
            this.creditCardId = creditCardId;
            this.cardHolder = cardHolder;
            this.cardNumber = cardNumber;
            this.expirationDate = expirationDate;
            this.cvv = cvv;
        }

        public string CardHolder { get; set; }

        public int CardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int Cvv { get; set; }

        public override void makePayment(double amount, int userId)
        {
            User user = User.GetUserById(userId);

            if (userId != user.UserId)
            {
                throw new Exception("User id doesn't match");
            }

            if (string.IsNullOrWhiteSpace(this.cardHolder))
            {
                throw new Exception("Card holder cannot be empty");
            }

            if (cardNumber <= 0 || cardNumber.ToString().Length != 16)
            {
                throw new Exception("Invalid card number. Must contain 16 digits");
            }

            if (expirationDate <= DateTime.Now)
            {
                throw new Exception("Card has expired");
            }
            if (cvv <= 0 || cvv.ToString().Length != 3)
            {
                throw new Exception("Invalid cvv. Must be 3 digits");
            }
           
            base.makePayment(amount, userId);
        }

        public void InsertCardDetails(string cardHolder, string cardNumber, DateTime expirationDate, int cvv) {

            try
            {
                string CreditCardInsert = "INSERT INTO [dbo].[Credit Card] (card_number, card_holder, expiration_date, cvv) VALUES(@cardNumber, @cardHolder, @expirationDate, @cvv)";
                SqlCommand cmd = new SqlCommand(CreditCardInsert, DBManager.getInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmd.Parameters.AddWithValue("@cardHolder", cardHolder);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@cvv", cvv);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Successfull! \n\n Proceeding to Home");
            }

            catch (Exception ex) {

                throw new Exception("An error occurred while adding Credit Card Details: " + ex.Message);
            }
            finally
            {
                
                DBManager.getInstance().CloseConnection();
            }

        }
    }
}
