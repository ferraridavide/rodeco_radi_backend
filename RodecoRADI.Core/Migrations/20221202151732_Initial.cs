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
                name: "Bridges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    StartCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    ProjectDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfBuild = table.Column<int>(type: "int", nullable: true),
                    FacilityType_Value = table.Column<int>(type: "int", nullable: true),
                    FacilityType_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BridgeAxleShape_Value = table.Column<int>(type: "int", nullable: true),
                    BridgeAxleShape_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlignmentShapeOnBridge_Value = table.Column<int>(type: "int", nullable: true),
                    AlignmentShapeOnBridge_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementTransverseFall_Value = table.Column<int>(type: "int", nullable: true),
                    PavementTransverseFall_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaticSystem_Value = table.Column<int>(type: "int", nullable: true),
                    StaticSystem_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionMethod_Value = table.Column<int>(type: "int", nullable: true),
                    ConstructionMethod_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foundation_Value = table.Column<int>(type: "int", nullable: true),
                    Foundation_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrossSectionType_Value = table.Column<int>(type: "int", nullable: true),
                    CrossSectionType_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperstructureMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    SuperstructureMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportType_Value = table.Column<int>(type: "int", nullable: true),
                    SupportType_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfDilatationDevices_Value = table.Column<int>(type: "int", nullable: true),
                    TypeOfDilatationDevices_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Waterproofing_Value = table.Column<int>(type: "int", nullable: true),
                    Waterproofing_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    PavementMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrainageSystem_Value = table.Column<int>(type: "int", nullable: true),
                    DrainageSystem_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedestrianSeparationWays_Value = table.Column<int>(type: "int", nullable: true),
                    PedestrianSeparationWays_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedestrianWaysCover_Value = table.Column<int>(type: "int", nullable: true),
                    PedestrianWaysCover_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrafficBarriers_Value = table.Column<int>(type: "int", nullable: true),
                    TrafficBarriers_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedestrianFences_Value = table.Column<int>(type: "int", nullable: true),
                    PedestrianFences_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Installations_Value = table.Column<int>(type: "int", nullable: true),
                    Installations_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeNameObstacle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityCurvature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Span = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpanLenght = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalConstructionLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinmaxHeightUnderFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEndPillars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionMiddlePillars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrainageFacilitiesNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObstacleVisitingPossibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementWidthFirstDilatation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementWidthMiddle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementWidthLastDilatation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthLeftPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthRightPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MarkAsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bridges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
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
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MarkAsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sidewalks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    StartCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    ProjectDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfBuild = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinmaxHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StructureMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    StructureMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MarkAsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidewalks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tunnels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    StartCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    ProjectDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfBuild = table.Column<int>(type: "int", nullable: true),
                    MinMaxHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthEntrancePortal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthExitPortal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthTunnelPipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTunnellength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrossSectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthLeftPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidthRightPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TunnelAxleShape_Value = table.Column<int>(type: "int", nullable: true),
                    TunnelAxleShape_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlignmentShapeTunnel_Value = table.Column<int>(type: "int", nullable: true),
                    AlignmentShapeTunnel_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementTransverseFall_Value = table.Column<int>(type: "int", nullable: true),
                    PavementTransverseFall_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiningMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    LiningMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrainageSystem_Value = table.Column<int>(type: "int", nullable: true),
                    DrainageSystem_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PavementMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    PavementMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedestrianWayMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    PedestrianWayMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TunnelVentilation_Value = table.Column<int>(type: "int", nullable: true),
                    TunnelVentilation_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TunnelInstallations_Value = table.Column<int>(type: "int", nullable: true),
                    TunnelInstallations_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvacuationTunnel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NichesForParking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Waterproofing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfDrainageFacilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TunnelIllumination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFanRows = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HydrantNetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberSosCabin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberFireProtectionDevices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallsPainting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObstacleVisitingPossibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MarkAsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tunnels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Walls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    StartCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Latitude = table.Column<double>(type: "float", nullable: true),
                    EndCoordinates_Longitude = table.Column<double>(type: "float", nullable: true),
                    ProjectDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfBuild = table.Column<int>(type: "int", nullable: true),
                    TotalWalllength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinmaxHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallType_Value = table.Column<int>(type: "int", nullable: true),
                    WallType_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallLocation_Value = table.Column<int>(type: "int", nullable: true),
                    WallLocation_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallLocationInCrossSection_Value = table.Column<int>(type: "int", nullable: true),
                    WallLocationInCrossSection_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallMaterial_Value = table.Column<int>(type: "int", nullable: true),
                    WallMaterial_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foundation_Value = table.Column<int>(type: "int", nullable: true),
                    Foundation_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MarkAsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BridgeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GalleryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SidewalkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TunnelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WallId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Bridges_BridgeId",
                        column: x => x.BridgeId,
                        principalTable: "Bridges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Sidewalks_SidewalkId",
                        column: x => x.SidewalkId,
                        principalTable: "Sidewalks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Tunnels_TunnelId",
                        column: x => x.TunnelId,
                        principalTable: "Tunnels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Walls_WallId",
                        column: x => x.WallId,
                        principalTable: "Walls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BridgeId",
                table: "Photos",
                column: "BridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_GalleryId",
                table: "Photos",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SidewalkId",
                table: "Photos",
                column: "SidewalkId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TunnelId",
                table: "Photos",
                column: "TunnelId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_WallId",
                table: "Photos",
                column: "WallId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Bridges");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Sidewalks");

            migrationBuilder.DropTable(
                name: "Tunnels");

            migrationBuilder.DropTable(
                name: "Walls");
        }
    }
}
