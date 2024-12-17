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

        //private void btncreate_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new AdminBookFlight().Show();
        //}

        private void btndel_Click(object sender, EventArgs e)
        {

           


            
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            



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
