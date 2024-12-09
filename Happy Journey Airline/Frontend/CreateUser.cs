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



            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(role) || age <= 0)
            {
                messagtxt.Text = "Please fill in all required fields.";
                messagtxt.ForeColor = System.Drawing.Color.Red;
                return;
            }



            User u = new User();

            try
            {
                u.Register(fname, lname, age, Email, username, pass, role, phone, Gender, Dob);

            }
            catch
            {
                messagtxt.Text = string.Empty;
                messagtxt.ForeColor = System.Drawing.Color.Red;

                messagtxt.Text = "INVALID DATA!!!!!!!!!!!";

            }


            messagtxt.Text = string.Empty;
            messagtxt.ForeColor = System.Drawing.Color.Green;
            messagtxt.Text = "YOUR ACCOUNT HAS BEEN CREATED SCUSSFULLY!!!!!!";
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
