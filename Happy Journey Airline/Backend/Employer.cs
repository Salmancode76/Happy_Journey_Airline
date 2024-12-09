using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class Employer : User
    {
        private int employerId;

        public Employer()
        {
        }

        public Employer(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double amount) : base(userId, firstName, lastName, age, email, username, password, role, phoneNo, gender, dob, amount)
        {
            this.employerId = userId;
        }

        public void bookFlight(Booking booking)
        {
            if (booking == null)
            {
                MessageBox.Show("Booking details cannot be null");
                return;
            }

            try
            {
                booking.book();
                MessageBox.Show("Flight Booked Successfully");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Booking error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while booking the flight: " + ex.Message);
            }
        }

        public void displayFlight(Flight f, DataGridView data)
        {
            //Retriece all available flights
            List<Flight> flights = Flight.GetAvailableFlights();
            List<Flight> matchingFlights = new List<Flight>();

            //check for matches in the list first
            foreach (Flight flight in flights)
            {
                //Check if any of the criteria match
                if (f.FlightNo == flight.FlightNo || f.Destination == flight.Destination || f.Departure == flight.Departure || f.Price == flight.Price)
                {
                    matchingFlights.Add(flight);
                }
            }

            // If matches found in the list, bind to DataGridView
            if (matchingFlights.Count > 0)
            {
                data.DataSource = matchingFlights;
            }
            else
            {
                // If no matches found, query the database
                try
                {
                    string query = "SELECT * FROM Flight WHERE flight_no = @flightNo OR destination = @destination OR departure = @departure Or price = @price";

                    SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                    command.Parameters.AddWithValue("@flight_no", f.FlightNo);
                    command.Parameters.AddWithValue("@destination", f.Destination);
                    command.Parameters.AddWithValue("@departure", f.Departure);
                    command.Parameters.AddWithValue("@price", f.Price);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        data.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No flight matches this flight number");
                        data.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    DBManager.getInstance().CloseConnection();
                }
            }
        }


        public void searchFlight(Flight f1, DataGridView data)
        {
            List<Flight> flights = Flight.GetAvailableFlights();
            List<Flight> matchingFlights = new List<Flight>();

            foreach (Flight flight in flights)
            {
                if (f1 == flight)
                {
                    if (flight.FlightNo == f1.FlightNo)
                    {
                        matchingFlights.Add(flight);
                    }
                }
            }
            if (matchingFlights.Count > 0)
            {
                data.DataSource = matchingFlights;
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM Flight WHERE flight_no = @flightNo OR destination = @destination OR departure = @departure Or price = @price";

                    SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                    command.Parameters.AddWithValue("@flight_no", f1.FlightNo);
                    command.Parameters.AddWithValue("@destination", f1.Destination);
                    command.Parameters.AddWithValue("@departure", f1.Departure);
                    command.Parameters.AddWithValue("@price", f1.Price);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        data.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No flight matches the search");
                        data.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    DBManager.getInstance().CloseConnection();
                }
            }
        }
    }
}
