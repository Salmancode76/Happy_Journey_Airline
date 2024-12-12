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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();

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
            messagtxt.Text = string.Empty;

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


            DateTime DOB = dateTimePicker1.Value; // Correct way to get DateTime from DateTimePicker
            DateTime referenceDate = new DateTime(2024, 11, 29); // Reference date

            String Dob = dateTimePicker1.Text;
                                                                 // Calculate age
            int age = referenceDate.Year - DOB.Year;
            if (DOB > referenceDate.AddYears(-age))
            {
                age--;
            }



            String Gender = "";

            if (Malerb.Checked  && !Femalerb.Checked) {
                Gender = "Male";
            }else if (!Malerb.Checked && Femalerb.Checked)
            {
                Gender = "Female";
            }

            String Email = emailtxt.Text;

            String phone = phontxt.Text;

            string role = RoleCB.SelectedItem?.ToString() ?? ""; // Safely handles null if nothing is selected

            string pass = txtPass.Text;

            bool isNumeric = phone.All(char.IsDigit);

            if (isNumeric)
            {
                Console.WriteLine("Phone number is valid: " + phone);
            }
            else
            {
                Console.WriteLine("Invalid phone number. Only numbers are allowed.");
            }

            Console.WriteLine(phone);

            Console.WriteLine("THE ROLLE " + role);



            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(role) || age  <= 0)
            {
                messagtxt.Text = "Please fill in all required fields.";
                messagtxt.ForeColor = System.Drawing.Color.Red;
                return;
            }



            User u = new User();

            try
            {
                u.Register(fname, lname, age, Email, username, pass, role, phone, Gender, Dob);

                messagtxt.Text = string.Empty;
                messagtxt.ForeColor = System.Drawing.Color.Green;
                messagtxt.Text = "YOUR ACCOUNT HAS BEEN CREATED SCUSSFULLY!!!!!!";


            }
            catch (SqlException sqlEx)
            {
                messagtxt.Text = "Database error: " + sqlEx.Message;
                messagtxt.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                messagtxt.Text = "An error occurred: " + ex.Message;
                messagtxt.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void uNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
