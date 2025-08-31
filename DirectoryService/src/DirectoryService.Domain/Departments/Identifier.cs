using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Departments;

public class Identifier
{
    private const int MaxLengthValue = 150;
    private const int MinLengthValu = 3;
    public const string pattern = "[A - Za - z]";
    public string Value { get; set; }
    private Identifier(string value)
    {
        Value = value;
    }

    public static Result<Identifier> Create(string value)
    {
        if (value.Length < MinLengthValu || value.Length > MaxLengthValue)
        {
            return Result.Failure<Identifier>($"{value} is too long or short.");
        }
        bool isMatch = Regex.IsMatch(value, pattern);
        if (!isMatch)
        {
            return Result.Failure<Identifier>($"{value} is not a valid identifier.");
        }
        return Result.Success<Identifier>(new Identifier(value));
    }
}