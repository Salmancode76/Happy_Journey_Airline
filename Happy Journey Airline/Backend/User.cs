using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BCrypt.Net;
using System.Text.RegularExpressions;

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
                
                    this.lastName = value;
                
            }
        }

        public int Age {
            get { return age; }
            set
            {
                if (age > 0)
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
            get { return balance; }
            set
            {
                if (balance > 0)
                {
                    this.balance = value;
                }
            }
        }

        public string userRole(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty");
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

                string query = "SELECT * FROM [dbo].[User] WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@username", username1);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHashedPassword = reader["password"].ToString();


                    Console.WriteLine(storedHashedPassword);

                    Console.WriteLine(password);
                    User u1;

                    // Verify the entered password against the stored hashed password
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);
                    if (!isPasswordValid)
                    {
                        return u1=null;


                    }

                    
                     u1 = new User(this.userId, this.firstName, this.lastName, this.age, this.email, this.username = reader["username"].ToString(), this.password = reader["password"].ToString(), role = reader["role"].ToString(), this.phoneNo, this.gender, this.dob, this.balance);
                    Console.WriteLine(u1.role);
                    Console.WriteLine(u1.username);
                    if (u1.role == "Admin")
                    {
                        new adminDashboard().Show();
                    }
                    else if (u1.role == "Employer")
                    {
                        new BookFlight().Show();
                    }
                    else
                    {
                        new BookFlight().Show();  // Assuming Traveler also goes to BookFlight page
                    }

                    return u1;
                }


            }
            catch (SqlException sqlEx)
            {
                throw new Exception("An error occurred while trying to log in. Please try again later. " + sqlEx.Message);
            }
        
            finally
            {
                // Ensure the connection is closed in case of an error
                DBManager.getInstance().CloseConnection();
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

            SqlCommand cmd = new SqlCommand(stmt, DBManager.getInstance().OpenConnection());

            Console.WriteLine("xx"+password);

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // Do not truncate

            Console.WriteLine(hashedPassword);


            cmd.Parameters.AddWithValue("@Name", firstName + " " + lastName);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Dob", dob);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", hashedPassword);
            Console.WriteLine("Executing SQL Command...");

            Console.WriteLine(hashedPassword);

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
                    SqlCommand employerCmd = new SqlCommand(employerStmt, DBManager.getInstance().OpenConnection());

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
                    SqlCommand adminCmd = new SqlCommand(adminstmt, DBManager.getInstance().OpenConnection());

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
                    SqlCommand adminCmd = new SqlCommand(adminstmt, DBManager.getInstance().OpenConnection());

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
            DBManager.getInstance().CloseConnection();
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
        public static User GetUserById(int userId)
        {
            var users = User.GetAllUsers(); 

            foreach (var user in users)
            {
              
           
                if ((long)user.UserId == (long)userId)  
                {
                    return user; 
                }



            }

            return null; // Return null if no user is found
        }



        public static DataTable FillUserGrid()
        {
            List<User> users1 = new List<User>();
            DataTable dt = new DataTable();


            try
            {
                string query = "SELECT * FROM [dbo].[User];";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataAdapter da = new SqlDataAdapter(command);


                da.Fill(dt);

            }
          
            finally
            {
                DBManager.getInstance().CloseConnection();
            }
            return dt;


        }


        public void DeleteUser(int userId, string role)
        {
            if (role == "Traveler")
            {
                // Create the SqlConnection instance (open the connection once)
                SqlConnection conn = DBManager.getInstance().OpenConnection();

                // Start a transaction to ensure both deletes happen together
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Delete from Traveler table
                    string stmt1 = "DELETE FROM [dbo].[Traveler] WHERE user_id = @user_id;";
                    SqlCommand cmd1 = new SqlCommand(stmt1, conn, transaction);
                    cmd1.Parameters.AddWithValue("@user_id", userId);
                    cmd1.ExecuteNonQuery();

                    string stmt2 = "DELETE FROM [dbo].[User] WHERE user_id = @user_id;";
                    SqlCommand cmd2 = new SqlCommand(stmt2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@user_id", userId);
                    cmd2.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // If there's an error, roll back the transaction
                    transaction.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }
            else if (role == "Admin")
            {
                // Create the SqlConnection instance (open the connection once)
                SqlConnection conn = DBManager.getInstance().OpenConnection();

                // Start a transaction to ensure both deletes happen together
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Delete from Traveler table
                    string stmt1 = "DELETE FROM [dbo].[Administrator] WHERE user_id = @user_id;";
                    SqlCommand cmd1 = new SqlCommand(stmt1, conn, transaction);
                    cmd1.Parameters.AddWithValue("@user_id", userId);
                    cmd1.ExecuteNonQuery();

                    string stmt2 = "DELETE FROM [dbo].[User] WHERE user_id = @user_id;";
                    SqlCommand cmd2 = new SqlCommand(stmt2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@user_id", userId);
                    cmd2.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // If there's an error, roll back the transaction
                    transaction.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }
            else if (role == "Employer")
            {
                // Create the SqlConnection instance (open the connection once)
                SqlConnection conn = DBManager.getInstance().OpenConnection();

                // Start a transaction to ensure both deletes happen together
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Delete from Traveler table
                    string stmt1 = "DELETE FROM [dbo].[Employer] WHERE user_id = @user_id;";
                    SqlCommand cmd1 = new SqlCommand(stmt1, conn, transaction);
                    cmd1.Parameters.AddWithValue("@user_id", userId);
                    cmd1.ExecuteNonQuery();

                    string stmt2 = "DELETE FROM [dbo].[User] WHERE user_id = @user_id;";
                    SqlCommand cmd2 = new SqlCommand(stmt2, conn, transaction);
                    cmd2.Parameters.AddWithValue("@user_id", userId);
                    cmd2.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // If there's an error, roll back the transaction
                    transaction.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }
        }

     
           public static List<User> GetAllUsers()
            {
                List<User> users = new List<User>();

                string stmt = "SELECT * FROM [dbo].[User]";
                SqlConnection connection = DBManager.getInstance().OpenConnection();
                SqlCommand cmd = new SqlCommand(stmt, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                string [] name = reader.GetString(1).Split(' ');

                User user = new User
                {
                    UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : 0,
                    FirstName = reader["name"] != DBNull.Value ? reader["name"].ToString().Split(' ')[0] : string.Empty,
                    LastName = reader["name"] != DBNull.Value && reader["name"].ToString().Contains(' ')
                      ? reader["name"].ToString().Split(' ')[1]
                      : string.Empty,
                    Age = reader["age"] != DBNull.Value ? Convert.ToInt32(reader["age"]) : 0,
                    Dob = reader["dob"] != DBNull.Value ? Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd") : string.Empty,
                    Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : string.Empty,
                    Gender = reader["gender"] != DBNull.Value ? reader["gender"].ToString() : string.Empty,
                    Username = reader["username"] != DBNull.Value ? reader["username"].ToString() : string.Empty,

                    PhoneNo = reader["phone_no"] != DBNull.Value ? reader["phone_no"].ToString() : string.Empty,
                    Role = reader["role"] != DBNull.Value ? reader["role"].ToString() : string.Empty
                };


                users.Add(user);
                }

                connection.Close();

                return users;
            }


        public static List<User> GetAvailableUsers()
        {
            List<User> users1 = new List<User>();

            try
            {
                string query = "SELECT * FROM User";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

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
                DBManager.getInstance().CloseConnection();
            }
            return users1;
        }

        public bool UpdateUser(int userId, string firstName, string lastName, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob)
        {
            String name = firstName + " " + lastName;

            string stmt = "UPDATE [dbo].[User] SET [name] = @name, [age] = @age, [dob] = @dob, [email] = @email, [gender] = @gender, [username] = @username, [password] = @password, [phone_no] = @phoneNo, [role] = @role WHERE [user_id] = @userId";
            try
            {

                SqlCommand cmd = new SqlCommand(stmt, DBManager.getInstance().OpenConnection());


                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dob", DateTime.Parse(dob)); // Assuming dob is a string in yyyy-MM-dd format
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);  // Assuming you store the password as plain text (consider hashing)
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@userId", userId); // Ensure the parameter name is @userId, as in the query

                cmd.ExecuteNonQuery();
                DBManager.getInstance().CloseConnection();
                return true;
            }
            catch (Exception ex)
            {   
                return false;
            }

        }


    }
   

}


