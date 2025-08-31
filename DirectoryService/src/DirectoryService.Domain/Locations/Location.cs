using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;

namespace DirectoryService.Domain.Locations;
public class Location
{
    public Guid LocationId { get; private set; }
    public LocationName LocationName { get; private set; }
    public string? Description { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; private set; }
    public List<DepartmentLocation> DepartmentLocation { get; private set; } = new List<DepartmentLocation>(); 

    private Location(LocationName locationName, string? description,  bool isActive)
    {
        LocationId = Guid.NewGuid();
        LocationName = locationName;
        IsActive = isActive;
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }

    public static Result<Location> Create(LocationName locationName, string? description, bool isActive)
    {
        return Result.Success<Location>(new Location(locationName, description, isActive));
    }
}