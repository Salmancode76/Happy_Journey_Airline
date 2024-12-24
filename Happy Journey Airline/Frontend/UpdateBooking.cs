using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Backend;

namespace Happy_Journey_Airline.Frontend
{
    public partial class UpdateBooking : Form
    {
        int flightID;
        public List<Country> Countries = new List<Country>();
        public List<Country> Countries2 = new List<Country>();
        public List<City> cities;
        public List<Airport> Airports;
        public List<TravelerObserver> List_users;
        int bookID;

        public UpdateBooking(int flightId, String flightNo, int capacity, string status, string departure, string destination, 
            DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate,
            decimal price,int bookingID,int flightClassID, int flightID, string seatNo, int travelerID, string passportNo)
        {
            Console.WriteLine("in updaet booking "+ bookingID);
            InitializeComponent();
            populateStatusCombo();
            populateListCombos();
            Class_Load();
            this.bookID = bookingID;
            PopulateCheckboxes(bookID);

            seatnotxt.Text = seatNo;
            txtpassport.Text = passportNo;
            userComboxUser.SelectedItem = travelerID;
            cmbFlightClass.SelectedIndex = (flightClassID)-1;

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



            List_users = User.GetAllTraveler();

            userComboxUser.DataSource = List_users;
            userComboxUser.DisplayMember = "Traveler_id";
            userComboxUser.ValueMember = "Traveler_id";


        }



        private void Class_Load()
        {
            cmbFlightClass.Items.Add("Economy");
            cmbFlightClass.Items.Add("Business");
            cmbFlightClass.Items.Add("First");
        }
        private void PopulateCheckboxes(int bookID)
        {
            List<Service> Selectedservices = Administrator.GetAllServiceByBooking(bookID);

                CheckedListBox checkedListBoxService = this.checkedListBoxService;
                checkedListBoxService.Items.Clear();

                List<Service> services = new List<Service>();

                services = new Administrator().GetAllService();

                checkedListBoxService.Items.Clear();

                foreach (var service in services)
                {
                    checkedListBoxService.Items.Add(service.ServiceName);  
                }

                        List<Service> SelectedservicesOld = Administrator.GetAllServiceByBooking(bookID);
                        for (int i = 0; i < checkedListBoxService.Items.Count; i++)
                        {
                            string serviceName = checkedListBoxService.Items[i].ToString(); 

                            bool isSelected = Selectedservices.Exists(s => s.ServiceName == serviceName);

                            if (isSelected)
                            {
                                checkedListBoxService.SetItemChecked(i, true);
                            }
                            else
                            {
                                checkedListBoxService.SetItemChecked(i, false);
                            }
                        }



            Console.WriteLine("PopulateCheckboxes method completed.");
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

       
    

    

        private void UpdateBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new AdminBookings().Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string destination = cmbDestination.SelectedValue.ToString();
            string duration = $"{dateDepartureDate.Value} - {dateArrivalDate.Value}";
            string seatNo = seatnotxt.Text;
            List<Service> selectedServices = new List<Service>();

            List<Service> allServices = new Administrator().GetAllService();

            foreach (var checkedItem in checkedListBoxService.CheckedItems)
            {
                // Find the full service object by name
                Service service = allServices.FirstOrDefault(s => s.ToString() == checkedItem.ToString());

                if (service != null)
                {
                    selectedServices.Add(service);
                }
            }


            string status = cmbStatus.SelectedItem.ToString();
            int flightClassId = cmbFlightClass.SelectedIndex + 1; 

            int flightId = this.flightID; 
            String flightNo = (textBox1.Text); 
            int travelerId = (int)userComboxUser.SelectedValue; 

            string passportno = txtpassport.Text;
            
            if (string.IsNullOrEmpty(passportno) || string.IsNullOrEmpty(seatNo) || (cmbFlightClass.SelectedIndex < 0) || (userComboxUser.SelectedIndex < 0))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!passportno.All(char.IsDigit))
            {
                MessageBox.Show("Passport number should only contain digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Administrator.updateBooking(bookID, destination, duration, seatNo, selectedServices, status, flightClassId, flightId, flightNo, travelerId, passportno);


        }
    }
}
