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
    public partial class UpdateSubscription : Form
    {
        public UpdateSubscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSubscriptionsScreen().Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSubscriptionsScreen().Show();
        }
    }
}
