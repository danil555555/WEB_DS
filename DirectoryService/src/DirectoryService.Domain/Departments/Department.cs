using CSharpFunctionalExtensions;
using DirectoryService.Departments;
using DirectoryService.Domain.Locations;
using DirectoryService.Domain.Positions;

namespace DirectoryService.Domain.Departments;

public class Department
{
    public Guid DepartmentId { get; private set; }
    public DepartmentName DepartmentName { get; private set; }
    public Identifier Identifier { get; set; }
    public Guid? ParentId {get; private set;}
    public Path Path { get; set; }
    public short Depth { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; set; }

    public IReadOnlyList<Position> Positions { get; private set; } = [];
    public IReadOnlyList<Location> Locations { get; private set; } = [];
    
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
    public static Result<Department> Create(DepartmentName departmentName, Identifier identifier,
        Guid? parentId, Path path, short depth, bool isActive)
    {
        return Result.Success<Department>(new Department(departmentName, identifier, parentId, path, depth, isActive));
    }
}