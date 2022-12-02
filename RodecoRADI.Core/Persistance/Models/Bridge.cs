using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Bridge : IBaseEntity
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
        public EntityType Type => EntityType.bridge;

        public string? Section { get; set; }
        public string? Chainage { get; set; }
        public Coordinates? StartCoordinates { get; set; }
        public Coordinates? EndCoordinates { get; set; }
        public string? ProjectDocumentation { get; set; }
        [Range(0, 2999)]
        public int? YearOfBuild { get; set; }

        public EnumOrCustom<BridgeFacilityType>? FacilityType { get; set; }
        public EnumOrCustom<AxleShape>? BridgeAxleShape { get; set; }
        public EnumOrCustom<BridgeAlignmentShape>? AlignmentShapeOnBridge { get; set; }
        public EnumOrCustom<PavementTransverseFall>? PavementTransverseFall { get; set; }
        public EnumOrCustom<BridgeStaticSystem>? StaticSystem { get; set; }
        public EnumOrCustom<BridgeConstructionMethod>? ConstructionMethod { get; set; }
        public EnumOrCustom<BridgeFoundation>? Foundation { get; set; }
        public EnumOrCustom<BridgeCrossSectionType>? CrossSectionType { get; set; }
        public EnumOrCustom<BridgeSuperstructureMaterial>? SuperstructureMaterial { get; set; }
        public EnumOrCustom<BridgeSupportType>? SupportType { get; set; }
        public EnumOrCustom<BridgeDilatationDevices>? TypeOfDilatationDevices { get; set; }
        public EnumOrCustom<BridgeWaterproofing>? Waterproofing { get; set; }
        public EnumOrCustom<BridgePavementMaterial>? PavementMaterial { get; set; }
        public EnumOrCustom<BridgeDrainageSystem>? DrainageSystem { get; set; }
        public EnumOrCustom<BridgePedestrianSeparation>? PedestrianSeparationWays { get; set; }
        public EnumOrCustom<BridgePedestrianWaysCover>? PedestrianWaysCover { get; set; }
        public EnumOrCustom<BridgeTrafficBarriers>? TrafficBarriers { get; set; }
        public EnumOrCustom<BridgePedestrianFences>? PedestrianFences { get; set; }
        public EnumOrCustom<Installations>? Installations { get; set; }
        public string? TypeNameObstacle { get; set; }
        public string? FacilityCurvature { get; set; }
        public string? Span { get; set; }
        public string? SpanLenght { get; set; }
        public string? TotalConstructionLength { get; set; }
        public string? MinmaxHeightUnderFacility { get; set; }
        public string? DescriptionEndPillars { get; set; }
        public string? DescriptionMiddlePillars { get; set; }
        public string? DrainageFacilitiesNumber { get; set; }
        public string? ObstacleVisitingPossibility { get; set; }
        public string? Notes { get; set; }
        public string? PavementWidthFirstDilatation { get; set; }
        public string? PavementWidthMiddle { get; set; }
        public string? PavementWidthLastDilatation { get; set; }
        public string? WidthLeftPedestrianWay { get; set; }
        public string? WidthRightPedestrianWay { get; set; }

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
