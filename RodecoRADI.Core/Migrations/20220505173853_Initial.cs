using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodecoRADI.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coordinates_Latitude = table.Column<double>(type: "float", nullable: false),
                    Coordinates_Longitude = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    StartCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    ProjectDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfBuild = table.Column<int>(type: "int", nullable: true),
                    MinMaxHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryLenght = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthRightPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthLeftPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryAxleShape_Value = table.Column<int>(type: "int", nullable: true),
                    GalleryAxleShape_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlignmentShape_Value = table.Column<int>(type: "int", nullable: true),
                    AlignmentShape_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementTransverseFall_Value = table.Column<int>(type: "int", nullable: true),
                    PavementTransverseFall_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material_Value = table.Column<int>(type: "int", nullable: true),
                    Material_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrainageSystem_Value = table.Column<int>(type: "int", nullable: true),
                    DrainageSystem_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    PavementMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedestrianWayMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    PedestrianWayMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Installations_Value = table.Column<int>(type: "int", nullable: true),
                    Installations_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Waterproofing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nDrainageFacilities = table.Column<int>(type: "int", nullable: true),
                    GalleryIllumination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tunnels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coordinates_Latitude = table.Column<double>(type: "float", nullable: false),
                    Coordinates_Longitude = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TunnelLength = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tunnels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GalleryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TunnelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Tunnels_TunnelId",
                        column: x => x.TunnelId,
                        principalTable: "Tunnels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_GalleryId",
                table: "Photos",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TunnelId",
                table: "Photos",
                column: "TunnelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Tunnels");
        }
    }
}
