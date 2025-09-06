using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;

namespace DirectoryService.Domain.Positions;
public class Position
{
    private Position()
    {
    }
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public Guid PositionId { get; private set; }
    public PositionName PositionName { get; private set; }
    public Address Address { get; private set; }
    public Timezone Timezone { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; private set; }
    
    public List<DepartmentPosition> DepartmentPosition { get; private set; } = new List<DepartmentPosition>();

    private Position (PositionName positionName, bool isActive, Address address, Timezone timezone)
    {
        PositionId = Guid.NewGuid();
        PositionName = positionName;
        IsActive = isActive;
        Address = address;
        Timezone = timezone;
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }
    
    public static Result<Position> Create(PositionName positionName, bool isActive,  Address address, Timezone timezone)
    {
        return Result.Success<Position>(new Position(positionName, isActive, address, timezone));
    }
}