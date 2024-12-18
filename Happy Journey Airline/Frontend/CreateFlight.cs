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
        public List <Airport> Airports;



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
            int capacity = Convert.ToInt32(txtCapacity.Text);
            DateTime departureTime = dateDepartureTime.Value;
            DateTime arrivalTime = dateArrivalTime.Value;
            int price = Convert.ToInt32(txtPrice.Text);
            DateTime departureDate = dateDepartureDate.Value;
            DateTime arrivalDate = dateArrivalDate.Value;

            if (textBox1.Text.Length == 0)
            {
                throw new ArgumentException("Flight No cannot be empty");
            }

            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative");
            }

            if (departureTime == null)
            {
                throw new ArgumentException("Departure time cannot be empty");
            }

            if (arrivalTime == null)
            {
                throw new ArgumentException();
            }

            if (departureTime >= arrivalTime)
            {
                throw new ArgumentException("Departure time must be before arrival time");
            }

            if (cmbDeparture.SelectedIndex == -1)
            {
                throw new ArgumentException();
            }

            if (cmbDestination.SelectedIndex == -1)
            {
                throw new ArgumentException();
            }

            if (price < 0 || price == 0)
            {
                throw new ArgumentException();
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                throw new ArgumentException("Status cannot be empty");
            }

            if (departureDate == null)
            {

            }

            if (arrivalDate == null)
            {

            }

            if (departureDate >= arrivalDate)
            {
                throw new ArgumentException("Departure date must be before the arrival date");
            }
        }



        private void populateStatusCombo()
        {
            cmbStatus.Items.Add("Available");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            validateFlightCreation();

            string flightNo = textBox1.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            DateTime departureTime = dateDepartureTime.Value;
            DateTime arrivalTime = dateArrivalTime.Value;
            DateTime departureDate = dateDepartureDate.Value;
            DateTime arrivalDate = dateArrivalDate.Value;
            double price = Convert.ToDouble(txtPrice.Text);

            if (cmbDeparture.SelectedValue is int departure && cmbDestination.SelectedValue is int destination)
            {
                Administrator a = new Administrator();
                a.addFlight(flightNo, capacity, Convert.ToString(cmbStatus.SelectedItem), departure, destination, departureTime, arrivalTime, departureDate, arrivalDate, price);
            }
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
    }
}



