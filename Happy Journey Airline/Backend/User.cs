using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Happy_Journey_Airline
{
    public class User
    {
        protected int userId;
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string email;
        protected string username;
        protected string password;
        protected string role;
        protected string phoneNo;
        protected string gender;
        protected string dob;
        protected double balance;
        protected static List<User> users = new List<User>();

        public User()
        {
        }

        public User(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            this.username = username;
            this.password = password;
            this.role = role;
            this.phoneNo = phoneNo;
            this.gender = gender;
            this.dob = dob;
            this.balance = balance;
        }

        public int UserId { get; set; }

        public string FirstName { 
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName.Length >= 3)
                {
                    this.lastName = value;
                }
            }
        }

        public int Age { 
            get { return age; }
            set 
            {
                if ( age > 0 )
                {
                    this.age = value;
                }
            }
        }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNo { get; set; }

        public string Role { get; set; }

        public double Balance { 
            get { return  balance; }
            set 
            {
                if ( balance > 0 )
                {
                    this.balance = value;
                }
            }
        }

        public string userRole(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be emoty");
            }

            if (username.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                return this.role = "Admin"; 
            }
            else if (username.StartsWith("e", StringComparison.OrdinalIgnoreCase))
            {
                return this.role = "Employer";
            }
            else
            {
                return this.role = "Traveler";
            }
        }

        public User login(string username1, string password)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[User] WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                cmd.Parameters.AddWithValue("@username", username1);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User u1 = new User(this.userId, this.firstName, this.lastName, this.age, this.email, this.username = reader["username"].ToString(), this.password = reader["password"].ToString(), role = userRole(username1), this.phoneNo, this.gender, this.dob, this.balance);
               
                    if (u1.role == "Admin")
                    {
                        new adminDashboard().Show();
                    } else if (u1.role == "Employer")
                    {
                        new BookFlight().Show();

                    }
                    else
                    {
                        new BookFlight().Show();


                    }

                    return u1;
                }
           
              
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("An error occurred while trying to log in. Please try again later. " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred. Please try again later. " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed in case of an error
                DBManager.getInstance("").CloseConnection();
            }
            return null;
        }


        public static List<User> getUsers()
        {
            List<User> usersList = new List<User>();

            foreach (User user in users)
            {
                usersList.Add(user);
            }
            return usersList;
        }
        public void Register(string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob)
        {
            string stmt = "INSERT INTO [dbo].[User] (name, age, dob, email, gender, username, password, phone_no, role) " +
                          "VALUES (@Name, @Age, @Dob, @Email, @Gender, @Username, @Password, @PhoneNo, @Role); " +
                          "SELECT SCOPE_IDENTITY();"; // Return the inserted ID

            SqlCommand cmd = new SqlCommand(stmt, DBManager.getInstance("").OpenConnection());

            cmd.Parameters.AddWithValue("@Name", firstName + " " + lastName);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Dob", dob);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
            cmd.Parameters.AddWithValue("@Role", role);

            object insertedId = cmd.ExecuteScalar(); // Get the inserted ID

            if (insertedId != null)
            {
                Console.WriteLine("Inserted User ID: " + insertedId.ToString());
            }

            int userId = Convert.ToInt32(insertedId); // Convert to the appropriate type

            if (role == "Employer")
            {
                try
                {
                    Console.WriteLine("Inserting into Employer table...");

                    // Prepare SQL statement to insert into Employer table
                    string employerStmt = "INSERT INTO [dbo].[Employer] ([user_id]) VALUES (@UserID)";
                    SqlCommand employerCmd = new SqlCommand(employerStmt, DBManager.getInstance("").OpenConnection());

                    // Add the parameter for the user_id
                    employerCmd.Parameters.AddWithValue("@UserID", userId);

                    // Execute the SQL query to insert into Employer table
                    employerCmd.ExecuteNonQuery();

                    Console.WriteLine("Inserted Employer for User ID: " + userId);
                }
                catch (Exception ex)
                {
                    // Log or show the error for debugging
                    Console.WriteLine("Error inserting into Employer table: " + ex.Message);
                }
            } else if (role == "Admin")
            {
                try
                {
                    Console.WriteLine("Inserting into Admin table...");

                    // Prepare SQL statement to insert into Employer table
                    string adminstmt = "INSERT INTO [dbo].[Administrator] ([user_id]) VALUES (@UserID)";
                    SqlCommand adminCmd = new SqlCommand(adminstmt, DBManager.getInstance("").OpenConnection());

                    // Add the parameter for the user_id
                    adminCmd.Parameters.AddWithValue("@UserID", userId);

                    // Execute the SQL query to insert into Employer table
                    adminCmd.ExecuteNonQuery();

                    Console.WriteLine("Inserted admin for User ID: " + userId);
                }
                catch (Exception ex)
                {
                    // Log or show the error for debugging
                    Console.WriteLine("Error inserting into Employer table: " + ex.Message);
                }

            }
            else
            {
                try
                {
                    Console.WriteLine("Inserting into traveller table...");

                    // Prepare SQL statement to insert into Employer table
                    string adminstmt = "INSERT INTO [dbo].[Traveler] ([user_id]) VALUES (@UserID)";
                    SqlCommand adminCmd = new SqlCommand(adminstmt, DBManager.getInstance("").OpenConnection());

                    // Add the parameter for the user_id
                    adminCmd.Parameters.AddWithValue("@UserID", userId);

                    // Execute the SQL query to insert into Employer table
                    adminCmd.ExecuteNonQuery();

                    Console.WriteLine("Inserted traveller for User ID: " + userId);
                }
                catch (Exception ex)
                {
                    // Log or show the error for debugging
                    Console.WriteLine("Error inserting into Employer table: " + ex.Message);
                }
            }

            // Close the connection
            DBManager.getInstance("").CloseConnection();
        }

        public static bool Exists(string username)
        {
            List<User> users = getUsers();

            foreach (User user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
           return false;
        }

        public static User getUserById(int userId)
        {
            List<User> u1 = User.GetAvailableUsers();

            foreach (User user1 in u1)
            {
                if (user1.userId == userId)
                {
                    return user1;
                }
            }
            return null;
        }

        public static List<User> GetAvailableUsers()
        {
            List<User> users1 = new List<User>();

            try
            {
                string query = "SELECT * FROM User";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance("").OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User { userId = reader.GetInt32(0), firstName = reader.GetString(1), lastName = reader.GetString(2) };
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
            return users1;
        }

      
    }


}
