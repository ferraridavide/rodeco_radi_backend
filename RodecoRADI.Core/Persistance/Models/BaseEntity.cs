using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public interface BaseEntity
    {
        [NotMapped]
        [JsonPropertyName("id")]
        public string _Id { get; }

        [JsonIgnore]
        public Guid Id { get; }
        public string Name { get;}
        public string Code { get;}
        public Coordinates? Coordinates { get; }
        public DateTime CreationDate { get; }
        
        [NotMapped]
        public EntityType Type { get; }

        public ICollection<Photo>? Photos { get; set; }
    }
}
