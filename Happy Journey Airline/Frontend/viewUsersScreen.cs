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
    public partial class viewUsersScreen : Form
    {
        public viewUsersScreen()
        {
            InitializeComponent();


            loadDataGrid();
         

        }


            private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateUser().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (userGridView.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = userGridView.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var userId = userGridView.Rows[selectedCell.RowIndex].Cells[0].Value;

                var user_role = userGridView.Rows[selectedCell.RowIndex].Cells[9].Value;
                if (userId == null)
                {
                    return;
                }

                // Print the value of the selected user_id
                Console.WriteLine($"Selected User ID: {userId +" " + user_role.ToString()}  ");

                int userIdInt = Convert.ToInt32(userId);

              

                // Call the DeleteUser method with the converted integer value


                new User().DeleteUser(userIdInt, user_role.ToString());

                loadDataGrid();
                userGridView.Refresh();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userGridView.SelectedCells.Count > 0)
            {
                // Get the first selected cell
                var selectedCell = userGridView.SelectedCells[0];

                // Get the value of the first cell in the selected row 
                var userId = userGridView.Rows[selectedCell.RowIndex].Cells[0].Value;

                var user_role = userGridView.Rows[selectedCell.RowIndex].Cells[9].Value;

                // Print the value of the selected user_id
                //Console.WriteLine($"Selected User ID: {userId + " " + user_role.ToString()}  ");

                if (userId == null){
                    return;
                }

                int userIdInt = Convert.ToInt32(userId);

                // Call the DeleteUser method with the converted integer value


                User u = new User();

                new UpdateUser(userIdInt).Show();



              
            }
            this.Hide();

            

        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is not on the header
            {
                // Get the clicked cell
                var selectedCell = userGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Print the value of the selected cell
                Console.WriteLine($"Selected Cell Value: {selectedCell.Value}");
            }
        }

        private void loadDataGrid()
        {
            string stmt = "SELECT*  FROM [dbo].[User]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Excute the command
            da.Fill(dt);
            userGridView.DataSource = dt;

        }

        private void viewUsersScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
