using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

        public Administrator(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Administrator(Subscription subscription)
        {
            this.subscription = subscription;
        }

        public Administrator(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance) : base(userId, firstName, lastName, age, email, username, password, "Admin", phoneNo, gender, dob, balance)
        {
            this.administratorId = userId;
        }


        public static void addBooking(string destination, string duration, string seatNo, List<Service> services, string status, int flightClassId, int flightId, string flightNo, int travelerId, string passportNo, int? paymentId = null)
        {
            List<Booking> bookings = new List<Booking>();

            // Log input parameters for debugging
            Console.WriteLine($"FlightClassId: {flightClassId}, FlightId: {flightId}, SeatNo: {seatNo}, Status: {status}, TravelerId: {travelerId}");

            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                // Open the database connection
                connection = DBManager.getInstance().OpenConnection();
                transaction = connection.BeginTransaction();

                // Create a new booking object
                Booking booking = new Booking(destination, duration, flightClassId, flightId, flightNo, seatNo, services, status, travelerId);
                bookings.Add(booking);

                // SQL query to insert into booking and get the booking id
                string query = @"
            INSERT INTO [dbo].[Booking]
            ([flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo])
            VALUES
            (@FlightClassId, @FlightId, @SeatNo, @TravelerId,@passportNo);
            SELECT SCOPE_IDENTITY();";  // This will return the ID of the newly inserted booking

                // Log the query for debugging
                Console.WriteLine("Executing SQL Query: " + query);

                SqlCommand command = new SqlCommand(query, connection, transaction);

                // Add parameters for the booking
                command.Parameters.AddWithValue("@FlightClassId", flightClassId);
                command.Parameters.AddWithValue("@FlightId", flightId);
                command.Parameters.AddWithValue("@SeatNo", seatNo);
                command.Parameters.AddWithValue("@TravelerId", travelerId);
                command.Parameters.AddWithValue("@passportNo", passportNo);

                // Use DBNull.Value for null paymentId if provided

                // Execute the command and get the newly created booking id
                var bookingId = command.ExecuteScalar();

                Console.WriteLine($"Booking created successfully with ID: {bookingId}");

                // Insert services if any
                
                    foreach (var service in services)
                    {
                        string serviceQuery = "INSERT INTO [dbo].[Service Booking] (service_id, booking_id) VALUES (@ServiceId, @BookingId)";

                        Console.WriteLine(service.ServiceName);

                        SqlCommand serviceCmd = new SqlCommand(serviceQuery, connection, transaction);
                        serviceCmd.Parameters.AddWithValue("@BookingId", bookingId);
                        serviceCmd.Parameters.AddWithValue("@ServiceId", service.ServiceId);

                        serviceCmd.ExecuteNonQuery();
                    }
                


                // Commit the transaction
                MessageBox.Show("BOOKED SUCCESSFULLY!",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                // Log SQL errors and roll back the transaction if something goes wrong
                Console.WriteLine($"SQL Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);

                // Rollback the transaction if an error occurs
                if (transaction != null)
                {
                    transaction.Rollback();
                }

                throw;
            }
            finally
            {
                // Ensure the connection is closed properly
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static void addService(string serviceName, string description, double price)
        {
            try
            {

                Service service = new Service(serviceName, description, price);

                //SQL Query to insert the service
                string query = "INSERT INTO Service (service_name, description, price) VALUES (@serviceName, @description, @price)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@serviceName", serviceName);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);

                //Execute the command
                command.ExecuteNonQuery();

                MessageBox.Show("SERVICE ADDED SUCCESSFULLY!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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

        public static void addFlight(string flightNo, int capacity, string status, int departure, int destination, DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate, decimal price)
        {
            try
            {
                Flight flight = new Flight(flightNo, capacity, status, departure, destination, departureTime, arrivalTime, departureDate, arrivalDate, price);

                //SQL tquery to insert the flight
                string query = "INSERT INTO Flight (flight_no, capacity,status, departure, destination, departure_time, arrival_Time, departure_date, arrival_date, price) VALUES (@flightNo, @capacity, @status,@departure, @destination, @departureTime, @arrivalTime, @departureDate, @arrivalDate, @price)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@flightNo", flight.FlightNo);
                command.Parameters.AddWithValue("@capacity", flight.Capacity);
                command.Parameters.AddWithValue("@status", flight.Status);
                command.Parameters.AddWithValue("@departure", flight.Departure);
                command.Parameters.AddWithValue("@destination", flight.Destination);
                command.Parameters.AddWithValue("@departureTime", departureTime);
                command.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                command.Parameters.AddWithValue("@departureDate", departureDate);
                command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                command.Parameters.AddWithValue("@price", flight.Price);

                //Execute the command
                command.ExecuteNonQuery();
                MessageBox.Show("Flight created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public static void addAirport(int cityID, string airportName)
        {
            //Validate input parameters


            if (string.IsNullOrWhiteSpace(airportName))
            {
                throw new ArgumentException("Airport name must not be empty");
            }

            try
            {
                //Create new airport object
                Airport airport = new Airport(airportName, cityID);

                string query = "INSERT INTO [dbo].[Airport] ([city_id], [airport_name]) VALUES (@cityId, @airportName)";

                // Create a SQL command object
                SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@cityId", cityID);
                cmd.Parameters.AddWithValue("@airportName", airportName);

                // Execute the query
                cmd.ExecuteNonQuery();

                MessageBox.Show("AIRPORT ADDED SUCCESSFULLY!",
         "Success",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information);

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

        public void addCity(int CountryID, string cityName)
        {
            //Validate input parameter
            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new ArgumentException("City name cannot be empty");
            }

            try
            {
                //Create a new city object
                City city = new City(CountryID, cityName);

                //SQL query to insert into City table
                string query = "INSERT INTO [dbo].[City] ([country_id],[city_name])  VALUES (@CountryID,@city_name)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //Add parameters to the command
                command.Parameters.AddWithValue("@CountryID", city.CountryID);

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
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            countryName = textInfo.ToTitleCase(countryName.ToLower().Trim());
            region = region.Trim();

            //Validate input parameters
            if (string.IsNullOrWhiteSpace(countryName))
            {
                MessageBox.Show("Country name cannot be empty.",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                MessageBox.Show("Region name cannot be empty.",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Create a new country object
                Country country = new Country(countryName, region);


                //SQL query to insert into country table
                string query = "INSERT INTO [dbo].[Country] ([region],[country_name]) VALUES ( @region,@countryName)";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                //Add parameters to the command
                command.Parameters.AddWithValue("@countryName", countryName);
                command.Parameters.AddWithValue("@region", region);

                //Execute the command
                command.ExecuteNonQuery();
                MessageBox.Show("COUNTRY ADDED SUCCESSFULLY!",
             "Success",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something Bad Happend Contact Support.",
                                                 "Error",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                return;
            }
            finally
            {
                //Ensure the database connection is closed
                DBManager.getInstance().CloseConnection();
            }

        }

        public static List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            String stmt = "SELECT [country_id],[region] ,[country_name]  FROM [dbo].[Country]";

            SqlCommand cmd = new SqlCommand(stmt, DBManager.getInstance().OpenConnection());

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Country country = new Country
                {
                    CountryId = Convert.ToInt32(reader["country_id"]),

                    CountryName = reader["country_name"].ToString(),
                    Region = reader["region"].ToString(),


                };
                countries.Add(country);



            }
            reader.Close();
            return countries;

        }
        public static List<Airport> GetAllAirports()
        {
            List<Airport> airports = new List<Airport>();

            String query = "SELECT * FROM [dbo].[Airport]";

            SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Airport ap = new Airport(
                    Convert.ToInt32(reader["airport_id"]),
                    reader["airport_name"].ToString(),
                    Convert.ToInt32(reader["city_id"])
                );

                airports.Add(ap);
            }
            reader.Close();
            return airports;


        }
        public static List<City> GetAllcities()
        {
            List<City> cities = new List<City>();

            String query = "SELECT [city_id] ,[country_id],[city_name] FROM [dbo].[City]";


            SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                City city = new City
                (
                    Convert.ToInt32(reader["city_id"]),
                     Convert.ToInt32(reader["country_id"]),
                     reader["city_name"].ToString()

                );
                cities.Add(city);
            }
            reader.Close();

            return cities;
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

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be empty.");
            }

            if (age <= 0)
            {
                throw new ArgumentException("Age must be positive.", nameof(age));
            }

            if (string.IsNullOrWhiteSpace(email) || !isValidEmail(email))
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

        public static void updateService(int serviceId, string serviceName, string description, double price)
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

                string query = "UPDATE Service SET service_name = @serviceName, description = @description, price = @price WHERE service_id = @serviceId";

                using (SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection()))
                {
                    command.Parameters.AddWithValue("@serviceId", serviceId);
                    command.Parameters.AddWithValue("@serviceName", serviceName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No service found with the specified Service ID.");
                    }
                    MessageBox.Show("Service updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public static void updateFlight(int flightId, String flightNo, int capacity, string status, string departure, string destination, DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate, decimal price)
        {


            try
            {
                string query = "UPDATE Flight SET flight_no = @flightNo, capacity = @capacity, status = @status, departure = @departure, destination = @destination, departure_time = @departureTime, arrival_time = @arrivalTime, departure_date = @departureDate, arrival_date = @arrivalDate, price = @price WHERE flight_id = @flightId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@flightId", flightId);
                command.Parameters.AddWithValue("@flightNo", flightNo);
                command.Parameters.AddWithValue("@capacity", capacity);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@departure", departure);
                command.Parameters.AddWithValue("@destination", destination);
                command.Parameters.AddWithValue("@departureTime", departureTime);
                command.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                command.Parameters.AddWithValue("@departureDate", departureDate);
                command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                command.Parameters.AddWithValue("@price", price);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("No flight found with the specified Flight ID.");
                }
                else
                {
                    MessageBox.Show("Flight Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public static void updateBooking(int bookingId, string destination, string duration, string seatNo, List<Service> services, string status, int flightClassId, int flightId, string flightNo, int travelerId, string passportNo, int? paymentId = null)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            SqlCommand updateCommand = null;
            SqlCommand deleteCommand = null;
            SqlCommand serviceCmd = null;

            try
            {
                // Open the database connection
                connection = DBManager.getInstance().OpenConnection();
                transaction = connection.BeginTransaction();

                // Update the booking details (adding destination, duration, etc.)
                string updateQuery = @"UPDATE [dbo].[Booking]
                              SET [seat_no] = @seatNo,
                                  [flight_class_id] = @flightClassId,
                                  [traveler_id] = @travelerId,
                                  [passportNo] = @passportNo
                              WHERE [booking_id] = @booking_id";

                updateCommand = new SqlCommand(updateQuery, connection, transaction);
                updateCommand.Parameters.AddWithValue("@booking_id", bookingId);
                updateCommand.Parameters.AddWithValue("@seatNo", seatNo);
                updateCommand.Parameters.AddWithValue("@flightClassId", flightClassId);
                updateCommand.Parameters.AddWithValue("@travelerId", travelerId);
                updateCommand.Parameters.AddWithValue("@passportNo", passportNo);

                int affectedRow = updateCommand.ExecuteNonQuery();

                if (affectedRow == 0)
                {
                    throw new Exception("No booking found with the specified booking ID.");
                }

                // Delete old services before inserting new ones
                string deleteQuery = "DELETE FROM [dbo].[Service Booking] WHERE booking_id = @bookingId";
                deleteCommand = new SqlCommand(deleteQuery, connection, transaction);
                deleteCommand.Parameters.AddWithValue("@bookingId", bookingId);
                deleteCommand.ExecuteNonQuery();

                // Insert new services
                foreach (var service in services)
                {
                    string serviceQuery = "INSERT INTO [dbo].[Service Booking] (service_id, booking_id) VALUES (@ServiceId, @BookingId)";
                    serviceCmd = new SqlCommand(serviceQuery, connection, transaction);
                    serviceCmd.Parameters.AddWithValue("@BookingId", bookingId);
                    serviceCmd.Parameters.AddWithValue("@ServiceId", service.ServiceId);

                    serviceCmd.ExecuteNonQuery();
                }

                // Commit the transaction if everything goes well
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // If an error occurs, roll back the transaction
                if (transaction != null && transaction.Connection != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        // Handle rollback failure (log, rethrow, etc.)
                        throw new Exception("An error occurred during transaction rollback: " + rollbackEx.Message);
                    }
                }

                throw new Exception("An error occurred while updating the booking: " + ex.Message);
            }
            finally
            {
                // Ensure that the connection and commands are properly closed/disposed
                if (serviceCmd != null)
                {
                    serviceCmd.Dispose();
                }
                if (deleteCommand != null)
                {
                    deleteCommand.Dispose();
                }
                if (updateCommand != null)
                {
                    updateCommand.Dispose();
                }
                if (connection != null)
                {
                    DBManager.getInstance().CloseConnection();
                }
            }
        }




        public void updateAirport(int airportId, string airportCode, string airportName)
        {
            if (airportId <= 0)
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

            if (string.IsNullOrWhiteSpace(countryName))
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
        public static Service GetServiceByID(int serviceId)
        {

            string stmt = "SELECT * FROM [dbo].[Service] WHERE service_id = @service_id";

            SqlCommand cmd = new SqlCommand(stmt, DBManager.getInstance().OpenConnection());

            cmd.Parameters.AddWithValue("@service_id", serviceId);

            Service service = null; // Initialize service to null

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Create the service object from the data
                    service = new Service(
                        Convert.ToInt32(reader["service_id"]),
                        reader["service_name"].ToString(),
                        reader["description"].ToString(),
                        Convert.ToDouble(reader["price"])
                    );
                }

                reader.Close(); // Always close the reader after use
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DBManager.getInstance().CloseConnection();
            }

            return service; // Return the service object (or null if not found)
        }



        public static void deleteService(int serviceId)
        {
            try
            {
                string query = "DELETE FROM Service WHERE service_id = @serviceId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@serviceId", serviceId);

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

        public static void deleteFlight(int flightId)
        {
            try
            {
                string query = "DELETE FROM Flight WHERE flight_id = @flightId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@flightId", flightId);

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

        public static void deleteBooking(int bookingId)
        {
            try
            {
                string query = "DELETE FROM [dbo].[Booking] WHERE booking_id = @bookingId";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@bookingId", bookingId);

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
        public static void DeleteBookingService(int bookingId)
        {
            try
            {
                string query = "DELETE FROM [dbo].[Service Booking] WHERE booking_id = @bookingId";
                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                command.Parameters.AddWithValue("@bookingId", bookingId);

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
                    upcomingFlight.Add(new Flight { FlightId = reader.GetInt32(0), FlightNo = reader.GetString(1), Departure = reader.GetInt32(2), Destination = reader.GetInt32(3), DepartureTime = reader.GetDateTime(4), ArrivalTime = reader.GetDateTime(5) });
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

        public void SendMessageToAllAdmins(string content)
        {
            List<Administrator> admins = GetAllAdmins(); 
            foreach (var admin in admins)
            {
                Message message = new Message(content, this.userId, admin.UserId);
                message.saveMessage();
            }
        }

        private List<Administrator> GetAllAdmins()
        {
            List<Administrator> admins = new List<Administrator>();
            // retrieve all admins from the database
            string query = "SELECT user_id, first_name, last_name FROM Users WHERE role = 'Admin'";
            SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string firstName = reader.GetString(1);
                string lastName = reader.GetString(2);
                admins.Add(new Administrator(userId, firstName, lastName));
            }
            
            return admins;
        }


        public  List<Service> GetAllService()
        {
            List<Service> services = new List<Service>();
            string query = "SELECT * FROM Service";
            SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Service service = new Service()
                {
                    ServiceId = reader.GetInt32(0),
                    ServiceName = reader.GetString(1),
                   // price = reader.GetDouble(2),
                   // Description = reader.GetString(3),

                };   


                services.Add(service);
            }
            DBManager.getInstance().CloseConnection();




            return services;


        }
        public static List<Flight> GetAllFlights()
        {
            List <Flight> flights = new List<Flight>();



            string stmt = "SELECT*  FROM[dbo].[Flight]";

            DBManager con = DBManager.getInstance();
            SqlCommand cmd = new SqlCommand(stmt, con.OpenConnection());


            SqlDataReader reader = (cmd.ExecuteReader());


            while (reader.Read())
            {
                Flight flight = new Flight
                {
                    FlightId = reader.GetInt32(0),
                    Departure = reader.GetInt32(1),
                    Destination = reader.GetInt32(2),
                    FlightNo = reader.GetString(3),
                    Capacity = reader.GetInt32(4),
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")), // Adjusted to GetDecimal
                    Status = reader.GetString(6),
                    DepartureTime = reader.GetDateTime(7),
                    ArrivalTime = reader.GetDateTime(8),
                    DepartureDate = reader.GetDateTime(9),
                    ArrivalDate = reader.GetDateTime(10)
                };




                flights.Add(flight);
            }

            con.CloseConnection();
            return flights;
        }
        public static List<Service> GetAllServiceByBooking(int bookingID)
        {
            List<Service> services = new List<Service>();

            string query = @"SELECT s.service_id, s.service_name, s.description, s.price 
                     FROM [Service Booking] sb
                     JOIN [Service] s ON s.service_id = sb.service_id
                     WHERE sb.booking_id = @bookingID";

            SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());
            command.Parameters.AddWithValue("@bookingID", bookingID);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Service service = new Service()
                {
                    ServiceId = reader.GetInt32(0),
                    ServiceName = reader.GetString(1),  
                    //Description = reader.GetString(2) ,  
                   // Price = reader.GetDouble(3)      
                };

                services.Add(service);
            }

            DBManager.getInstance().CloseConnection();

            return services;
        }

    }
}
