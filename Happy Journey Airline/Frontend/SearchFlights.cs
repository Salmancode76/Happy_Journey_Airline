﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline.Frontend
{
    public partial class SearchFlights : Form
    {
        public List<Country> Countries = new List<Country>();
        public List<Country> Countries2 = new List<Country>();

        public List<City> cities;
        public List<Airport> Airports;
        public SearchFlights()
        {
            InitializeComponent();
            populateListCombos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;



            if (string.IsNullOrWhiteSpace(txtPrice.Text) ||

            from == null || to == null ||
            CountryDepartureCMB.SelectedIndex == -1 ||
            CountryDestCMD.SelectedIndex == -1 ||

            cmbDepartureA.SelectedIndex == -1 ||
           cmbDestinationA.SelectedIndex == -1 ||
           cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (from == to)
            {

                lblmsg.Text = " Departure and Arrival dates cannot be same";

            }

            int departureA = Convert.ToInt32(cmbDepartureA.SelectedValue);
            int destinationA = Convert.ToInt32(cmbDestinationA.SelectedValue);
            //int CountryDeparture = Convert.ToInt32(CountryDepartureCMB.SelectedValue);
            //int CountryDestination = Convert.ToInt32(CountryDestCMD.SelectedValue);

            if (departureA == destinationA)
            {
                MessageBox.Show("You can't travel to the same destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string stmt = "SELECT*  FROM [dbo].[Flight]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Excute the command
            da.Fill(dt);
            FlightGridView.DataSource = dt;
        }

        private void SearchFlights_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Ongoing");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Full");
            cmbStatus.Items.Add("Under Maintenance");

            lblmsg.Text = " ";
            lblmsg.ForeColor = Color.Red;
        }



        private void populateListCombos()
        {
            Countries = Administrator.GetAllCountries();

            cities = Administrator.GetAllcities();
            Airports = Administrator.GetAllAirports();

            CountryDepartureCMB.DataSource = Countries.ToList();
            CountryDepartureCMB.DisplayMember = "CountryName";
            CountryDepartureCMB.ValueMember = "CountryId";

            CountryDestCMD.DataSource = Countries.ToList();
            CountryDestCMD.DisplayMember = "CountryName";
            CountryDestCMD.ValueMember = "CountryId";



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

            if (CountryDestCMD.SelectedItem == null)
                return;

            cmbDestinationA.DataSource = null;

            Country selectedCountry = (Country)CountryDestCMD.SelectedItem;

            List<Airport> displayList = filteredAirports(selectedCountry);

            // Bind the display list to cmbDestination
            cmbDestinationA.DataSource = displayList.ToList();
            cmbDestinationA.DisplayMember = "DisplayName";
            cmbDestinationA.ValueMember = "AirportId";
        }

        private void CountryDepartureCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryDepartureCMB.SelectedItem == null)
                return;

            cmbDepartureA.DataSource = null;

            Country selectedCountry = (Country)CountryDepartureCMB.SelectedItem;

            List<Airport> displayList = filteredAirports(selectedCountry);

            // Bind the display list to cmbDestination
            cmbDepartureA.DataSource = displayList.ToList();
            cmbDepartureA.DisplayMember = "DisplayName";
            cmbDepartureA.ValueMember = "AirportId";




        }
    }
}
