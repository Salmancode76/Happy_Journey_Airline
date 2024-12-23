using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Happy_Journey_Airline.Backend;

namespace Happy_Journey_Airline.Frontend
{
    public partial class BookFlightNew : Form
    {
        int flightID;
        public List<Country> Countries = new List<Country>();
        public List<Country> Countries2 = new List<Country>();
        public List<City> cities;
        public List<Airport> Airports;
        public List <User> List_users;
        public BookFlightNew() { }
        public BookFlightNew(int flightId, String flightNo, int capacity, string status, string departure, string destination, DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate, decimal price)
        {

            InitializeComponent();
            populateStatusCombo();
            populateListCombos();
            PopulateCheckboxes();
            Class_Load();
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
            Country departureCountry = Countries.FirstOrDefault(c =>
                        Airports.Any(a => a.AirportId == Convert.ToInt32(departure) && a.CityID == cities.FirstOrDefault(ci => ci.CountryID == c.CountryId)?.CityId));

            CountryDepartureCMB.SelectedItem = departureCountry;
            cmbDeparture.SelectedItem = departure;

            Country distinationeCountry = Countries.FirstOrDefault(c =>
               Airports.Any(a => a.AirportId == Convert.ToInt32(destination) && a.CityID == cities.FirstOrDefault(ci => ci.CountryID == c.CountryId)?.CityId));


            CountryDistCMD.SelectedItem = distinationeCountry;

            cmbDestination.SelectedItem = destination;

            cmbStatus.SelectedItem = status;


            // Set controls to read-only / disabled
            textBox1.ReadOnly = true;
            txtCapacity.ReadOnly = true;
            txtPrice.ReadOnly = true;

            dateDepartureTime.Enabled = false;
            dateArrivalTime.Enabled = false;
            dateDepartureDate.Enabled = false;
            dateArrivalDate.Enabled = false;

            CountryDepartureCMB.Enabled = false;
            cmbDeparture.Enabled = false;
            CountryDistCMD.Enabled = false;
            cmbDestination.Enabled = false;
            cmbStatus.Enabled = false;


            Country selectedCountry = (Country)CountryDepartureCMB.SelectedItem;

            List<Airport> displayList = filteredAirports(selectedCountry);

            // Bind the display list to cmbDestination
            cmbDeparture.DataSource = displayList.ToList();
            cmbDeparture.DisplayMember = "DisplayName";
            cmbDeparture.ValueMember = "AirportId";


            Country selectedCountry2 = (Country)CountryDistCMD.SelectedItem;

            List<Airport> displayList2 = filteredAirports(selectedCountry2);

            // Bind the display list to cmbDestination
            cmbDestination.DataSource = displayList2.ToList();
            cmbDestination.DisplayMember = "DisplayName";
            cmbDestination.ValueMember = "AirportId";



            List_users = User.GetAllUsers();

            userComboxUser.DataSource = List_users;
            userComboxUser.DisplayMember = "DisplayText"; 
            userComboxUser.ValueMember = "UserId";


        }



        private void Class_Load()
        {
            cmbFlightClass.Items.Add("Economy");
            cmbFlightClass.Items.Add("Buisiness");
            cmbFlightClass.Items.Add("First");


        }
        private void PopulateCheckboxes()
        {



            List<Service> services = new List<Service>();


            services = new Administrator().GetAllService();



            CheckedListBox checkedListBoxService = this.checkedListBoxService;  // Existing CheckedListBox

            checkedListBoxService.Items.Clear();


            foreach (var service in services)
            {
                checkedListBoxService.Items.Add(service.ServiceName);
            }

        }



        private void populateUsersCombo()
        {
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        

        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ViewBookFlight().Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            // Collect data from the form
            string destination = cmbDestination.SelectedValue.ToString();
            string duration = $"{dateDepartureDate.Value} - {dateArrivalDate.Value}";
            string seatNo = seatnotxt.Text;

            // Collect selected services
            List<Service> selectedServices = new List<Service>();
            foreach (var checkedItem in checkedListBoxService.CheckedItems)
            {
                Service service = new Service { ServiceName = checkedItem.ToString() };
                selectedServices.Add(service);
            }

            string status = cmbStatus.SelectedItem.ToString();
            int flightClassId = cmbFlightClass.SelectedIndex; // Assuming index maps to a valid ID
            int flightId = this.flightID; // Already set in the constructor
            String flightNo = (textBox1.Text); // Flight number from the form
                                                     //int paymentId = int.Parse(txtPaymentId.Text); // Payment ID from a text box
                                                     //  int subscriptionId = int.Parse(txtSubscriptionId.Text); // Subscription ID from a text box
            int travelerId = (int)userComboxUser.SelectedValue; // Traveler ID from the combo box

            // Call the static method to add the booking
            Administrator.addBooking(destination, duration, seatNo, selectedServices, status, flightClassId, flightId, flightNo, travelerId);



        
    
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
