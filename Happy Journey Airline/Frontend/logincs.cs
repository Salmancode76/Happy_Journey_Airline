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
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

      

        private void loginbtn_Click(object sender, EventArgs e)
        {
            User ur = new User();

         User ul =  ur.login(ustxt.Text, passtxt.Text);

            if ( ul == null ){

                messagelbl.Text = "Invalid username or password!"; 
                messagelbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //   this.Hide(); // Hide the current form
                this.Hide();
                new UserHomeScreen().Show();
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form

            new  WelcomeScreen().Show();

        }

        private void logincs_Load(object sender, EventArgs e)
        {
            messagelbl.Text = string.Empty;
        }
    }
}
