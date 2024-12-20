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
    public partial class AdminFlights : Form
    {
        public AdminFlights()
        {
            InitializeComponent();
            loadGridFlight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateFlight().Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (gridFlight.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridFlight.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var flightid = gridFlight.Rows[selectedCell.RowIndex].Cells[0].Value;



                // Print the value of the selected user_id

                int flightID = Convert.ToInt32(flightid);


                Administrator.deleteFlight(flightID);


                loadGridFlight();
                gridFlight.Refresh();
            }


        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFlightcs().Show();
        }

        private void AdminFlights_Load(object sender, EventArgs e)
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
    }
}
