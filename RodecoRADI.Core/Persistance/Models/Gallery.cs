using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Gallery : IBaseEntity
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
        public EntityType Type => EntityType.gallery;

        public string? Section { get; set; }
        public string? Chainage { get; set; }
        public Coordinates? StartCoordinates { get; set; } 
        public Coordinates? EndCoordinates { get; set; }
        public string? ProjectDocumentation { get; set; }
        [Range(0, 2999)]
        public int? YearOfBuild { get; set; }
        public string? MinMaxHeight { get; set; }
        public string? GalleryLenght { get; set; }
        public string? PavementWidth { get; set; }
        public string? WidthRightPedestrianWay { get; set; }
        public string? WidthLeftPedestrianWay { get; set; }

        public EnumOrCustom<AxleShape>? GalleryAxleShape { get; set; }
        public EnumOrCustom<AlignmentShape>? AlignmentShape { get; set; }
        public EnumOrCustom<PavementTransverseFall>? PavementTransverseFall { get; set; }
        public EnumOrCustom<GalleryMaterial>? Material { get; set; }
        public EnumOrCustom<DrainageSystem>? DrainageSystem { get; set; }
        public EnumOrCustom<PavementMaterial>? PavementMaterial { get; set; }
        public EnumOrCustom<GalleryPedestrianWayMaterial>? PedestrianWayMaterial { get; set; }
        public EnumOrCustom<Installations>? Installations { get; set; }
        [OverlayIgnore]
        public ICollection<Photo>? Photos { get; set; }
        public string? Waterproofing { get; set; }
        public int? nDrainageFacilities { get; set; }
        public string? GalleryIllumination { get; set; }
        public string? Notes { get; set; }

        [JsonIgnore]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonIgnore]
        public DateTimeOffset? DateModified { get; set; }

        [JsonIgnore]
        public bool MarkAsDeleted { get; set; } = false;
    }
}
