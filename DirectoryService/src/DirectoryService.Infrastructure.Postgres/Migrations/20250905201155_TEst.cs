using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class TEst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "department",
                newName: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "location",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "department",
                newName: "department_id");
        }
    }
}
