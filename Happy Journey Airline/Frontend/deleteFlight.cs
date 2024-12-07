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
    public partial class deleteFlight : Form
    {
        public deleteFlight()
        {
            InitializeComponent();
        }

        private void gridFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFlights().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFlights().Show();
        }
    }
}
