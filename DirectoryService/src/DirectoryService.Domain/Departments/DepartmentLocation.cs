using CSharpFunctionalExtensions;
using DirectoryService.Domain.Locations;

namespace DirectoryService.Domain.Departments;

public class DepartmentLocation
{
    private DepartmentLocation()
    {
    }
    public Guid DepartmentId { get; private set; }

    public Guid LocationId { get; private set; }
    public Department Department { get; set; }
    public Location Location { get; set; }
    public DepartmentLocation(Guid departmentId, Guid locationId)
    {
        DepartmentId = departmentId;
        LocationId = locationId;
    }
}