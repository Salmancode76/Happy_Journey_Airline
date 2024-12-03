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

        }

        private void Register_Click(object sender, EventArgs e)
        {
            UserRegister ur = new UserRegister();
            ur.Show(); // Show the new form

            this.Hide(); // Hide the current form

        }
    }
}
