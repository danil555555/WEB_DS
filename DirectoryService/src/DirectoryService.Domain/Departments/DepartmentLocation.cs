using CSharpFunctionalExtensions;
using DirectoryService.Domain.Locations;

namespace DirectoryService.Domain.Departments;

public class DepartmentLocation
{
    public Guid DepartmentId { get; private set; }
    public Department  Department { get; private set; }
    public Guid LocationId { get; private set; }
    public Location  Location { get; private set; }
    public DepartmentLocation(Guid departmentId, Guid locationId, Department department, Location location)
    {
        DepartmentId = departmentId;
        LocationId = locationId;
        Department = department;
        Location = location;
    }
}