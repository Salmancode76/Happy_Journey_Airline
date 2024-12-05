﻿using System;
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
    }
}
