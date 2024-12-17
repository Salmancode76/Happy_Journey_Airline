using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Happy_Journey_Airline
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';  


        }



        private void Femalerb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Genderlbl_Click(object sender, EventArgs e)
        {

        }

        private void phonetxt_Click(object sender, EventArgs e)
        {

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {

            RoleCB.Items.Add("Admin");
            RoleCB.Items.Add("Employer");
            RoleCB.Items.Add("Traveler");
            // Display the selected item
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string fname = Fnametxt.Text;
            string lname = Lnametxt.Text;
            string username = usertxt.Text;


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd"; // Example: "2024-07-30"

            DateTime DOB = dateTimePicker1.Value; 
            DateTime referenceDate = new DateTime(2024, 11, 29); 

            String Dob = dateTimePicker1.Text;


            int age = referenceDate.Year - DOB.Year;
        

            String Gender = "";

            if (Malerb.Checked  && !Femalerb.Checked) {
                Gender = "Male";
            }else if (!Malerb.Checked && Femalerb.Checked)
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

        private void uNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            new WelcomeScreen().Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Malerb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleLbl_Click(object sender, EventArgs e)
        {

        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked)
            {
                txtPass.PasswordChar = '\0';  
            }
            else
            {
                txtPass.PasswordChar = '*';  
            }
        }
    }
}
