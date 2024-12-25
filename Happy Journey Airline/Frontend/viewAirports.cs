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

namespace Happy_Journey_Airline.Frontend
{
    public partial class viewAirports : Form
    {
        public viewAirports()
        {
            InitializeComponent();
            loadGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAirport().Show();
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            if (gridFlight.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridFlight.SelectedCells[0];

                var id = gridFlight.Rows[selectedCell.RowIndex].Cells[0].Value;

                string name = (gridFlight.Rows[selectedCell.RowIndex].Cells[2].Value).ToString();



                int ID = Convert.ToInt32(id);
                this.Hide();


                new UpdateAirport(ID,name).Show();

            }
        }

        private void viewAirports_Load(object sender, EventArgs e)
        {

        }
        private void loadGrid()
        {
            string query = "Select * from [dbo].[Airport]";


            SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);

            gridFlight.DataSource = dt;


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (gridFlight.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridFlight.SelectedCells[0];

                var id = gridFlight.Rows[selectedCell.RowIndex].Cells[0].Value;




                int ID = Convert.ToInt32(id);

                 Administrator.deleteAirport(ID);

                loadGrid();

                gridFlight.Refresh();
            }
        }
    }
}
