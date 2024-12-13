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
    public partial class adminSubscriptionsScreen : Form
    {
        public adminSubscriptionsScreen()
        {
            InitializeComponent();
        }

        private void adminSubscriptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateSubscription().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
=======
        
>>>>>>> 6b25619f8944d954116e49676f328f2d5add6133
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateSubscription().Show();
        }
    }
}
