using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public partial class AdminServices : Form
    {
        public AdminServices()
        {
            InitializeComponent();
            loadGrid();
        }

        private void Deletebtn_Click(object sender, System.EventArgs e)
        {
            if (SubGridView.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = SubGridView.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var Serviceid = SubGridView.Rows[selectedCell.RowIndex].Cells[0].Value;

            

                // Print the value of the selected user_id

                int ServiceID = Convert.ToInt32(Serviceid);


                Administrator.deleteService(ServiceID);


                loadGrid();
                SubGridView.Refresh();
            }

        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new CreateService().Show();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (SubGridView.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = SubGridView.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var ServicerId = SubGridView.Rows[selectedCell.RowIndex].Cells[0].Value;





                int ServicerID = Convert.ToInt32(ServicerId);

                // Call the DeleteUser method with the converted integer value

                Console.WriteLine(ServicerID);

                new UpdateService(ServicerID).Show();
                this.Hide();
            }
        }
        private void AdminServices_Load(object sender, System.EventArgs e)
        {

        }

        private void loadGrid()
        {
            string query = "Select * from [dbo].[Service]";


            SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);

            SubGridView.DataSource = dt;


        }

        private void SubGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      



            }
        }
    }

