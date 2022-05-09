using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Photo
    {
        public Guid Id { get; set; } = new Guid();
        
        public string? Description { get; set; }
        
        [JsonIgnore]
        public byte[] Image { get; set; }
    }
}
