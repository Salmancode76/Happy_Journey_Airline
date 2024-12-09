using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("Invalid cvv. Must be 4 digits");
            }

            base.makePayment(amount, userId);
        }
    }
}
