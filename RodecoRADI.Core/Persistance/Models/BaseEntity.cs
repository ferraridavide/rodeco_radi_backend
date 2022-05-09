using System.ComponentModel.DataAnnotations.Schema;

namespace RodecoRADI.Core.Persistance.Models
{
    public interface BaseEntity
    {
        public Guid Id { get; }
        public string Name { get;}
        public string Code { get;}
        public Coordinates? Coordinates { get; }
        public DateTime CreationDate { get; }
        
        [NotMapped]
        public EntityType Type { get; }
    }
}
