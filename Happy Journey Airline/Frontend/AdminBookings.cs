using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class AdminBookings : Form
    {
        public AdminBookings()
        {
            InitializeComponent();

            loadBookingGrid();
        }

        //private void btncreate_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new AdminBookFlight().Show();
        //}

        private void btndel_Click(object sender, EventArgs e)
        {
            if (gridBookings.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridBookings.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var bookid = gridBookings.Rows[selectedCell.RowIndex].Cells[0].Value;



                if (bookid == null)
                {
                    return;
                }

                int BookID = Convert.ToInt32(bookid);

                // Call the DeleteUser method with the converted integer value

                Administrator.DeleteBookingService(BookID);
                Administrator.deleteBooking(BookID);

                loadBookingGrid();
                gridBookings.Refresh();


            }




        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            /*
            if (gridBookings.SelectedCells.Count > 0)
            {
                // Retrieve the first selected cell's row index
                var selectedCell = gridBookings.SelectedCells[0];
                int rowIndex = selectedCell.RowIndex;

                try
                {
                    int bookingID = Convert.ToInt32(gridBookings.Rows[rowIndex].Cells["booking_id"].Value);
                    int flightClassID = Convert.ToInt32(gridBookings.Rows[rowIndex].Cells["flight_class_id"].Value);
                    int flightID = Convert.ToInt32(gridBookings.Rows[rowIndex].Cells["flight_id"].Value);
                    string seatNo = gridBookings.Rows[rowIndex].Cells["seat_no"].Value?.ToString();
                    int travelerID = Convert.ToInt32(gridBookings.Rows[rowIndex].Cells["traveler_id"].Value);
                    string passportNo = gridBookings.Rows[rowIndex].Cells["passportNo"].Value?.ToString();

                    // Instantiate the UpdateBooking form and pass data to it
                    var updateBookForm = new UpdateBooking(
                        bookingID, flightClassID, flightID, seatNo, travelerID, passportNo);

                    // Instantiate the UpdateBooking form and pass data to it
                    var updateBookForm = new UpdateBooking(
                        flightID, flightNo, capacity, status, departure, destination,
                        departureTime, arrivalTime, departureDate, arrivalDate, price);

                    // Show the UpdateBooking form
                    updateBookForm.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a flight.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            */

        }

        private void lblBokflight_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void AdminBookings_Load(object sender, EventArgs e)
        {

        }

        private void gridBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadBookingGrid() {

            string stmt = "SELECT*  FROM [dbo].[Booking]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Excute the command
            da.Fill(dt);
            gridBookings.DataSource = dt;



        }
    }
}
