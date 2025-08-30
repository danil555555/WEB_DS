using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Locations;

public class LocationName
{
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public string NameLocation { get; set; }

    private LocationName(string nameLocation)
    {
        NameLocation = nameLocation;
    }

    public static Result<LocationName>  Create(string name)
    {
        if (name.Length > MaxLengthName || name.Length < MinLengthName)
        {
            return Result.Failure<LocationName>($"{name} is too long or short.");
        }
        return Result.Success<LocationName>(new LocationName(name));
    }
}