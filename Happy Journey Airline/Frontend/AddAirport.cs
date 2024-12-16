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
    public partial class AddAirport : Form
    {
        private List<City> cities;
        private List<Country> countries;
        public AddAirport()
        {
            InitializeComponent();


            // Load cities and countries from the Administrator class
            cities = Administrator.GetAllcities();
            countries = Administrator.GetAllCountries();


            // Set the DataSource for CountryCB
            CountryCB.DataSource = countries;
            CountryCB.DisplayMember = "CountryName"; //e
            CountryCB.ValueMember = "CountryId"; 
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {

        }

        private void cmbFlightClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void CountryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear CityCB before adding new cities
            CityCB.DataSource = null;

            if (CountryCB.SelectedItem != null)
            {
                Country selectedCountry = (Country)CountryCB.SelectedItem;


                if (selectedCountry != null)
                {
                    List<City> filteredCities = new List<City>();
                    // Loop through all cities and add the ones matching the selected country ID
                    foreach (City city in cities)
                    {
                        if (city.CountryID == selectedCountry.CountryId)
                        {
                            filteredCities.Add(city);
                        }
                    }


                    if (filteredCities.Any())
                    {
                        // Set the DataSource for CityCB with filtered cities
                        CityCB.DataSource = filteredCities;
                        CityCB.DisplayMember = "CityName"; // Show city name
                        CityCB.ValueMember = "CityId"; // Store city ID as the value
                    }
                    else
                    {
                        MessageBox.Show("No cities found for the selected country.");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the selected city object from CityCB
            City selectedCity = (City)CityCB.SelectedItem;

            // Check if a city is selected
            if (selectedCity != null)
            {
                // Get the CityId from the selected city
                int CityID = selectedCity.CityId;

                // Add the new airport using the selected city ID
                Administrator.addAirport(CityID, txtAirport.Text);
            }
            else
            {
                MessageBox.Show("Please select a city.");
            }
        }
    }
}
