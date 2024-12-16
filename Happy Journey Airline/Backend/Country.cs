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

        public Country( int countryID,string countryName, string region)
        {
            this.countryId = countryID;
            this.countryName = countryName;
            this.region = region;
        }
        public Country( string countryName, string region)
        {
            this.countryName = countryName;
            this.region = region;
        }


        public int CountryId { get => this.countryId; set => this.countryId = value; }
        public string CountryName { get; set; }

        public string Region { get; set; }

    }
}
