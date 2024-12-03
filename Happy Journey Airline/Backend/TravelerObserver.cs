using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class TravelerObserver : User
    {
        private int passportNo;
        private string dbConnection;
        private List<Booking> bookingHistory = new List<Booking>();

        public TravelerObserver()
        {
        }

        public TravelerObserver(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public TravelerObserver(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance, int passportNo) : base(userId, firstName, lastName, age, email, username, password, role, phoneNo, gender, dob, balance)
        {
            this.passportNo = passportNo;
        }

        public int PassportNo { get; set; }

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
                bookingHistory.Add(booking);
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

        public void register()
        {
            string message;

            if (!validateInput())
            {
                return;
            }

            if (User.Exists(this.username))
            {
                message = "An account with this username already exists. Proceed to Login";
                return;
            }

            TravelerObserver traveler = new TravelerObserver(this.userId, this.firstName, this.lastName, this.age, this.email, this.username, this.password, this.role, this.phoneNo, this.gender, this.dob, this.balance, this.passportNo);

            try
            {
                SaveTravelerToDatabase(traveler);
                message = "Successful Registration!";
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured during registration: " + e.Message);
            }
        }

        public bool validateInput()
        {
            string message;

            if (string.IsNullOrWhiteSpace(this.firstName))
            {
                message = "First Name cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.lastName))
            {
                message = "Last Name cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.email))
            {
                message = "Email cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.dob))
            {
                message = "Date of Birth cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.phoneNo))
            {
                message = "Phone number cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.gender))
            {
                message = "Gender cannot be empty";
                return false;
            }

            if (this.passportNo <= 0)
            {
                message = "Passport number must be a positive number";
                return false;
            }

            if (this.age <= 0)
            {
                message = "Age must be a positive number";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.username))
            {
                message = "Username cannot be empty";
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.password))
            {
                message = "Password cannot be empty";
                return false;
            }
            return true;
        }

        public void searchFlight(Flight f1, DataGridView data)
        {
            //Retriece all available flights
            List<Flight> flights = Flight.GetAvailableFlights();
            List<Flight> matchingFlights = new List<Flight>();

            //check for matches in the list first
            foreach (Flight flight in flights)
            {
                //Check if any of the criteria match
                if (f1.FlightNo == flight.FlightNo || f1.Destination == flight.Destination || f1.Departure == flight.Departure || f1.Price == flight.Price)
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

                    SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                    command.Parameters.AddWithValue("@flight_no", f1.FlightNo);
                    command.Parameters.AddWithValue("@destination", f1.Destination);
                    command.Parameters.AddWithValue("@departure", f1.Departure);
                    command.Parameters.AddWithValue("@price", f1.Price);

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
                        MessageBox.Show("No Flight matches the search");
                        data.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    DBManager.getInstance("").CloseConnection();
                }
            }
        }
        
        public void SaveTravelerToDatabase(TravelerObserver traveler)
        {
            // Check if the traveler object is null
            if (traveler == null)
            {
                /*Using nameof(traveler) ensures that the name of the parameter is used
                 * which improves maintainability, if the parameter name changes, 
                 * the exception message will automatically reflect that change. 
                 * */
                throw new ArgumentException(" Traveler cannot be null", nameof(traveler));
            }

            try
            { 
                //SQL query to insert into Traveler table
                string query = "INSERT INTO Travelers (first_name, last_name, age, email, passport_no, username, password, role, phoneNo, gender, dob, balance) VALUES (@firstName, @lastName, @age, @email, @passportNo, @username, @password, @role, @phoneNo, @gender, @dob, @balance)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                //Add parameters to the command
                command.Parameters.Add(new SqlParameter("@first_name", traveler.firstName));
                command.Parameters.Add(new SqlParameter("@last_name", traveler.lastName));
                command.Parameters.Add(new SqlParameter("@age", traveler.age));
                command.Parameters.Add(new SqlParameter("@email", traveler.email));
                command.Parameters.Add(new SqlParameter("@passport_no", traveler.passportNo));
                command.Parameters.Add(new SqlParameter("@username", traveler.username));
                command.Parameters.Add(new SqlParameter("@password", traveler.password));
                command.Parameters.Add(new SqlParameter("@role", traveler.role));
                command.Parameters.Add(new SqlParameter("@phone_no", traveler.phoneNo));
                command.Parameters.Add(new SqlParameter("@gender", traveler.gender));
                command.Parameters.Add(new SqlParameter("@dob", traveler.dob));
                command.Parameters.Add(new SqlParameter("@balance", traveler.balance));

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally 
            {
                //Ensure the database connection is closed
                DBManager.getInstance("").CloseConnection();
            }
        }

        public void update(Service services)
        {
            MessageBox.Show("Check out our offer! " + services.ServiceName + ": " + services.Description + ". This plan price is " + services.Price);
        }

        public void sendMessage(string content, int receiverId)
        {
            //Validate input parameters
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Message content cannot be empty");
            }

            if (receiverId <= 0)
            {
                throw new ArgumentException("Receiver ID is invalid.", nameof(receiverId));
            }

            try
            {
                //Creating a new message object
                Message message = new Message(content, this.userId, receiverId);
                
                //save to the database
                message.saveMessage();
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred while sending the message: " + ex.Message);
            }
        }
    }
}
