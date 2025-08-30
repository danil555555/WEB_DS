using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Departments;

public record Path
{
    public string Name { get; private set; }

    private Path(string name)
    {
        Name = name;
    }
    
    public static Result<Path> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Failure<Path>("DepartmentName cannot be null or whitespace.");
        }
        return Result.Success<Path>(new Path(name));
    }
}