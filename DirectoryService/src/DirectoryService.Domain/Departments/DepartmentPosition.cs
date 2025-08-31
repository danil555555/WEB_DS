using DirectoryService.Domain.Positions;

namespace DirectoryService.Domain.Departments;

public class DepartmentPosition
{
    public Guid DepartmentId { get; private set; }
    public Department Department { get; private set; }
    public Guid PositionId { get; private set; }
    public Position Position { get; private set; }

    public DepartmentPosition(Guid departmentId, Guid positionId, Department department, Position position)
    {
        DepartmentId = departmentId;
        PositionId = positionId;
        Department = department;
        Position = position;
    }
}