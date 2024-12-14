using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class Administrator : User
    {
        private int administratorId;
        private Subscription subscription;

        public Administrator()
        {
        }

        public Administrator(Subscription subscription)
        {
            this.subscription = subscription;
        }

        public Administrator(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance) : base(userId, firstName, lastName, age, email, username, password, role, phoneNo, gender, dob, balance)
        {
            this.administratorId = userId;
        }

        public void addBooking(string destination, string duration, string seatNo, List<Service> services, string status, int flightClassId, int flightId, int flightNo, int paymentId, int subscriptionId, int travelerId)
        {
            List<Booking> bookings = new List<Booking>();

            int bookingId = 0; //To store the newly created Booking ID

            try
            {
                Booking booking = new Booking(destination, duration, flightClassId, flightId, flightNo, paymentId, seatNo, services, status, subscriptionId, travelerId);

                bookings.Add(booking);

                //SQL query to insert into booking and get the booking id
                string query = "INSERT INTO Booking (destination, duration, flight_class_id, flight_id, flight_no, payment_id, seat_no, status, subscription_id, traveler_id) " +
                               "OUTPUT INSERTED.booking_id VALUES (@Destination, @Duration, @FlightClassId, @FlightId, @FlightNo, @PaymentId, @SeatNo, @Status, @SubscriptionId, @TravelerId)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@destination", booking.Destination);
                command.Parameters.AddWithValue("@duration", booking.Duration);
                command.Parameters.AddWithValue("@flight_class_id", booking.FlightClass.FlightClassId);
                command.Parameters.AddWithValue("@flight_id", booking.Flight.FlightId);
                command.Parameters.AddWithValue("@flight_no", booking.Flight.FlightNo);
                command.Parameters.AddWithValue("@payment_id", booking.Payment.PaymentId);
                command.Parameters.AddWithValue("@seat_no", booking.SeatNo);
                command.Parameters.AddWithValue("@status", booking.Status);
                command.Parameters.AddWithValue("@suscription_id", booking.Subscription.SubscriptionId);
                command.Parameters.AddWithValue("@traveler_id", booking.Traveler.UserId);

                //Execute the command and get the newly created booking id
                bookingId = (int)command.ExecuteScalar(); //Using Execute Scalar to get the booking id

                //Insert into Services into the bookingService table
                if (services != null && services.Count > 0)
                {
                    foreach (var service in services)
                    {
                        string serviceQuery = "INSERT INTO BookingService (booking_id, service_id) VALUES (@bookingId, @serviceId)";

                        SqlCommand cmd = new SqlCommand(serviceQuery, DBManager.getInstance().OpenConnection());

                        cmd.Parameters.AddWithValue("@booking_id", bookingId);
                        cmd.Parameters.AddWithValue("@service_id", service.ServiceId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new booking: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addService(string serviceName, string description, double price)
        {
            try
            {
                Service service = new Service(serviceName, description, price);

                //SQL Query to insert the service
                string query = "INSERT INTO Service (service_name, description, price) VALUES (@serviceName, @description, @price)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@service_name", service.ServiceName);
                command.Parameters.AddWithValue("@description", service.Description);
                command.Parameters.AddWithValue("@price", service.Price);

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new service: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addFlight(int flightNo, int capacity, string status, string departure, string destination, DateTime departureTime, DateTime arrivalTime, double price)
        {
            try
            {
                Flight flight = new Flight(flightNo, capacity, status, departure, destination, departureTime, arrivalTime, price);

                //SQL tquery to insert the flight
                string query = "INSERT INTO Flight (flight_no, capacity, departure, destination, departureTime, arrivalTime, price) VALUES (@flightNo, @capacity, @departure, @destination, @departureTime, @arrivalTime, @price)";
                
                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());
                
                command.Parameters.AddWithValue("@flight_no", flight.FlightNo);
                command.Parameters.AddWithValue("@capacity", flight.Capacity);
                command.Parameters.AddWithValue("@status", flight.Status);
                command.Parameters.AddWithValue("@departure", flight.Departure);
                command.Parameters.AddWithValue("@destination", flight.Destination);
                command.Parameters.AddWithValue("@departure_time", departureTime);
                command.Parameters.AddWithValue("@arrival_time", arrivalTime);
                command.Parameters.AddWithValue("@price", flight.Price);

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new flight: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addUser(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance)
        {
            List<User> users = new List<User>();

            try
            {
                User user = new User(userId, firstName, lastName, age, email, username, password, role, phoneNo, gender, dob, balance);
                users.Add(user);

                //SQL query to insert to User table
                string query = "INSERT INTO User (name, age, email, username, password, role, phone_no, gender, dob, balance) VALUES ()";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@first_name", user.FirstName);
                command.Parameters.AddWithValue("@last_name", user.LastName);
                command.Parameters.AddWithValue("@age", user.Age);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role);
                command.Parameters.AddWithValue("@phone_no", user.PhoneNo);
                command.Parameters.AddWithValue("@gender", user.Gender);
                command.Parameters.AddWithValue("@dob", user.Dob);
                command.Parameters.AddWithValue("@balance", 5000); //set user's balance to 5000 each time a user is added

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new user: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addAirport(string airportCode, string airportName)
        {
            //Validate input parameters
            if (string.IsNullOrWhiteSpace(airportCode))
            {
                throw new ArgumentException("Airport code must not be empty");
            }

            if (string.IsNullOrWhiteSpace(airportName))
            {
                throw new ArgumentException("Airport name must not be empty");
            }

            try 
            {
                //Create new airport object
                Airport airport = new Airport(airportCode, airportName);

                //SQL query to insert into Airport
                string query = "INSERT INTO Airport (airport_code, airport_name) VALUES (@airportCode, @airportName)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //Add parameters to the command
                command.Parameters.AddWithValue("@airport_code", airport.AirportCode);
                command.Parameters.AddWithValue("@airport_name", airport.AirportName);

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new airport: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addCity(string cityName)
        {
            //Validate input parameter
            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new ArgumentException("City name cannot be empty");
            }

            try
            {
                //Create a new city object
                City city = new City(cityName);

                //SQL query to insert into City table
                string query = "INSERT INTO City (city_name) VALUES (@cityName)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //Add parameters to the command
                command.Parameters.AddWithValue("@city_name", city.CityName);

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new city: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addCountry(string countryName, string region)
        {
            //Validate input parameters
            if (string.IsNullOrWhiteSpace(countryName))
            {
                throw new ArgumentException("Country name cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentException("Region cannot be empty");
            }

            try
            {
                //Create a new country object
                Country country = new Country(countryName, region);

                //SQL query to insert into country table
                string query = "INSERT INTO Country (country_name, region) VALUES (@countryName, @region)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //Add parameters to the command
                command.Parameters.AddWithValue("@country_name", country.CountryName);
                command.Parameters.AddWithValue("@region", country.Region);

                //Execute the command
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new country: " + ex.Message);
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addMessage(string content, int receiverId)
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
                //Create a new Message Object
                Message message = new Message(content, this.userId, receiverId);

                //Save the Message to the database
                message.saveMessage();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding new message: " + ex.Message);
            }
        }

        public void deleteUser(int userId)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserId == userId)
                {
                    users.RemoveAt(i);
                    deleteUSerFromDatabase(userId);
                    return;
                }
            }
        }

        public static void displayUsers(User user, DataGridView data)
        {
            //Invoke getUsers from User class to loop through the users list
            User.getUsers();

            //If the list contains any elements display it in the grid view
            if (User.users != null && User.users.Count > 0)
            {
                data.DataSource = User.users;
            }
            else
            {
                MessageBox.Show("No users found");
            }
        }

        public void deleteUSerFromDatabase(int userId)
        {
            string message;
            try
            {
                string query = "DELETE FROM User WHERE user_id = @userId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@userId", userId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    message = "User Deleted Successfully";
                }
                else
                {
                    message = "User not found in the database";
                }
            }
            catch (Exception e)
            {
                message = "Error deleting user: " + e.Message;
                message = "An error occurred while trying to delete the user";
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }
        }

        //Method to validate email format
        public bool isValidEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch 
            { 
                return false;
            }
        }

        public void userInputValidation(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than zero.", nameof(userId));
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.");
            }

            if(string.IsNullOrWhiteSpace(lastName))
            { 
                throw new ArgumentException("Last name cannot be empty.");
            }

            if (age <= 0)
            {
                throw new ArgumentException("Age must be positive.", nameof(age));
            }

            if (string.IsNullOrWhiteSpace (email) || !isValidEmail(email))
            {
                throw new ArgumentException("Invalid email address.", nameof(email));
            }

            if (string.IsNullOrWhiteSpace(username))
            { 
                throw new ArgumentException("Username cannot be empty.", nameof(username));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty.", nameof(password));
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                throw new ArgumentException("Role cannot be empty.", nameof(role));
            }

            if (string.IsNullOrWhiteSpace(phoneNo))
            {
                throw new ArgumentException("Phone number cannot be empty.", nameof(phoneNo));
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentException("Gender cannot be empty.", nameof(gender));
            }

            if (string.IsNullOrWhiteSpace(dob))
            {
                throw new ArgumentException("Date of birth cannot be empty.", nameof(dob));
            }
        }

        public void updateUser(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance)
        {
            //Invoke user input validation method
            userInputValidation(userId, firstName, lastName, age, email, username, password, role, phoneNo, gender, dob, balance);
            
            try
            {
                string query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Email = @Email, Username = @Username, Password = @Password, Role = @Role, PhoneNo = @PhoneNo, Gender = @Gender, DOB = @DOB, Balance = @Balance WHERE UserId = @User Id";

                using (SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection()))
                {
                    command.Parameters.AddWithValue("@User Id", userId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); 
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Balance", 5000);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No user found with the specified User ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the user: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateService(int serviceId, string serviceName, string description, double price)
        {
            // Validate input parameters
            if (serviceId <= 0)
            {
                throw new ArgumentException("Service ID must be greater than zero.", nameof(serviceId));
            }
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                throw new ArgumentException("Service name cannot be empty.", nameof(serviceName));
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be empty.", nameof(description));
            }
            if (price < 0)
            {
                throw new ArgumentException("Price must be positive.", nameof(price));
            }

            try
            {
                string query = "UPDATE Services SET service_name = @serviceName, description = @description, price = @price WHERE service_id = @serviceId";

                using (SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection()))
                {
                    command.Parameters.AddWithValue("@service_id", serviceId);
                    command.Parameters.AddWithValue("@service_name", serviceName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No service found with the specified Service ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the service: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateFlight(int flightId, int flightNo, int capacity, string status, string departure, string destination, DateTime departureTime, DateTime arrivalTime, double price)
        {
            // Validate input parameters
            if (flightId <= 0)
            {
                throw new ArgumentException("Flight ID must be greater than zero.", nameof(flightId));
            }
            if (flightNo <= 0)
            {
                throw new ArgumentException("Flight number must be greater than zero.", nameof(flightNo));
            }
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
            }
            if (string.IsNullOrWhiteSpace(status))
            {
                throw new ArgumentException("Flight status cannot be empty.", nameof(status));
            }
            if (string.IsNullOrWhiteSpace(departure))
            {
                throw new ArgumentException("Departure cannot be empty.", nameof(departure));
            }
            if (string.IsNullOrWhiteSpace(destination))
            {
                throw new ArgumentException("Destination cannot be empty.", nameof(destination));
            }

            if (departureTime <= DateTime.Now)
            {
                throw new ArgumentException("Departure time must be in the future.", nameof(departureTime));
            }

            if (arrivalTime <= departureTime)
            {
                throw new ArgumentException("Arrival time must be after departure time.", nameof(arrivalTime));
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.", nameof(price));
            }

            try
            {
                string query = "UPDATE Flights SET flight_no = @flightNo, capacity = @capacity, status = @status, departure = @departure, destination = @destination, departure_time = @departureTime, arrivale_time = @arrivalTime, price = @price WHERE flight_id = @flightId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());
                
                    command.Parameters.AddWithValue("@flight_id", flightId);
                    command.Parameters.AddWithValue("@flight_no", flightNo);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@departure", departure);
                    command.Parameters.AddWithValue("@destination", destination);
                    command.Parameters.AddWithValue("@departure_time", departureTime);
                    command.Parameters.AddWithValue("@arrival_time", arrivalTime);
                    command.Parameters.AddWithValue("@price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No flight found with the specified Flight ID.");
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the flight: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }
        
        public void bookingValidation(int bookingId, string destination, string duration, int seatNo, string status, int flightClassId, int flightId, int flightNo, int paymentId, int subscriptionId, int travelerId)
        {
            //Validate input Parameter
            if (bookingId <= 0)
            {
                throw new ArgumentException("Booking ID must be greater than zero.", nameof(flightId));
            }

            if (string.IsNullOrWhiteSpace(destination))
            {
                throw new ArgumentException("Destination cannot be empty.", nameof(destination));
            }

            if (string.IsNullOrWhiteSpace(duration))
            {
                throw new ArgumentException("Duration cannot be empty.", nameof(duration));
            }

            if (seatNo <= 0)
            {
                throw new ArgumentException("Seat number must be greater than zero.", nameof(flightNo));
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                throw new ArgumentException("Booking status cannot be empty.", nameof(status));
            }

            if (flightClassId <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.", nameof(flightClassId));
            }

            if (flightId <= 0)
            {
                throw new ArgumentException("Flight Id must be greater than zero.", nameof(flightId));
            }

            if (flightNo <= 0)
            {
                throw new ArgumentException("Flight Number mus tbe positive");
            }

            if (paymentId <= 0)
            {
                throw new ArgumentException("Payment ID must be positive");
            }

            if (subscriptionId <= 0)
            {
                throw new ArgumentException("Subscription ID must be positive");
            }

            if (travelerId <= 0)
            {
                throw new ArgumentException("Traveler ID must be positive.");
            }
        }

        public void updateBooking(int bookingId, string destination, string duration, int seatNo, List<Service> services, string status, int flightClassId, int flightId, int flightNo, int paymentId, int subscriptionId, int travelerId)
        {
            //Invoke booking fields validation
            bookingValidation(bookingId, destination, duration, seatNo, status, flightClassId, flightId, flightNo, paymentId, subscriptionId, travelerId);

            try
            {
                //Update the booking details
                string query = "UPDATE Booking SET destination = @destination, duration = @duration, seat_no = @seatNo, status = @status, flight_class_id = @flightClassId, flight_id = @flightId, payment_id = @paymentId, subscription_id = @subscriptionId, traveler_id = @travelerId WHERE booking_id = @bookingId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@booking_id", bookingId);
                command.Parameters.AddWithValue("@destination", destination);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@seat_no", seatNo);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@flight_class_id", flightClassId);
                command.Parameters.AddWithValue("@flight_id", flightId);
                command.Parameters.AddWithValue("@payment_id", paymentId);
                command.Parameters.AddWithValue("@subsription_id", subscriptionId);
                command.Parameters.AddWithValue("@traveler_id", travelerId);

                int affectedRow = command.ExecuteNonQuery();

                if (affectedRow == 0)
                {
                    throw new Exception("No booking found with the specified booking ID.");
                }

                //Update the booking service table
                string deleteQuery = "DELETE FROM BookingService WHERE booking_id = @bookingId";

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, DBManager.getInstance().OpenConnection());

                deleteCommand.Parameters.AddWithValue("@booking_id", bookingId);

                deleteCommand.ExecuteNonQuery();

                //Insert new service
                string insertQuery = "INSERT INTO BookingService () VALUES ()";


                foreach (Service service in services)
                {

                    SqlCommand insertCommand = new SqlCommand(insertQuery, DBManager.getInstance().OpenConnection());

                    insertCommand.Parameters.AddWithValue("@booking_id", bookingId);
                    insertCommand.Parameters.AddWithValue("@service_id", service.ServiceId);

                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the booking: " + ex.Message); ;
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateAirport(int airportId, string airportCode, string airportName)
        {
            if(airportId <= 0)
            {
                throw new ArgumentException();
            }

            if (string.IsNullOrWhiteSpace(airportCode))
            {
                throw new ArgumentException();
            }

            if (string.IsNullOrWhiteSpace(airportName))
            {
                throw new ArgumentException();
            }

            try
            {
                //SQL query to update the airport details
                string query = "UPDATE Airport SET airport_name = @airportName, airport_code = @airportCode WHERE airport_id = @airportId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@airport_id", airportId);
                command.Parameters.AddWithValue("@airport_code", airportCode);
                command.Parameters.AddWithValue("@airport_name", airportName);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the airport: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateCity(int cityId, string cityName)
        {
            //Validate input parameters
            if (cityId <= 0)
            {
                throw new ArgumentException("city Id must be positive");
            }

            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new ArgumentException("city name cannot be empty");
            }

            try
            {
                //SQL query for updating city details
                string query = "UPDATE City SET city_name = @cityName WHERE city_id = @cityId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@city_id", cityId);
                command.Parameters.AddWithValue("@city_name", cityName);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the city: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateCountry(int countryId, string countryName, string region)
        {
            //Validate country input
            /*if (countryId <= 0)
            {
                throw new ArgumentException("Country ID must be positive");
            }*/

            if (string.IsNullOrWhiteSpace (countryName))
            { 
                throw new ArgumentException("Country name cannot be emoty");
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentException("Region cannot be empty");
            }

            try
            {
                //SQL query to update the country details
                string query = "UPDATE Country SET country_name = @countryName, region = @region WHERE country_id = @countryId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //command.Parameters.AddWithValue("@country_id", countryId);
                command.Parameters.AddWithValue("@country_name", countryName);
                command.Parameters.AddWithValue("@region", region);
                
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the country: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void deleteAirport(int airportId)
        {
            try
            {
                //SQL query for deleting an airport
                string query = "DELETE FROM Airport WHERE airport_id = @aiportId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@airport_id", airportId);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the airport: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void deleteService(int serviceId)
        {
            try
            {
                string query = "DELETE FROM Service WHERE service_id = @serviceId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@service_id", serviceId);

                command.ExecuteNonQuery(); 
              
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the service: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void deleteFlight(int flightId)
        {
            try
            {
                string query = "DELETE FROM Flight WHERE flight_id = @flightId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@flight_id", flightId);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the flight: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void deleteBooking(int bookingId)
        {
            try
            {
                string query = "DELETE FROM Booking WHERE booking_id = @bookingId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@booking_id", bookingId);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the booking: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void postDetailsForUpcomingFlights(DataGridView data)
        {
            try
            {
                List<Flight> upcomingFlight = new List<Flight>();

                //Fetch upcoming flights from the database
                string query = "SELECT flight_id, flight_no, departure, destination, departure_time, arrival_time FROM Flight WHERE departure_time > @CurrentTime";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    upcomingFlight.Add(new Flight { FlightId = reader.GetInt32(0), FlightNo = reader.GetInt32(1), Departure = reader.GetString(2), Destination = reader.GetString(3), DepartureTime = reader.GetDateTime(4), ArrivalTime = reader.GetDateTime(5) });
                }

                data.DataSource = upcomingFlight;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while posting details for upcoming flights: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection() ;
            }
        }

        public void performDbBackup(string backupFilePath)
        {                           //create a file to save all the db in it and copy its path - eg: backupFilePath = @"C:\Backups\YourDatabaseBackup.bak"
            string message;
            try
            {                                    //keep the actual database name
                string query = $"BACKUP DATABASE [DATABASE NAME] TO DISK = @backupFilePath WITH FORMAT, INIT";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@backupFilePath", backupFilePath);

                command.ExecuteNonQuery();

                message = "Database Backup Completed Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while performing DataBase Backup: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void addServiceOffers(string serviceName, string description, double price)
        {
            string message;
            try
            {
                Service service = new Service(serviceName, description, price);

                var existingOffer = subscription.ServicesSubscription.FirstOrDefault(s => s.ServiceName.Equals(serviceName, StringComparison.OrdinalIgnoreCase));


                if (existingOffer == null)
                {
                    //Add new service
                    string query = "INSERT INTO Service (service_name, description, price) VALUES (@serviceName, @description, @price)";

                    SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                    command.Parameters.AddWithValue("@service_name", serviceName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();

                    subscription.addService(service);
                    message = "Service Added Successfully";
                }
                else
                {
                    message = "Service already exists.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the service: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void updateServiceOffers(int serviceId, string serviceName, string description, double price)
        {
            string message;
            try
            {
                var existingOffer = subscription.ServicesSubscription.FirstOrDefault(s => s.ServiceName.Equals(serviceName, StringComparison.OrdinalIgnoreCase));


                if (existingOffer != null)
                {
                    string query = "UPDATE Service SET service_name = @serviceName, description = @description, price = @price WHERE service_id = @serviceId";

                    SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                    command.Parameters.AddWithValue("@service_name", serviceName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();

                    existingOffer.Description = description;
                    existingOffer.Price = price;
                    message = "Service already exists. Updating the existing service.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the service: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }

        public void deleteServiceOffers(int serviceId)
        {
            try
            {
                string query = "DELETE FROM Service WHERE service_id = @serviceId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@service_id", serviceId);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the service: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
        }
    }
}
