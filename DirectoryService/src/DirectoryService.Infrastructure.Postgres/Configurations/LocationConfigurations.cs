using DirectoryService.Domain.Locations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class LocationConfigurations : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("location");
        builder.HasKey(l => l.LocationId).HasName("location_id");
        builder.OwnsOne(l => l.LocationName, ln =>
        {
            ln.Property(n => n.NameLocation)
                .HasColumnName("name")
                .IsRequired();
        });
    }
}