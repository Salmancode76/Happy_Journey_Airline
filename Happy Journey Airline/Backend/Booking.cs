using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private int seatNo;
        private List<Service> services;
        private string status; // cancelled, booked
        private int subscriptionId;
        private int travelerId;

        public Booking()
        {
        }

        public Booking(string destination, string duration, int flightClassId, int flightId, int flightNo, int paymentId, int seatNo, List<Service> services, string status, int subscriptionId, int travelerId)
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

        public int SeatNo { 
            get {  return seatNo; }
            set
            {
                if (seatNo > 0)
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

                if (seatNo == 0)
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

    }
}
