using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodecoRADI.Core.Migrations
{
    public partial class AddsOtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordinates_Longitude",
                table: "Tunnels",
                newName: "StartCoordinates_Longitude");

            migrationBuilder.RenameColumn(
                name: "Coordinates_Latitude",
                table: "Tunnels",
                newName: "StartCoordinates_Latitude");

            migrationBuilder.RenameColumn(
                name: "TunnelLength",
                table: "Tunnels",
                newName: "WidthRightPedestrianWay");

            migrationBuilder.AlterColumn<double>(
                name: "StartCoordinates_Longitude",
                table: "Tunnels",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "StartCoordinates_Latitude",
                table: "Tunnels",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "AlignmentShapeTunnel_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlignmentShapeTunnel_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chainage",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CrossSectionType",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrainageSystem_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrainageSystem_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EndCoordinates_Latitude",
                table: "Tunnels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EndCoordinates_Longitude",
                table: "Tunnels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvacuationTunnel",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HydrantNetwork",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LenghtEntrancePortal",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LengthEntrancePortal",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LengthExitPortal",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LengthTunnelPipe",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiningMaterial_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LiningMaterial_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinMaxHeight",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NichesForParking",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberFireProtectionDevices",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfDrainageFacilities",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfFanRows",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberSosCabin",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObstacleVisitingPossibility",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PavementMaterial_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PavementMaterial_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PavementTransverseFall_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PavementTransverseFall_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PavementWidth",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PedestrianWayMaterial_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedestrianWayMaterial_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDocumentation",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalTunnellength",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TunnelAxleShape_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TunnelAxleShape_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TunnelIllumination",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TunnelInstallations_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TunnelInstallations_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TunnelVentilation_Custom",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TunnelVentilation_Value",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WallsPainting",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Waterproofing",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WidthLeftPedestrianWay",
                table: "Tunnels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOfBuild",
                table: "Tunnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BridgeId",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SidewalkId",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WallId",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bridges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    WidthRightPedestrianWay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bridges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sidewalks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidewalks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Walls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Foundation_Custom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BridgeId",
                table: "Photos",
                column: "BridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SidewalkId",
                table: "Photos",
                column: "SidewalkId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_WallId",
                table: "Photos",
                column: "WallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Bridges_BridgeId",
                table: "Photos",
                column: "BridgeId",
                principalTable: "Bridges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Sidewalks_SidewalkId",
                table: "Photos",
                column: "SidewalkId",
                principalTable: "Sidewalks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Walls_WallId",
                table: "Photos",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Bridges_BridgeId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Sidewalks_SidewalkId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Walls_WallId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Bridges");

            migrationBuilder.DropTable(
                name: "Sidewalks");

            migrationBuilder.DropTable(
                name: "Walls");

            migrationBuilder.DropIndex(
                name: "IX_Photos_BridgeId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_SidewalkId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_WallId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "AlignmentShapeTunnel_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "AlignmentShapeTunnel_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "Chainage",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "CrossSectionType",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "DrainageSystem_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "DrainageSystem_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "EndCoordinates_Latitude",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "EndCoordinates_Longitude",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "EvacuationTunnel",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "HydrantNetwork",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LenghtEntrancePortal",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LengthEntrancePortal",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LengthExitPortal",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LengthTunnelPipe",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LiningMaterial_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "LiningMaterial_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "MinMaxHeight",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "NichesForParking",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "NumberFireProtectionDevices",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "NumberOfDrainageFacilities",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "NumberOfFanRows",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "NumberSosCabin",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "ObstacleVisitingPossibility",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PavementMaterial_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PavementMaterial_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PavementTransverseFall_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PavementTransverseFall_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PavementWidth",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PedestrianWayMaterial_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "PedestrianWayMaterial_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "ProjectDocumentation",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TotalTunnellength",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelAxleShape_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelAxleShape_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelIllumination",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelInstallations_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelInstallations_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelVentilation_Custom",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "TunnelVentilation_Value",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "WallsPainting",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "Waterproofing",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "WidthLeftPedestrianWay",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "YearOfBuild",
                table: "Tunnels");

            migrationBuilder.DropColumn(
                name: "BridgeId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "SidewalkId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "WallId",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "StartCoordinates_Longitude",
                table: "Tunnels",
                newName: "Coordinates_Longitude");

            migrationBuilder.RenameColumn(
                name: "StartCoordinates_Latitude",
                table: "Tunnels",
                newName: "Coordinates_Latitude");

            migrationBuilder.RenameColumn(
                name: "WidthRightPedestrianWay",
                table: "Tunnels",
                newName: "TunnelLength");

            migrationBuilder.AlterColumn<double>(
                name: "Coordinates_Longitude",
                table: "Tunnels",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Coordinates_Latitude",
                table: "Tunnels",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
