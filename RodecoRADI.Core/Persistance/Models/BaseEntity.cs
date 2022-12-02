using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public interface IBaseEntity
    {
        [NotMapped]
        [JsonPropertyName("id")]
        public string _Id { get; }

        [JsonIgnore]
        public Guid Id { get; }
        public string Name { get;}
        public string Code { get;}
        public Coordinates? Coordinates { get; }
        public DateTimeOffset CreationDate { get; }

        [JsonIgnore]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonIgnore]
        public DateTimeOffset? DateModified { get; set; }

        [JsonIgnore]
        public bool MarkAsDeleted { get; set; }

        [NotMapped]
        public EntityType Type { get; }

        public ICollection<Photo>? Photos { get; set; }
    }
}
