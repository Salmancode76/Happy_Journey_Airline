using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Happy_Journey_Airline
{
    public class City
    {
        private int cityId;
        private int countryID;
        private string cityName;

        // Constructor should accept countryID and cityName
        public City(int countryID, string cityName)
        {
            CountryID = countryID; // Initialize CountryID
            CityName = cityName;   // Initialize CityName
        }

        public City(int cityId, int countryID, string cityName)
        {
            this.cityId = cityId;
            this.countryID = countryID;
            this.cityName = cityName;
        }




        // Properties
        public int CityId { get => cityId; set => cityId = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public int CountryID { get => countryID; set => countryID = value; }


       
    }
}
