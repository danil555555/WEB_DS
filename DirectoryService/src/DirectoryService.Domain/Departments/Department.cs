using CSharpFunctionalExtensions;
using DirectoryService.Domain.Locations;
using DirectoryService.Domain.Positions;

namespace DirectoryService.Domain.Departments;

public class Department
{
    private Department()
    {
        
    }
    public Guid DepartmentId { get; private set; }
    public DepartmentName DepartmentName { get; private set; }
    public Identifier Identifier { get; private set; }
    public Guid? ParentId {get; private set;}
    public Path Path { get; private set; }
    public short Depth { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; private set; }

    public List<DepartmentPosition> DepartmentPositions { get; private set; } = []; 
    public List<DepartmentLocation> DepartmentLocations { get; private set; } = [];

    private Department( DepartmentName departmentName, Identifier identifier,
        Guid? parentId, Path path,short depth, bool isActive)
    {
        DepartmentId = Guid.NewGuid();
        DepartmentName = departmentName;
        Identifier = identifier;
        ParentId = parentId;
        Path = path;
        Depth = depth;
        IsActive = isActive;
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }
}