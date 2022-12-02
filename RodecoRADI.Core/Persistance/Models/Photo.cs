using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    public partial class Photo
    {
        [OverlayIgnore]
        public Guid Id { get; set; } = new Guid();

        public string? Description { get; set; }

        [NotMapped]
        public bool MarkAsDeleted { get; set; } = false;

        [JsonIgnore]
        public DateTime? DateCreated { get; set; }
        
        [JsonIgnore]
        public DateTime? DateModified { get; set; }
        
        [JsonIgnore, OverlayIgnore]
        public byte[]? Image { get; set; }
    }
}
