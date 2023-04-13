using Core.Entities;

namespace Entities.Concrete
{
    public class ColdVictim : IEntity
    {
        public int Id { get; set; }
        public int VictimId { get; set; }
    }
}
