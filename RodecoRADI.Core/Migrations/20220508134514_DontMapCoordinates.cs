using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodecoRADI.Core.Migrations
{
    public partial class DontMapCoordinates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates_Latitude",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "Coordinates_Longitude",
                table: "Galleries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Coordinates_Latitude",
                table: "Galleries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Coordinates_Longitude",
                table: "Galleries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
