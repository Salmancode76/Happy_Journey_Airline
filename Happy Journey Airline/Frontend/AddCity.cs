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
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
            List<Country> countries =  Administrator.GetAllCountries();
            foreach (var country in countries)
            {
                Console.WriteLine(country.CountryName); 

                CountryCB.Items.Add(country.CountryName);


            }
            CountryCB.DataSource = countries;
            CountryCB.DisplayMember = "CountryName"; // Property to display in the ComboBox
            CountryCB.ValueMember = "CountryId"; // Property to use as the value
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void CountryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CountryCB.SelectedValue == null)
            {
                MessageBox.Show("Please select a country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCountryId = (int)CountryCB.SelectedValue; // Fetch the country ID
            string cityName = Citytxt.Text.Trim();

            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("City name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
                // Add the city
                new Administrator().addCity( selectedCountryId, cityName);
                MessageBox.Show("City added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           
        }
    }
}
