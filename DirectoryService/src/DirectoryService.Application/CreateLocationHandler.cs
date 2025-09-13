using CSharpFunctionalExtensions;
using DirectoryService.Application.Database;
using DirectoryService.Contracts;
using DirectoryService.Domain.Locations;
using Microsoft.AspNetCore.Mvc;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

namespace DirectoryService.Application;

public class CreateLocationHandler
{
    private readonly IReservationServiceDbContext _dbContext;

    public CreateLocationHandler(IReservationServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Result<Guid>> Handle(CreateLocationRequest request, CancellationToken cancellationToken)
    {
        var location = Location.Create(request.Name, 
            request.Country, 
            request.City, 
            request.Street, 
            request.NumberStreet,
            request.Room,
            request.PostalCode,
            request.Timezone,
            request.IsActive);
        await _dbContext.Locations.AddAsync(location.Value, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return location.Value.LocationId;
    }
}
