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
 

        builder.OwnsOne(d => d.PositionName, dn =>
        {
            dn.Property(n => n.NamePosition)
                .HasColumnName("name_position")
                .IsRequired();
        });
        
        


    }
}