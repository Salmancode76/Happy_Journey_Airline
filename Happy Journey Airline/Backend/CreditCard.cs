using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
