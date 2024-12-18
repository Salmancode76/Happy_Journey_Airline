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
    public partial class viewCities : Form
    {
        public viewCities()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCity().Show();   
        }

        private void btnupdateFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCity().Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

        }
    }
}
