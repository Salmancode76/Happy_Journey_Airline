public class Airport
{
    public int AirportId { get; set; } 
    public int CityID { get; set; }   
    public string AirportName { get; set; }

    public string DisplayName { get; set; } // Display name will contain both airport and city names

    public Airport() { }

    public Airport(string airportName, int cityID)
    {
        this.AirportName = airportName;
        this.CityID = cityID;
    }
    public Airport(int airportId, string airportName, string cityName)
    {
        AirportId = airportId;
        DisplayName = $"{airportName} ({cityName})"; 
    }

    public Airport(int airportId, string airportName, int cityID)
    {
        this.AirportId = airportId;
        this.AirportName = airportName;
        this.CityID = cityID;
    }

 
}
