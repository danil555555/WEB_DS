using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class loc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_location_LocationId",
                table: "department_positions");

            migrationBuilder.DropIndex(
                name: "IX_department_positions_LocationId",
                table: "department_positions");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "department_positions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "department_positions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_LocationId",
                table: "department_positions",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_location_LocationId",
                table: "department_positions",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
