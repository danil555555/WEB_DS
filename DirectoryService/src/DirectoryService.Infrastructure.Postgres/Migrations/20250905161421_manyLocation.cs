using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class manyLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Depth",
                table: "department",
                newName: "depth");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "department",
                newName: "update_at");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "department",
                newName: "parent_id");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "department",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "department",
                newName: "create_at");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "depth",
                table: "department",
                newName: "Depth");

            migrationBuilder.RenameColumn(
                name: "update_at",
                table: "department",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "parent_id",
                table: "department",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "department",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "create_at",
                table: "department",
                newName: "CreateAt");
        }
    }
}
