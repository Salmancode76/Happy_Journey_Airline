using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Happy_Journey_Airline
{
    public class FlightClass
    {
        private int flightClassId;
        private string flightClassName;
        private int seatCount;

        public FlightClass()
        {
        }

        public FlightClass(int flightClassId, string flightClassName, int seatCount)
        {
            this.flightClassId = flightClassId;
            this.flightClassName = flightClassName;
            this.seatCount = seatCount;
        }

        public int FlightClassId { get; set; }

        public string FlightClassName { get; set; }

        public int SeatCount { get; set; }

        public void selectFlightClass(string flightClass)
        {
            if (flightClass == null)
            {
                throw new ArgumentException("flight class cannot be empty");
            }

            if (flightClass.Equals("Business", StringComparison.OrdinalIgnoreCase))
            {
                this.flightClassName = "Business";
            }
            else if (flightClass.Equals("Economy", StringComparison.OrdinalIgnoreCase))
            {
                this.flightClassName = "Economy";
            }
            else if (flightClass.Equals("First Class", StringComparison.OrdinalIgnoreCase))
            {
                this.flightClassName = "First Class";
            }
        }

        public static List<FlightClass> getAvailableFlighClass()
        {
            List<FlightClass> flights = new List<FlightClass>();

            try
            {
                string query = "SELECT flight_class_id, flight_class_name FROM FlightClass";

                SqlCommand command = new SqlCommand(query, DBManager.getInstance().OpenConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FlightClass flight = new FlightClass { flightClassId = reader.GetInt32(0), flightClassName = reader.GetString(1) };

                    flights.Add(flight);
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

        public static FlightClass getFlightClassById(int flightClassId)
        {
            List<FlightClass> flights = FlightClass.getAvailableFlighClass();

            foreach (FlightClass flight in flights)
            {
                if (flight.flightClassId == flightClassId)
                {
                    return flight;
                }
            }
            return null;
        }
    }
}
