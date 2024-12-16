using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Happy_Journey_Airline
{
    public class Booking
    {
        private int bookingId;
        private string destination;
        private string duration;
        private int flightClassId;
        private int flightId;
        private int flightNo;
        private int paymentId;
        private string seatNo;
        private List<Service> services;
        private string status; // cancelled, booked
        private int subscriptionId;
        private int travelerId;

        public Booking()
        {
        }

        public Booking(string destination, string duration, int flightClassId, int flightId, int flightNo, int paymentId, string seatNo, List<Service> services, string status, int subscriptionId, int travelerId)
        {
            this.bookingId = bookingId++;
            this.destination = destination;
            this.duration = duration;
            this.flightClassId = flightClassId;
            this.flightId = flightId;
            this.flightNo = flightNo;
            this.paymentId = paymentId;
            this.seatNo = seatNo;
            this.services = services;
            this.status = status; 
            this.subscriptionId = subscriptionId;
            this.travelerId = travelerId;
        }

        public string Destination { get; set; }

        public string Duration { get; set; }

        public FlightClass FlightClass { get; set; }

        public Flight Flight { get; set; }

        public Payment Payment { get; set; }

        public Subscription Subscription { get; set; }

        public TravelerObserver Traveler { get; set; }

        public string SeatNo { 
            get {  return seatNo; }
            set
            {
                if (seatNo !=" ")
                {
                    this.seatNo = seatNo;
                }
            }
        }

        public string Status { 
            get { return status; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Status cannot be null or empty.");
                }

                if (value.Equals("booked", StringComparison.OrdinalIgnoreCase) || value.Equals("cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    this.status = value;
                }
                else
                {
                    throw new ArgumentException("Status must be either 'booked' or 'cancelled'.");
                }
            }
        }

        public Booking book()
        {
            string message;
            Booking bookings;
            try
            { 
                if (this.flightNo == 0)
                {
                    message = "Please select a flight before booking.";
                    return null;
                }

                FlightClass flightClass = FlightClass.getFlightClassById(this.flightClassId);
                if (flightClass == null)
                {
                    message = "Invalid flight class selected";
                    return null;
                }

                if (seatNo !=" " )
                {
                    message = "Select a seat number, it cannot be empty";
                    return null;
                }
                
                bookings = new Booking(this.destination, this.duration, this.flightClassId, this.flightId, this.flightNo, this.paymentId, this.seatNo, this.services, this.status, this.subscriptionId, this.travelerId);
                Flight f = Flight.getFlightId(this.flightId);
                if (f != null) 
                {
                    f.Status = "Booked";
                }
                else
                {
                    MessageBox.Show("Flight not found");
                }
                return bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while booking: " + ex.Message);
                return null;
            }
        }

        public void TravelerBook(string flightno, string destination, string departure, string seatno, string totalTraveler, string status, string depDate, string retDate, string flightClass ) {



             int flightId;
            string selectFlight = "SELECT flight_id FROM [dbo].[Flight] WHERE destination = @Destination AND departure = @Departure AND flight_no =@flightno ";
            // select query to get flight id by passing destination and departure

            SqlCommand cmd = new SqlCommand(selectFlight, DBManager.getInstance().OpenConnection());




            cmd.Parameters.AddWithValue("@Destination", destination);
            cmd.Parameters.AddWithValue("Departure", departure);
            cmd.Parameters.AddWithValue("@Flightno", flightno);


            object result = cmd.ExecuteScalar();
            flightId = result != null ? Convert.ToInt32(result) : -1;


            //fetching flight class id

            int flightClassId;
            string selectClassQuery = "SELECT flight_class_id FROM [dbo].[FlightClass] WHERE flight_class_name = @FlightClassName";

            SqlCommand cmd2 = new SqlCommand(selectClassQuery, DBManager.getInstance().OpenConnection());

            cmd2.Parameters.AddWithValue("@Flight_Class_Name", flightClass);

            object classResult = cmd2.ExecuteScalar();
            flightClassId = classResult != null ? Convert.ToInt32(classResult) : -1;


            if (flightId != -1 && flightClassId != -1)
            {




                string stmtInsert = "INSERT INTO [dbo].[Booking] (flight_class_id, flight_id, seatno, status) " +
                           "VALUES (@Flight_class_id, @flight_id, @seat_no, @status); " +
                         "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd3 = new SqlCommand(stmtInsert, DBManager.getInstance().OpenConnection());

                cmd3.Parameters.AddWithValue("@flight_class_id", flightClassId);
                cmd3.Parameters.AddWithValue("@flight_id", flightId);
                cmd3.Parameters.AddWithValue("@seatno", seatno);
                cmd3.Parameters.AddWithValue("@status", status);

                object bookId = cmd3.ExecuteScalar();

                if (bookId != null)
                {
                    Console.WriteLine("Inserted Booking ID: " + bookId.ToString());
                }

            }

        }

    }
}
