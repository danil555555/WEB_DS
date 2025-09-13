using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Locations;
public class Timezone
{
    private Timezone()
    {
    }
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public string IanaCode { get; private set; }

    private Timezone(string ianaCode)
    {
        IanaCode = ianaCode;
    }
    
    public static Result<Timezone> Create(string ianaCode)
    {
        if (ianaCode.Length > MaxLengthName || ianaCode.Length < MinLengthName)
        {
            return Result.Failure<Timezone>($"{ianaCode} is too long or short.");
        }
        return Result.Success<Timezone>(new Timezone(ianaCode));
    }
    
}