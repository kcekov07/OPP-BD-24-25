using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationMinutes",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Flights",
                newName: "DepartureTime");

            migrationBuilder.RenameColumn(
                name: "Aircraft",
                table: "Flights",
                newName: "FlightNumber");

            migrationBuilder.AddColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departure",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "FlightNumber",
                table: "Flights",
                newName: "Aircraft");

            migrationBuilder.RenameColumn(
                name: "DepartureTime",
                table: "Flights",
                newName: "DepartureDate");

            migrationBuilder.AddColumn<int>(
                name: "DurationMinutes",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
