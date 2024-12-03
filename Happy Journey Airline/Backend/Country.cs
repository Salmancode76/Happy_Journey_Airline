using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Country
    {
        private int countryId;
        private string countryName;
        private string region;

        public Country()
        {
        }

        public Country(string countryName, string region)
        {
            this.countryId = countryId++;
            this.countryName = countryName;
            this.region = region;
        }

        public string CountryName { get; set; }

        public string Region { get; set; }

    }
}
