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
<<<<<<< HEAD
            this.Hide();
=======
            
>>>>>>> 6b25619f8944d954116e49676f328f2d5add6133
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFlightcs().Show();
        }
    }
}
