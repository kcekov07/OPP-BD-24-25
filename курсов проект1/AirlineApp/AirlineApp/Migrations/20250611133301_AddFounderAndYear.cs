using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFounderAndYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoundedYear",
                table: "Airlines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Founder",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoundedYear",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "Founder",
                table: "Airlines");
        }
    }
}
