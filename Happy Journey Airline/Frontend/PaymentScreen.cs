using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Happy_Journey_Airline.Backend;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class PaymentScreen : Form
    {
        private string destination;
        private string duration;
        private string seatNo;
        private List<Service> services;
        private string status;
        private int flightClassId;
        private int flightId;
        private string flightNo;
        private int travelerId;
        private string passportNo;
        public PaymentScreen(string destination, string duration, string seatNo, List<Service> services, string status, int flightClassId, int flightId, string flightNo, int travelerId, string passportNo, int? paymentId = null)
        {
            InitializeComponent();
            lblmsg.Text = " ";
            lblmsg.ForeColor = Color.Red;






            this.destination = destination;
            this.duration = duration;
            this.seatNo = seatNo;
            this.services = services;
            this.status = status;
            this.flightClassId = flightClassId;
            this.flightId = flightId;
            this.flightNo = flightNo;
            this.travelerId = travelerId;
            this.passportNo = passportNo;
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
            


            long cardNo;
          
            int pinORcvv;

            bool isCardNumValid = long.TryParse(cardNum, out cardNo);
          
            bool isPin_cvvValid = int.TryParse(pin_Cvv, out pinORcvv);
            

           


            if (string.IsNullOrEmpty(cardHolder) || string.IsNullOrEmpty(cardNum)||  string.IsNullOrEmpty(pin_Cvv)) {

                MessageBox.Show("Please enter all the required fields");
                return;
            }

            if (!isCardNumValid || cardNum.Length !=16 || cardNo <1000000000000000 || cardNo > 9999999999999999 ) {

                lblmsg.Text = "Invalid Card Number, must be 16 digits";
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

                if (!isPin_cvvValid || pin_Cvv.Length != 3 || pinORcvv < 100 || pinORcvv > 999)
                {

                    lblmsg.Text = "Invalid cvv, must be 3 digits";
                    return;
                }
                CreditCard creditCard = new CreditCard();



            }

            else if (rbDebit.Checked)
            {

                selectionCardType = rbDebit.Text;
                if (!isPin_cvvValid || pin_Cvv.Length != 4 || pinORcvv < 1000 || pinORcvv > 9999)
                {

                    lblmsg.Text = "Invalid pin, must be 4 digits";
                    return;
                }
                DebitCard debitCard = new DebitCard();

            }
            if (rbCredit.Checked || rbDebit.Checked)
            {
                Administrator.addBooking(destination, duration, seatNo, services, status, flightClassId, flightId, flightNo, travelerId, passportNo);

            }
            else
            {
                lblmsg.Text = "Please select a Card Type";
                return;
            }

            
           // this.Hide();
           // new UserHomeScreen().Show();
        }

        private void acctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBookFlight().Show();
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            lbl.Text = "CVV:";
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            lbl.Text = "Pin:";
        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
