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


            DateTime departDate = departDatePicker.Value;
            DateTime destDate = destDatePicker.Value;

            


            if (string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(departure) || string.IsNullOrEmpty(seatno) || string.IsNullOrEmpty(status) || !int.TryParse(flight, out flightt) || !int.TryParse(totalTravelers, out totTraveler) || cmbFlightClass.SelectedIndex == -1)
            {


                MessageBox.Show("Please fill in all required fields");
            }

            else {

                MessageBox.Show("Data Added Successfully! \n\n Proceeding to Payment");

                BookFlight book;
                book = new BookFlight();

                //I didnt pass any values because some parameters are not same in the booking class
                this.Hide();
                new PaymentScreen().Show();

            }

            
        }
    }
}
