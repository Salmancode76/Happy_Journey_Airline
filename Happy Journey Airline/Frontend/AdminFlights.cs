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
    public partial class AdminFlights : Form
    {
        public AdminFlights()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateFlight().Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            this.Hide();

            
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFlightcs().Show();
        }

        private void AdminFlights_Load(object sender, EventArgs e)
        {

        }
    }
}
