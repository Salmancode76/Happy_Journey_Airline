using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class BenefitPay : IPaymentMethod
    {
        private int benefitPayId;
        private int accountNumber;

        public BenefitPay(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public int AccountNumber { get; set; }

        public void pay(double amount, int userId)
        {
            string message;

            if (this.accountNumber <= 0 || accountNumber.ToString().Length < 6)
            {
                message = "Account number must be 6 digit number";
            }

            
                
                //Payment.makePayment(amount, userId);
            
        }
    }
}
