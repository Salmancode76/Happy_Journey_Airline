using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline.Frontend
{
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logincs().Show();
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBookFlight().Show();
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchFlights().Show();
        }
    }
}
