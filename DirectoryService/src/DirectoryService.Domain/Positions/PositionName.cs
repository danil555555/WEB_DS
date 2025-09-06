using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Positions;

public class PositionName
{
    private PositionName()
    {
    }
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public string NamePosition { get; private set; }

    private PositionName(string namePosition)
    {
        NamePosition = namePosition;
    }

    public static Result<PositionName> Create(string name)
    {
        if (name.Length > MaxLengthName || name.Length < MinLengthName)
        {
            return Result.Failure<PositionName>($"{name} is too long or short.");
        }
        return Result.Success<PositionName>(new PositionName(name));
    }
}