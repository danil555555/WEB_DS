using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Positions;

public class Address
{
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int NumberStreet { get; set; }
    public int Room {get; set; }
    public int PostalCode { get; set; }

    private Address(string country, string city, string street, int numberStreet, int room, int postalCode)
    {
        Country = country;
        City = city;
        Street = street;
        NumberStreet = numberStreet;
        Room = room;
        PostalCode = postalCode;
    }

    public static Result<Address> Create(string country, string city, string street, int numberStreet, int room, int postalCode)
    {
        if (string.IsNullOrEmpty(country))
        {
            return Result.Failure<Address>("Country cannot be empty");
        }
        return Result.Success<Address>(new Address(country, city, street, numberStreet, room, postalCode));
    }
}