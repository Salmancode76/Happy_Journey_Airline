using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Backend;

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

            GlobalUser.LoggedInUser = ur;


            if ( ul == null ){

               
                MessageBox.Show("Invalid username or password!",
             "Error",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form

            new  WelcomeScreen().Show();

        }

        private void logincs_Load(object sender, EventArgs e)
        {
        }
    }
}
