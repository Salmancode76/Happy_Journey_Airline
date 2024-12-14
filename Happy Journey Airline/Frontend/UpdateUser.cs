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
    public partial class UpdateUser : Form
    {
        int userID;
        String orginalName;
        public UpdateUser(int  userid)
        {
            InitializeComponent();


            RoleCB.Items.Add("Admin");
            RoleCB.Items.Add("Employer");
            RoleCB.Items.Add("Traveler");
            User user = User.GetUserById(userid);

            userID = user.UserId;

            Fnametxt.Text = user.FirstName;
            Lnametxt.Text = user.LastName;
            usertxt.Text = user.Username;

             orginalName = user.Username;

            if (user.Gender == "Male")
            {
                Malerb.Checked = true;  
            } else if (user.Gender == "Female")
            {
                Femalerb.Checked = true;
            }
            dateTimePicker1.Text = user.Dob;

            emailtxt.Text = user.Email;
            phontxt.Text = user.PhoneNo;

           // passtxt.Text = user.Password;

            if (user.Role == "Admin")
            {
                RoleCB.SelectedIndex = 0;
            }else if (user.Role == "Employer")
            {
                RoleCB.SelectedIndex = 1;

            }else 
            {
                RoleCB.SelectedIndex = 2;

            }




        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewUsersScreen().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            


            User u = new User();
            DateTime dob = DateTime.Parse(dateTimePicker1.Text);

            int age = DateTime.Now.Year - dob.Year;

            string gender="";
            string role = "Traveller";

            if (RoleCB.SelectedItem != null)
            {
                role = RoleCB.SelectedItem.ToString();
            }


            if (Malerb.Checked)
            {
                gender = "Male";
            }
            else if (Femalerb.Checked)
            {
                gender = "Female";
            }

            bool same=false;


            if (orginalName != null && usertxt.Text != null && orginalName.Equals(usertxt.Text,StringComparison.OrdinalIgnoreCase))
            {
                same = true;
            }
            else
            {
                same = false;
            }

            Console.WriteLine(same);

            Console.WriteLine("Orginal name "+orginalName);
            Console.WriteLine("New name " + usertxt.Text);

            u.UpdateUser(userID, Fnametxt.Text, Lnametxt.Text, age, emailtxt.Text, usertxt.Text, passtxt.Text, RoleCB.SelectedItem.ToString(), phontxt.Text, gender, dateTimePicker1.Text, same);

         



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
