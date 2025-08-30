using CSharpFunctionalExtensions;

namespace DirectoryService.Domain.Positions;

public class Address
{
    private const int MaxLengthName = 150;
    private const int MinLengthName = 3;
    
    public string Country { get; private set; }
    public string City { get; private set; }
    public string Street { get; private set; }
    public int NumberStreet { get; private set; }
    public int Room {get; private set; }
    public int PostalCode { get; private set; }

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