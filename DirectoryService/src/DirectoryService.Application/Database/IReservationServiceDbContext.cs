using DirectoryService.Domain.Locations;
using Microsoft.EntityFrameworkCore;

namespace DirectoryService.Application.Database;

public interface IReservationServiceDbContext
{
    DbSet<Location> Locations { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}