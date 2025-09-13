using DirectoryService.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("department");
        builder.HasKey(d => d.DepartmentId).HasName("department_id");
        builder.ComplexProperty(d => d.DepartmentName, dn =>
        {
            dn.Property(n => n.NameDepartment)
                .HasColumnName("name")
                .IsRequired();
        });
        builder.OwnsOne(d => d.Identifier, dn =>
        {
            dn.Property(n => n.Value)
                .HasColumnName("identifier")
                .IsRequired();
        });
        

        builder.OwnsOne(d => d.Path, dn =>
        {
            dn.Property(n => n.Name)
                .HasColumnName("path")
                .IsRequired();
        });
        builder.Property(d => d.Depth).HasColumnName("depth");
        builder.Property(d => d.CreateAt).HasColumnName("create_at");
        builder.Property(d => d.UpdateAt).HasColumnName("update_at");
        builder.Property(d => d.ParentId).HasColumnName("parent_id");
        builder.Property(d => d.IsActive).HasColumnName("is_active");
        builder.HasMany(d => d.DepartmentLocations)
            .WithOne(dl => dl.Department)
            .HasForeignKey(dp => dp.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(d => d.DepartmentPositions)
            .WithOne(dp =>  dp.Department)
            .HasForeignKey(dp => dp.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}