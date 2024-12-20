using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public partial class PaymentScreen : Form
    {
        public PaymentScreen()
        {
            InitializeComponent();
            lblmsg.Text = " ";
            lblmsg.ForeColor = Color.Red;
        }

        private void uNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            string cardHolder = txtCholder.Text;
            string cardNum = txtcnum.Text;
           
            string selectionCardType;
            string pin_Cvv = txtCode.Text;
            DateTime expDate = expDatePicker.Value;
            


            int cardNo;
          
            int pinORcvv;

            bool isCardNumValid = int.TryParse(cardNum, out cardNo);
          
            bool isPin_cvvValid = int.TryParse(pin_Cvv, out pinORcvv);
            

           


            if (string.IsNullOrEmpty(cardHolder) || string.IsNullOrEmpty(cardNum)||  string.IsNullOrEmpty(pin_Cvv)) {

                MessageBox.Show("Please enter all the required fields");
                return;
            }

            if (!isCardNumValid || cardNum.Length <16 || cardNum.Length >16) {

                lblmsg.Text = "Invalid Card Number, must be 16 digits";
                return;
            
            }

           
            if (!isPin_cvvValid || pin_Cvv.Length < 3 || pin_Cvv.Length > 3)
            {

                lblmsg.Text = "Invalid Input, must be 3 digits";
                return;
            }

            if (expDate <= DateTime.Now.Date)
            {
                lblmsg.Text = "Please select a correct date";
                return;
            }


            lblmsg.Text = " ";


            if (rbCredit.Checked)
            {

                selectionCardType = rbCredit.Text;
                CreditCard creditCard = new CreditCard();



            }

            else if (rbDebit.Checked)
            {

                selectionCardType = rbDebit.Text;
            }

            else {
                lblmsg.Text = "Please select a Card Type";
                return;
            }

            MessageBox.Show("Payment Successful \n\n Proceeding to Home");
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void acctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BookFlight().Show();
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            lbl.Text = "CVV:";
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            lbl.Text = "Pin:";
        }
    }
}
