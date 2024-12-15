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

namespace Happy_Journey_Airline
{
    public partial class AdminBookings : Form
    {
        public AdminBookings()
        {
            InitializeComponent();

            loadBookingGrid();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookFlight().Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (gridBookings.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridBookings.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var userId = gridBookings.Rows[selectedCell.RowIndex].Cells[0].Value;

                var user_role = gridBookings.Rows[selectedCell.RowIndex].Cells[1].Value;
                if (userId == null)
                {
                    return;
                }

                // Print the value of the selected user_id
                Console.WriteLine($"Selected User ID: {userId + " " + user_role.ToString()}  ");

                int userIdInt = Convert.ToInt32(userId);



                // Call the DeleteUser method with the converted integer value


                new User().DeleteUser(userIdInt, user_role.ToString());

                loadBookingGrid();
                gridBookings.Refresh();



            }
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            


            if (gridBookings.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridBookings.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var bookingId = gridBookings.Rows[selectedCell.RowIndex].Cells[0].Value;

               // var user_Id = gridBookings.Rows[selectedCell.RowIndex].Cells[9].Value;

                // Print the value of the selected user_id
                //Console.WriteLine($"Selected User ID: {userId + " " + user_role.ToString()}  ");

                if (bookingId == null)
                {
                    return;
                }

                int userIdInt = Convert.ToInt32(bookingId);

                // Call the DeleteUser method with the converted integer value


                Booking b = new Booking();

                //new UpdateBooking(bookingId).Show();




            }
            this.Hide();

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
