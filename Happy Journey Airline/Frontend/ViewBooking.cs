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
using Happy_Journey_Airline.Backend;

namespace Happy_Journey_Airline.Frontend
{
    public partial class ViewBookFlight : Form
    {
        public ViewBookFlight()
        {
            InitializeComponent();
            loadGridFlight();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (GlobalUser.LoggedInUser == null)
            {
                MessageBox.Show("No user is logged in. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine(GlobalUser.LoggedInUser.Role);
            if (GlobalUser.LoggedInUser.Role == "Admin")
            {
                this.Hide();
                new adminDashboard().Show();
           }
        }

        private void ViewBookFlight_Load(object sender, EventArgs e)
        {

        }


        public void loadGridFlight()
        {
            string stmt = "SELECT*  FROM[dbo].[Flight]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Excute the command
            da.Fill(dt);
            gridFlight.DataSource = dt;

        }

        private void gridFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (gridFlight.SelectedCells.Count > 0)
            {
                var selectedCell = gridFlight.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;

                int flightID = Convert.ToInt32(gridFlight.Rows[rowIndex].Cells["flight_id"].Value);
                string departure = gridFlight.Rows[rowIndex].Cells["departure"].Value.ToString();
                string destination = gridFlight.Rows[rowIndex].Cells["destination"].Value.ToString();
                String flightNo = gridFlight.Rows[rowIndex].Cells["flight_no"].Value.ToString();
                int capacity = Convert.ToInt32(gridFlight.Rows[rowIndex].Cells["capacity"].Value);
                decimal price = Convert.ToDecimal(gridFlight.Rows[rowIndex].Cells["price"].Value);
                string status = gridFlight.Rows[rowIndex].Cells["status"].Value.ToString();
                DateTime departureTime = Convert.ToDateTime(gridFlight.Rows[rowIndex].Cells["departure_time"].Value);
                DateTime arrivalTime = Convert.ToDateTime(gridFlight.Rows[rowIndex].Cells["arrival_time"].Value);
                DateTime departureDate = Convert.ToDateTime(gridFlight.Rows[rowIndex].Cells["departure_date"].Value);
                DateTime arrivalDate = Convert.ToDateTime(gridFlight.Rows[rowIndex].Cells["arrival_date"].Value);

                var updateFlightForm = new BookFlightNew(
                    flightID, flightNo, capacity, status, departure, destination,
                    departureTime, arrivalTime, departureDate, arrivalDate, price);

                updateFlightForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a flight to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
