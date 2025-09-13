using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;

namespace DirectoryService.Domain.Locations;
public class Location
{
    private Location()
    {
    }
    public Guid LocationId { get; private set; }
    public LocationName LocationName { get; private set; }
    
    public Address Address { get; private set; }
    
    public Timezone Timezone { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; private set; }
    public List<DepartmentLocation> DepartmentLocation { get; private set; } = []; 

    private Location(LocationName locationName, Address address, Timezone timezone,  bool isActive)
    {
        LocationId = Guid.NewGuid();
        LocationName = locationName;
        Address = address;
        Timezone = timezone;
        IsActive = isActive;
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }

    public static Result<Location> Create(string locationName, 
        string country, 
        string city, 
        string street, 
        int numberStreet, 
        int room, 
        int postalCode, 
        string timezone, 
        bool isActive)
    {
        var locationNameResult = LocationName.Create(locationName);
        var addressResult = Address.Create(country, city, street, numberStreet, room, postalCode);
        var  timezoneResult = Timezone.Create(timezone);
        return Result.Success<Location>(new Location(locationNameResult.Value, addressResult.Value, timezoneResult.Value, isActive));
    }
}