using DirectoryService.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class PositionConfigurations : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.ToTable("position");
        builder.HasKey(l => l.PositionId).HasName("position_id");
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
        builder.OwnsOne(d => d.PositionName, dn =>
        {
            dn.Property(n => n.NamePosition)
                .HasColumnName("name_position")
                .IsRequired();
        });
        builder.OwnsOne(d => d.Timezone, dn =>
        {
            dn.Property(n=>n.IanaCode)
                .HasColumnName("iana_code")
                .IsRequired();
        });


    }
}