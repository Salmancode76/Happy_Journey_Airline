using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
            messagtxt.Text = string.Empty;

            RoleCB.Items.Add("Admin");
            RoleCB.Items.Add("Employer");
            RoleCB.Items.Add("Traveler");
        }

        private void createbtn_Click(object sender, EventArgs e)
        {


            string fname = Fnametxt.Text;
            string lname = Lnametxt.Text;
            string username = usertxt.Text;


            DateTime DOB = dateTimePicker1.Value;
            DateTime referenceDate = new DateTime(2024, 11, 29);

            String Dob = dateTimePicker1.Text;


            int age = referenceDate.Year - DOB.Year;


            String Gender = "";

            if (Malerb.Checked && !Femalerb.Checked)
            {
                Gender = "Male";
            }
            else if (!Malerb.Checked && Femalerb.Checked)
            {
                Gender = "Female";
            }


            String Email = emailtxt.Text;

            String phone = phontxt.Text;

            string role = RoleCB.SelectedItem?.ToString();

            string pass = txtPass.Text;








            User u = new User();




            u.Register(fname, lname, age, Email, username, pass, role, phone, Gender, Dob);






        }
        private void emaillbl_Click(object sender, EventArgs e)
        {

        }

        private void passlbl_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewUsersScreen().Show();
        }

        private void lblbirthdate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void messagtxt_Click(object sender, EventArgs e)
        {

        }
    }
}
