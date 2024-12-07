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
    public partial class AdminBookings : Form
    {
        public AdminBookings()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookFlight().Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteBooking().Show();
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateBooking().Show();
        }

        private void lblBokflight_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }
    }
}
