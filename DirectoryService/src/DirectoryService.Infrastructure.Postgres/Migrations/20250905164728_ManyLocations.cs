using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class ManyLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_locations_department_department_id",
                table: "department_locations");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "department_positions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "department_id1",
                table: "department_locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "location_id1",
                table: "department_locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_LocationId",
                table: "department_positions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_department_locations_department_id1",
                table: "department_locations",
                column: "department_id1");

            migrationBuilder.CreateIndex(
                name: "IX_department_locations_location_id1",
                table: "department_locations",
                column: "location_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_department_locations_department_department_id1",
                table: "department_locations",
                column: "department_id1",
                principalTable: "department",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_department_locations_location_location_id1",
                table: "department_locations",
                column: "location_id1",
                principalTable: "location",
                principalColumn: "location_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_location_LocationId",
                table: "department_positions",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "location_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_locations_department_department_id1",
                table: "department_locations");

            migrationBuilder.DropForeignKey(
                name: "FK_department_locations_location_location_id1",
                table: "department_locations");

            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_location_LocationId",
                table: "department_positions");

            migrationBuilder.DropIndex(
                name: "IX_department_positions_LocationId",
                table: "department_positions");

            migrationBuilder.DropIndex(
                name: "IX_department_locations_department_id1",
                table: "department_locations");

            migrationBuilder.DropIndex(
                name: "IX_department_locations_location_id1",
                table: "department_locations");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "department_positions");

            migrationBuilder.DropColumn(
                name: "department_id1",
                table: "department_locations");

            migrationBuilder.DropColumn(
                name: "location_id1",
                table: "department_locations");

            migrationBuilder.AddForeignKey(
                name: "FK_department_locations_department_department_id",
                table: "department_locations",
                column: "department_id",
                principalTable: "department",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
