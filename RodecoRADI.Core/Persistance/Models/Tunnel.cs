using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Tunnel : IBaseEntity
    {
        [NotMapped]
        [JsonPropertyName("id")]
        public string _Id
        {
            get { return Id.ToString(); }
            set { Id = Utils.ParseGuidOrNew(value); }
        }

        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        [JsonIgnore]
        [NotMapped]
        public Coordinates? Coordinates => StartCoordinates;

        public DateTimeOffset CreationDate { get; set; }

        [JsonIgnore]
        [NotMapped]
        public EntityType Type => EntityType.tunnel;

        public string? Section { get; set; }
        public string? Chainage { get; set; }
        public Coordinates? StartCoordinates { get; set; }
        public Coordinates? EndCoordinates { get; set; }
        public string? ProjectDocumentation { get; set; }
        [Range(0, 2999)]
        public int? YearOfBuild { get; set; }

        public string? MinMaxHeight { get; set; }

        public string? LengthEntrancePortal { get; set; }
        public string? LengthExitPortal { get; set; }
        public string? LengthTunnelPipe { get; set; }
        public string? TotalTunnellength { get; set; }
        public string? CrossSectionType { get; set; }
        public string? PavementWidth { get; set; }
        public string? WidthLeftPedestrianWay { get; set; }
        public string? WidthRightPedestrianWay { get; set; }
        public EnumOrCustom<AxleShape>? TunnelAxleShape { get; set; }
        public EnumOrCustom<AlignmentShape>? AlignmentShapeTunnel { get; set; }
        public EnumOrCustom<PavementTransverseFall>? PavementTransverseFall { get; set; }
        public EnumOrCustom<TunnelLiningMaterial>? LiningMaterial { get; set; }
        public EnumOrCustom<DrainageSystem>? DrainageSystem { get; set; }
        public EnumOrCustom<PavementMaterial>? PavementMaterial { get; set; }
        public EnumOrCustom<TunnelPedestrianWayMaterial>? PedestrianWayMaterial { get; set; }
        public EnumOrCustom<TunnelVentilation>? TunnelVentilation { get; set; }
        public EnumOrCustom<Installations>? TunnelInstallations { get; set; }

        public string? EvacuationTunnel { get; set; }
        public string? NichesForParking { get; set; }
        public string? Waterproofing { get; set; }
        public string? NumberOfDrainageFacilities { get; set; }
        public string? TunnelIllumination { get; set; }
        public string? NumberOfFanRows { get; set; }
        public string? HydrantNetwork { get; set; }
        public string? NumberSosCabin { get; set; }
        public string? NumberFireProtectionDevices { get; set; }
        public string? WallsPainting { get; set; }
        public string? ObstacleVisitingPossibility { get; set; }
        public string? Notes { get; set; }

        [OverlayIgnore]
        public ICollection<Photo>? Photos { get; set; }

        [JsonIgnore]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonIgnore]
        public DateTimeOffset? DateModified { get; set; }

        [JsonIgnore]
        public bool MarkAsDeleted { get; set; } = false;
    }
}
