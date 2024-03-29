﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Wall : IBaseEntity
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
        public EntityType Type => EntityType.wall;

        public string? Section { get; set; }
        public string? Chainage { get; set; }
        public Coordinates? StartCoordinates { get; set; }
        public Coordinates? EndCoordinates { get; set; }
        public string? ProjectDocumentation { get; set; }
        [Range(0, 2999)]
        public int? YearOfBuild { get; set; }

        public string? TotalWalllength { get; set; }
        public string? MinmaxHeight { get; set; }
        public EnumOrCustom<WallType>? WallType { get; set; }
        public EnumOrCustom<WallLocation>? WallLocation { get; set; }
        public EnumOrCustom<WallLocationCrossSection>? WallLocationInCrossSection { get; set; }
        public EnumOrCustom<WallMaterial>? WallMaterial { get; set; }
        public EnumOrCustom<WallFoundation>? Foundation { get; set; }
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
