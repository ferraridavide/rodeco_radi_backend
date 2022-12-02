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
    public class Sidewalk : IBaseEntity
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
        public EntityType Type => EntityType.sidewalk;

        public string? Section { get; set; }
        public string? Chainage { get; set; }
        public Coordinates? StartCoordinates { get; set; }
        public Coordinates? EndCoordinates { get; set; }
        public string? ProjectDocumentation { get; set; }
        [Range(0, 2999)]
        public int? YearOfBuild { get; set; }

        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? MinmaxHeight { get; set; }
        public EnumOrCustom<SidewalkStructureMaterial>? StructureMaterial { get; set; }
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
