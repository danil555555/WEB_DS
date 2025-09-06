using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Locations;


namespace DirectoryService.Domain.Departments;


public class DepartmentPosition
{
    private DepartmentPosition()
    {
    }
    public Guid DepartmentId { get; private set; }
    public Guid PositionId { get; private set; }
    public Department Department { get; set; }
    public Position Position { get; set; }

    public DepartmentPosition(Guid departmentId, Guid positionId)
    {
        DepartmentId = departmentId;
        PositionId = positionId;

    }
}