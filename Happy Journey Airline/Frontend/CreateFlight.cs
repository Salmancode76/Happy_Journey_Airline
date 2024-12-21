using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Happy_Journey_Airline
{
    public partial class CreateFlight : Form
    {
        private List<(int airportId, string displayName)> departureAirport = new List<(int, string)>();
        private List<(int airportId, string displayName)> destinationAirport = new List<(int, string)>();
        private List<(int flightId, string flightNo)> flights = new List<(int, string)>();

        public List<Country> Countries = new List<Country>();
        public List<Country> Countries2 = new List<Country>();

        public List<City> cities;
        public List<Airport> Airports;



        public CreateFlight()
        {
            InitializeComponent();
            populateListCombos();
            populateStatusCombo();





        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFlights().Show();
        }

        private void validateFlightCreation()
        {

            try
            {
                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price (numeric value with decimals).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Collect input data
                int capacity = Convert.ToInt32(txtCapacity.Text);
                DateTime departureTime = dateDepartureTime.Value;
                DateTime arrivalTime = dateArrivalTime.Value;
                DateTime departureDate = dateDepartureDate.Value;
                DateTime arrivalDate = dateArrivalDate.Value;

                // Validate Flight No
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Flight No cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Validate Capacity
                if (capacity < 0)
                {
                    MessageBox.Show("Capacity cannot be negative", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (departureTime >= arrivalTime)
                {
                    MessageBox.Show("Departure time must be before arrival time", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbDeparture.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a departure airport", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbDestination.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a destination airport", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Price
                if (price <= 0)
                {
                    MessageBox.Show("Price must be greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Status
                if (cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Status cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Departure and Arrival Date
                if (departureDate >= arrivalDate)
                {
                    MessageBox.Show("Departure date must be before the arrival date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during validation: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void populateStatusCombo()
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Ongoing");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Full");
            cmbStatus.Items.Add("Under Maintenance");




        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true; // Block any invalid key
            }

            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true; // Block another decimal point
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                dateDepartureTime.Value == null || dateArrivalTime.Value == null ||
                dateDepartureDate.Value == null || dateArrivalDate.Value == null ||
                cmbDeparture.SelectedIndex == -1 ||
                cmbDestination.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate price
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price (numeric value greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate capacity
            int capacity;
            if (!int.TryParse(txtCapacity.Text, out capacity) || capacity < 0)
            {
                MessageBox.Show("Capacity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate flight number
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Flight No cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate time and date
            DateTime departureTime = dateDepartureTime.Value;
            DateTime arrivalTime = dateArrivalTime.Value;
            DateTime departureDate = dateDepartureDate.Value;
            DateTime arrivalDate = dateArrivalDate.Value;

            if (departureTime >= arrivalTime)
            {
                MessageBox.Show("Departure time must be before arrival time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (departureDate >= arrivalDate)
            {
                MessageBox.Show("Departure date must be before the arrival date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate departure and destination airports
            int departure = Convert.ToInt32(cmbDeparture.SelectedValue);
            int destination = Convert.ToInt32(cmbDestination.SelectedValue);

            if (departure == destination)
            {
                MessageBox.Show("You can't travel to the same destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate status
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string flightNo = textBox1.Text;

            Administrator.addFlight(flightNo, capacity, Convert.ToString(cmbStatus.SelectedItem), departure, destination, departureTime, arrivalTime, departureDate, arrivalDate, price);

        }
    







        private void CreateFlight_Load(object sender, EventArgs e)
        {

        }
        private void populateListCombos()
        {
            Countries = Administrator.GetAllCountries();

            cities = Administrator.GetAllcities();
            Airports = Administrator.GetAllAirports();

            CountryDepartureCMB.DataSource = Countries.ToList();
            CountryDepartureCMB.DisplayMember = "CountryName";
            CountryDepartureCMB.ValueMember = "CountryId";

            CountryDistCMD.DataSource = Countries.ToList();
            CountryDistCMD.DisplayMember = "CountryName";
            CountryDistCMD.ValueMember = "CountryId";

      

        }

        private List<Airport> filteredAirports(Country selectedCountry)
        {
            List<City> filteredCities = new List<City>();



                filteredCities = new List<City>();

                foreach (City city in cities)
                {
                    if (city.CountryID == selectedCountry.CountryId)
                    {
                        filteredCities.Add(city);
                    }
                }

                List<Airport> filteredAirport = new List<Airport>();

                for (int i = 0; i < filteredCities.Count; i++)
                {
                    for (int j = 0; j < Airports.Count; j++)
                    {

                        if (filteredCities[i].CityId == Airports[j].CityID)
                        {
                            filteredAirport.Add(Airports[j]);
                        }

                    }

                }

                List<Airport> displayList = new List<Airport>();

                for (int i = 0; i < filteredCities.Count; i++)
                {
                    for (int j = 0; j < Airports.Count; j++)
                    {
                        if (Airports[j].CityID == filteredCities[i].CityId)
                        {
                            string displayName = $"{Airports[j].AirportName} ({filteredCities[i].CityName})";
                            Airport displayAirport = new Airport(Airports[j].AirportId, Airports[j].AirportName, filteredCities[i].CityName);

                            displayList.Add(displayAirport);
                        }
                    }
                }
                return displayList;



            

        }







   


        private void CountryDistCMD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CountryDistCMD.SelectedItem == null)
                return;

            cmbDestination.DataSource = null;

            Country selectedCountry = (Country)CountryDistCMD.SelectedItem;

            List<Airport> displayList = filteredAirports(selectedCountry);

            // Bind the display list to cmbDestination
            cmbDestination.DataSource = displayList.ToList();
            cmbDestination.DisplayMember = "DisplayName";
            cmbDestination.ValueMember = "AirportId";
        }

        private void CountryDepartureCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryDepartureCMB.SelectedItem == null)
                return;

            cmbDeparture.DataSource = null;

            Country selectedCountry = (Country)CountryDepartureCMB.SelectedItem;

            List<Airport> displayList = filteredAirports(selectedCountry);

            // Bind the display list to cmbDestination
            cmbDeparture.DataSource = displayList.ToList();
            cmbDeparture.DisplayMember = "DisplayName";
            cmbDeparture.ValueMember = "AirportId";




        }

        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



