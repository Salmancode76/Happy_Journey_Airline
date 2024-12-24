using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class DebitCard : Payment
    {
        private int debitCardId;
        private string cardHolder;
        private int cardNumber;
        private DateTime expirationDate;
        private int pin;

        public DebitCard()
        {
        }

        public DebitCard(int debitCardId, string cardHolder, int cardNumber, DateTime expirationDate, int pin)
        {
            this.debitCardId = debitCardId;
            this.cardHolder = cardHolder;
            this.cardNumber = cardNumber;
            this.expirationDate = expirationDate;
            this.pin = pin;
        }

        public int CardNumber { get; set; }

        public sbyte CardHolder { get; set; }

        public int Pin { get; set; }

        public DateTime ExpirationDate { get; set; }

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
            if (pin <= 0 || pin.ToString().Length != 4)
            {
                throw new Exception("Invalid pin. Must be 4 digits");
            }

            base.makePayment(amount, userId);
        }

        public void InsertCardDetails(string cardHolder, string cardNumber, DateTime expirationDate, int pin)
        {
            try
            {
                string CreditCardInsert = @"
                                            INSERT INTO [dbo].[Debit Card] (card_number, card_holder, expiration_date, pin)
                                            VALUES (@cardNumber, @cardHolder, @expirationDate, @pin);
                                            SELECT SCOPE_IDENTITY();"; 
                SqlCommand cmd = new SqlCommand(CreditCardInsert, DBManager.getInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmd.Parameters.AddWithValue("@cardHolder", cardHolder);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@pin", pin);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Successful \n\n Proceeding to Home");
            }

            catch (Exception ex)
            {

                throw new Exception("An error occurred while adding Debit Card Details: " + ex.Message);
            }
            finally
            {

                DBManager.getInstance().CloseConnection();

            }
        }
    }
}
