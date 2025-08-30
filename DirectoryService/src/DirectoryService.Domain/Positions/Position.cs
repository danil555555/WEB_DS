using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;

namespace DirectoryService.Domain.Positions;
public class Position
{
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public Guid LocationId { get; private set; }
    public PositionName PositionName { get; private set; }
    public Address Address { get; private set; }
    public Timezone Timezone { get; private set; }
    public bool IsActive { get; set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; set; }
    
    public IReadOnlyList<Department> Departments { get; private set; } = [];

    private Position (PositionName positionName, bool isActive)
    {
        LocationId = Guid.NewGuid();
        PositionName = positionName;
        IsActive = isActive;
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }

    public static Result<Position> Create(PositionName positionName, bool isActive)
    {
        return Result.Success<Position>(new Position(positionName, isActive));
    }
}