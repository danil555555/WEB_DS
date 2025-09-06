using DirectoryService.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentLocationConfigurations : IEntityTypeConfiguration<DepartmentLocation>
{
    public void Configure(EntityTypeBuilder<DepartmentLocation> builder)
    {
        builder.ToTable("department_locations");

        builder.HasKey(dl => new { dl.DepartmentId, dl.LocationId })
            .HasName("pk_department_locations");

        builder.Property(dl => dl.DepartmentId)
            .HasColumnName("department_id")
            .IsRequired();

        builder.Property(dl => dl.LocationId)
            .HasColumnName("location_id")
            .IsRequired();
        /*builder.HasOne(dl => dl.Department)
            .WithMany(l=>l.DepartmentLocations)
            .HasForeignKey("department_id")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(dl => dl.Location)
            .WithMany()
            .HasForeignKey("location_id")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);*/
    }
}