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

        public CreateFlight()
        {
            InitializeComponent();
            populateDepartureCombo();
            populateDestinationCombo();
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

        private void populateDepartureCombo()
        {
            try
            {
                string query = "SELECT a.airport_id, a.airport_name, c.city_name FROM AIRPORT a INNER JOIN CITY c ON a.city_id = c.city_id";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                //Clear the list before adding new items
                departureAirport.Clear();

                while (reader.Read())
                {
                    int airportId = Convert.ToInt32(reader["airport_id"]);
                    string airportName = reader["airport_name"].ToString();
                    string cityName = reader["city_name"].ToString();

                    //Add a tuple with airport ID and concatenated airport name and city name
                    departureAirport.Add((airportId, $"{airportName}, {cityName}"));
                }

                //Check if the list is populated
                if (departureAirport.Count > 0)
                {
                    cmbDeparture.DataSource = departureAirport;
                    cmbDeparture.DisplayMember = "Item2"; //Use Item2 for airport name and city name
                    cmbDeparture.ValueMember = "Item1"; //Use Item1 for airport ID
                }
                else 
                {
                    lblErrorMessage.Text = "No airports found";
                }
            }
            catch (Exception ex)
            {
                //lblErrorMessage.Text = ex.Message;
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        private void populateDestinationCombo()
        {
            try
            {
                string query = "SELECT a.airport_id, a.airport_name, c.city_name FROM AIRPORT a INNER JOIN CITY c ON a.city_id = c.city_id";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                //Clear the list before adding new items
                destinationAirport.Clear();

                while (reader.Read())
                {
                    int airportId = Convert.ToInt32(reader["airport_id"]);
                    string airportName = reader["airport_name"].ToString();
                    string cityName = reader["city_name"].ToString();

                    //Add a tuple with airport ID and concatenated airport name and city name
                    destinationAirport.Add((airportId, $"{airportName}, {cityName}"));
                }

                //Check if the list is populated
                if (destinationAirport.Count > 0)
                {
                    cmbDestination.DataSource = destinationAirport;
                    cmbDestination.DisplayMember = "Item2"; //Use Item2 for airport name and city name
                    cmbDestination.ValueMember = "Item1"; //Use Item1 for airport ID
                }
                else 
                {
                    lblErrorMessage.Text = "No destination airports find";
                }
            }
            catch (Exception ex)
            {
                //lblErrorMessage.Text = ex.Message;
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
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

    }
}
