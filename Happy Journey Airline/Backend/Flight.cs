using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public class Flight
    {
        private int flightId;
        private string flightNo;
        private int capacity;
        private string status; // available, booked
        private int departure;
        private int destination;
        private DateTime departureTime;
        private DateTime arrivalTime;
        private DateTime departureDate;
        private DateTime arrivalDate;
        private decimal price;

        public Flight()
        {
        }

        public Flight(string flightNo, int capacity, string status, int departure, int destination, DateTime departureTime, DateTime arrivalTime, DateTime departureDate, DateTime arrivalDate, decimal price)
        {
            this.flightId = flightId;
            this.flightNo = flightNo;
            this.capacity = capacity;
            this.status = status;
            this.departure = departure;
            this.destination = destination;
            this.departureTime = departureTime; 
            this.arrivalTime = arrivalTime;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.price = price;
        }

        public int FlightId { get; set; }

        public string FlightNo { 
            get {  return flightNo; }
            set
            {
                if (flightNo.Length == 0)
                {
                    this.flightNo = value;
                }
            }
        }

        public int Capacity { get; set; }

        /*
        public string Status { 
            get {  return Status1; }
            set
            {
                if (value.Equals("available", StringComparison.OrdinalIgnoreCase) || value.Equals("booked", StringComparison.OrdinalIgnoreCase))
                {
                    this.Status1 = value;
                }
                else
                {
                    throw new ArgumentException("Status must be either 'booked' or 'available'.");
                }
            }
        }
        */
        public int Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        public string Status { get { return status; } set { status = value; } }

        public int Destination { get { return destination; } set { destination = value; } }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public decimal Price { 
            get { return price; }
            set 
            {
                if (price > 0)
                {
                    this.price = value;
                }
            }
        }


        public static Flight getFlightId(int flightId)
        {
            List<Flight> flight = Flight.GetAvailableFlights();

            foreach (Flight f in flight)
            {
                if (f.flightId == flightId)
                {
                    return f;
                }
            }
            return null;
        }

        public static List<Flight> GetAvailableFlights()
        {
            List<Flight> flights = new List<Flight>();

            try
            {
                string query = "SELECT flight_id, flight_no, status FROM Flight";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Flight flight = new Flight { flightId = reader.GetInt32(0), status = reader.GetString(1) };
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
            return flights;
        }

    }
}
