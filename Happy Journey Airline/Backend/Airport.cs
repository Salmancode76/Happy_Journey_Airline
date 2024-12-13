using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Airport
    {
        private int airportId;
        private string airportCode;
        private string airportName;

        public Airport()
        {
        }

        public Airport(string airportCode, string airportName)
        {
            this.airportId = airportId;
            this.airportCode = airportCode;
            this.airportName = airportName;
        }

        public string AirportCode { get; set; }

        public string AirportName { get; set; }

     

    }
}
