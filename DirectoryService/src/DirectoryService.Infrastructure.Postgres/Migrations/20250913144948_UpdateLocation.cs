using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "position");

            migrationBuilder.DropColumn(
                name: "country",
                table: "position");

            migrationBuilder.DropColumn(
                name: "iana_code",
                table: "position");

            migrationBuilder.DropColumn(
                name: "number_street",
                table: "position");

            migrationBuilder.DropColumn(
                name: "postal_code",
                table: "position");

            migrationBuilder.DropColumn(
                name: "room",
                table: "position");

            migrationBuilder.DropColumn(
                name: "street",
                table: "position");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "location");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "position",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "location",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "location",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "iana_code",
                table: "location",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "number_street",
                table: "location",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "postal_code",
                table: "location",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "room",
                table: "location",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "location",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "position");

            migrationBuilder.DropColumn(
                name: "city",
                table: "location");

            migrationBuilder.DropColumn(
                name: "country",
                table: "location");

            migrationBuilder.DropColumn(
                name: "iana_code",
                table: "location");

            migrationBuilder.DropColumn(
                name: "number_street",
                table: "location");

            migrationBuilder.DropColumn(
                name: "postal_code",
                table: "location");

            migrationBuilder.DropColumn(
                name: "room",
                table: "location");

            migrationBuilder.DropColumn(
                name: "street",
                table: "location");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "position",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "position",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "iana_code",
                table: "position",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "number_street",
                table: "position",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "postal_code",
                table: "position",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "room",
                table: "position",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "position",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "location",
                type: "text",
                nullable: true);
        }
    }
}
