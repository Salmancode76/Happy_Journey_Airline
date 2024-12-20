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
    public partial class viewCountries : Form
    {
        public viewCountries()
        {
            InitializeComponent();
            loadGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCountry().Show();    
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCountry().Show();
        }

        private void viewCountries_Load(object sender, EventArgs e)
        {

        }


        private void loadGrid()
        {
            string query = "Select * from [dbo].[Country]";


            SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);

            gridCountries.DataSource = dt;


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (gridCountries.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = gridCountries.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var countryid = gridCountries.Rows[selectedCell.RowIndex].Cells[0].Value;



                // Print the value of the selected user_id

                int countryID = Convert.ToInt32(countryid);


              
            }
        }
    }
}
