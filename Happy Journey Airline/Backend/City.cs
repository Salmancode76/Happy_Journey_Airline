using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class City
    {
        private int cityId;
        private string cityName;

        public City()
        {
        }

        public City(string cityName)
        {
            this.cityId = cityId++;
            this.cityName = cityName;
        }

        public string CityName { get; set; }
    }
}
