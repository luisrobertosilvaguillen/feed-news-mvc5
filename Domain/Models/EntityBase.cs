using Domain.Interfaces;

namespace Domain.Models
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
