using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Departments;

public record DepartmentName
{
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    public string NameDepartment { get; private set; }
    
    private DepartmentName(string nameDepartment)
    {
        NameDepartment = nameDepartment;
    }

    public static Result<DepartmentName> Create(string nameDepartment)
    {
        if (nameDepartment.Length > MaxLengthName || nameDepartment.Length < MinLengthName)
        {
            return Result.Failure<DepartmentName>($"{nameDepartment} is too long or short.");
        }
        
        return Result.Success<DepartmentName>(new DepartmentName(nameDepartment));
    }
}