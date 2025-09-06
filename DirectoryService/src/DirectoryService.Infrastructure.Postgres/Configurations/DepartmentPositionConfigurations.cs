using DirectoryService.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentPositionConfigurations : IEntityTypeConfiguration<DepartmentPosition>
{
    public void Configure(EntityTypeBuilder<DepartmentPosition> builder)
    {
        builder.ToTable("department_positions");

        builder.HasKey(dp => new { dp.DepartmentId, dp.PositionId })
            .HasName("pk_department_positions");

        builder.Property(dp => dp.DepartmentId)
            .HasColumnName("department_id")
            .IsRequired();

        builder.Property(dp => dp.PositionId)
            .HasColumnName("position_id")
            .IsRequired();
    }
}