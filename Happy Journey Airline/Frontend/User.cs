using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class User
    {
        protected int userId;
        protected string name;
        protected int age;
        protected string email;
        protected string username;
        protected string password;
        protected string role;
        protected string phoneNo;
        protected string gender;
        protected string dob;
        protected double balance;

        public User()
        {
        }

        public User(int userId, string name, int age, string email, string username, string password, string role, string phoneNo, string gender, string dob, double balance)
        {
            this.userId = userId;
            this.name = name;
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

        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNo { get; set; }

        public string Role { get; set; }

        public double Balance { get; set; }

        public void login()
        {

        }
    }
}
