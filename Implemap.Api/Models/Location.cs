namespace Implemap.Client.Models;

public class Location
{
    public Location(int id, double latitude, double longitude, string name)
    {
        Id = id;
        Latitude = latitude;
        Longitude = longitude;
        Name = name;
    }

    public int Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Name { get; set; }
}