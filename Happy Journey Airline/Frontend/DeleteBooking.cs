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
    public partial class DeleteBooking : Form
    {
        public DeleteBooking()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookings().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookings().Show();
        }
    }
}
