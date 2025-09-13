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
        
        builder.OwnsOne(d => d.Address, dn =>
        {
            dn.Property(n => n.City)
                .HasColumnName("city")
                .IsRequired();
            dn.Property(n => n.Street)
                .HasColumnName("street")
                .IsRequired();
            dn.Property(n => n.Country)
                .HasColumnName("country")
                .IsRequired();
            dn.Property(n => n.NumberStreet)
                .HasColumnName("number_street")
                .IsRequired();
            dn.Property(n => n.Room)
                .HasColumnName("room")
                .IsRequired();
            dn.Property(n => n.PostalCode)
                .HasColumnName("postal_code")
                .IsRequired();
        });
        
        builder.OwnsOne(d => d.Timezone, dn =>
        {
            dn.Property(n=>n.IanaCode)
                .HasColumnName("iana_code")
                .IsRequired();
        });
        
        builder.Property(l => l.UpdateAt)
            .HasConversion(l => l.ToUniversalTime(),
                l => DateTime.SpecifyKind(l , DateTimeKind.Utc));
        builder.Property(l => l.CreateAt).HasConversion(l => l.ToUniversalTime(),
            l => DateTime.SpecifyKind(l , DateTimeKind.Utc));
    }
}