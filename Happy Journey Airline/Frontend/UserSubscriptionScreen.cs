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
    public partial class UserSubscriptionScreen : Form
    {
        public UserSubscriptionScreen()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new PaymentScreen().Show();
        }
    }
}
