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

namespace Happy_Journey_Airline
{
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFlightClass.Items.Add("First");
            cmbFlightClass.Items.Add("Buisiness");
            cmbFlightClass.Items.Add("Economy");
            lblmsg.Text = " ";
            lblmsg.ForeColor = Color.Red;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stmt = "SELECT*  FROM [dbo].[Flight]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Excute the command
            da.Fill(dt);
            flightGridView.DataSource = dt;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string flight = txtFlightno.Text;
            string destination = txtDest.Text;
            string departure = txtDepart.Text;
            string seatno = txtSeat.Text;
            string totalTravelers = txtTraveler.Text;
            string status = txtStatus.Text;


            int flightt;
            int totTraveler;

            bool isFlightValid = int.TryParse(flight, out flightt);
            bool isTravelerValid = int.TryParse(totalTravelers, out totTraveler);
            DateTime departDate = departDatePicker.Value;
            DateTime destDate = destDatePicker.Value;
            string depDate = departDatePicker.Text;
            string returnDate = destDatePicker.Text;

            if (string.IsNullOrEmpty(destination) ||
                string.IsNullOrEmpty(departure) ||
                string.IsNullOrEmpty(seatno) ||
                string.IsNullOrEmpty(status) ||
                cmbFlightClass.SelectedIndex == -1 )
            {
                MessageBox.Show("Please fill in all the required fields");
                return; // Exit to allow corrections
            }

            if (!isFlightValid)
            {
                lblmsg.Text = "Flight number must be a valid number!";
                return; // Exit to allow corrections
            }

            if (!isTravelerValid)
            {
                lblmsg.Text = "Number of travelers must be a valid number!";
                return; // Exit to allow corrections
            }

           

            if (departDate < DateTime.Now.Date) {
                lblmsg.Text = "Please select current or future Departure dates";
                return;
            }

            if (destDate < DateTime.Now.Date)
            {
                lblmsg.Text = "Please select current or future Return dates";
                return;
            }

           


            lblmsg.Text = " ";

                    MessageBox.Show("Data Added Successfully! \n\n Proceeding to Payment");
            string flightClass = cmbFlightClass.SelectedItem?.ToString();

                    Booking book = new Booking();



            book.TravelerBook(flight, destination, departure, seatno, totalTravelers,status, depDate, returnDate, flightClass);
            
                    

                    this.Hide();
                    new PaymentScreen().Show();

                


            }
            
        }
    }

