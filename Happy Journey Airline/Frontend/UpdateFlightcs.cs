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
    public partial class UpdateFlightcs : Form
    {
        int flightID;
        public List<Country> Countries = new List<Country>();
        public List<Country> Countries2 = new List<Country>();

        public List<City> cities;
        public List<Airport> Airports;
        public UpdateFlightcs(int flightId, String flightNo, int capacity, string status, string departure, string destination, DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate, decimal price)
        {
            
            InitializeComponent();
            populateStatusCombo();
            populateListCombos();

            flightID = flightId;

            textBox1.Text = flightNo.ToString();
            txtCapacity.Text = capacity.ToString();

            txtPrice.Text = price.ToString("F2"); // Format price to 2 decimal places

            // Assign datetime= pickers their respective values
            dateDepartureTime.Value = departureTime;
            dateArrivalTime.Value = arrivalTime;
            dateDepartureDate.Value = departureDate;
            dateArrivalDate.Value = arrivalDate;

            // Assign departure and destination combo boxes their respective selected values

            // Set the country for departure
            Country departureCountry = Countries.FirstOrDefault(c =>
                Airports.Any(a => a.AirportId == Convert.ToInt32(departure) && a.CityID == cities.FirstOrDefault(ci => ci.CountryID == c.CountryId)?.CityId));

            CountryDepartureCMB.SelectedItem = departureCountry;
            cmbDeparture.SelectedItem = departure;

            Country distinationeCountry = Countries.FirstOrDefault(c =>
               Airports.Any(a => a.AirportId == Convert.ToInt32(destination) && a.CityID == cities.FirstOrDefault(ci => ci.CountryID == c.CountryId)?.CityId));


            CountryDistCMD.SelectedItem = distinationeCountry;

            cmbDestination.SelectedItem = destination;

            cmbStatus.SelectedItem = status;

         

        }
        private void populateStatusCombo()
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Ongoing");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Full");
            cmbStatus.Items.Add("Under Maintenance");




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

        private void Deptlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFlights().Show();
        }



        private void UpdateFlightcs_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty or invalid
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

            // Validate Capacity
            int capacity;
            if (!int.TryParse(txtCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be a positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Price
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime departureTime = dateDepartureTime.Value;
            DateTime arrivalTime = dateArrivalTime.Value;
            if (departureTime >= arrivalTime)
            {
                MessageBox.Show("Departure time must be before arrival time", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime departureDate = dateDepartureDate.Value;
            DateTime arrivalDate = dateArrivalDate.Value;
            if (departureDate >= arrivalDate)
            {
                MessageBox.Show("Departure date must be before the arrival date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string departure = cmbDeparture.SelectedValue.ToString();
            string destination = cmbDestination.SelectedValue.ToString();
            if (string.IsNullOrEmpty(departure) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please select valid departure and destination airports", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (departure == destination)
            {
                MessageBox.Show("Please select valid departure and destination airports", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string flightNo = textBox1.Text;
            string status = cmbStatus.SelectedItem.ToString();

            Administrator.updateFlight(flightID, flightNo, capacity, status, departure, destination, departureTime, arrivalTime, departureDate, arrivalDate, price);

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


        private void CountryDepartureCMB_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
