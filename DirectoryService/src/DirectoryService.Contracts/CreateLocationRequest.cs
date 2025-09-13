using DirectoryService.Domain.Locations;

namespace DirectoryService.Contracts;
public record CreateLocationRequest(
    string Name,
    string Country, 
    string City, 
    string Street,
    int NumberStreet,
    int Room,
    int PostalCode,
    string Timezone, 
    bool IsActive);