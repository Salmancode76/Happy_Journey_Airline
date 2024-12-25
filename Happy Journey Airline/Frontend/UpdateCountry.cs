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
    public partial class UpdateCountry : Form
    {
        int CID;
        string CountryName;
        string Region;
    
        public UpdateCountry(int countryID, string countryName, string Region)
        {
            InitializeComponent();
            this.CID = countryID;
            this.CountryName = countryName;
            this.Region = Region;
            regionCB.Items.Add("Asia");
            regionCB.Items.Add("Africa");
            regionCB.Items.Add("North America");
            regionCB.Items.Add("South America");
            regionCB.Items.Add("Europe");
            regionCB.Items.Add("Australia");
            txtCountry.Text = countryName;
            regionCB.SelectedItem = Region;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewCountries().Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedCountryName = txtCountry.Text.Trim();
            string updatedRegion = regionCB.SelectedItem?.ToString();

             Administrator.updateCountry(CID, updatedCountryName, updatedRegion);

            MessageBox.Show("Country Updated Successfully!");
        }
    }
}
