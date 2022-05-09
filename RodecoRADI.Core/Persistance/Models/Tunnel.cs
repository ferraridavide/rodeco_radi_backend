using System.ComponentModel.DataAnnotations.Schema;

namespace RodecoRADI.Core.Persistance.Models
{
    public class Tunnel : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Coordinates Coordinates { get; set; }
        public DateTime CreationDate { get; set; }
        [NotMapped]
        public EntityType Type => EntityType.tunnel;

        public string? TunnelLength { get; set; }
        public IEnumerable<Photo>? Photos { get; set; }

    }
}
