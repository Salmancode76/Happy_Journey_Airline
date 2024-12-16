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
    public partial class AddCountry : Form
    {
        public AddCountry()
        {
            InitializeComponent();
            regionCB.Items.Add("Asia");
            regionCB.Items.Add("Africa");
            regionCB.Items.Add("North America");
            regionCB.Items.Add("South America");
            regionCB.Items.Add("Europe");
            regionCB.Items.Add("Australia");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
    if (regionCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a region from the dropdown list.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            new Administrator().addCountry(txtCountry.Text, regionCB.SelectedItem.ToString());
        }

        private void AddCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
