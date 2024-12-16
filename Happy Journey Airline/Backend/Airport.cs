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
        private int cityID;
        private string airportName;

        public Airport()
        {
        }
        public Airport( string airportName, int cityID)
        {
            this.airportName = airportName;
            this.cityID = cityID;
        }
        public Airport(int airportId, string airportName,int cityID)
        {
            this.airportId = airportId;
            this.airportName = airportName;
            this.cityID = cityID;
        }

        public string AirportCode { get; set; }

        public string AirportName { get; set; }
        public int CityID { get => cityID; set => cityID = value; }
    }
}
