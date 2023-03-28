using Entities.Abstract;

namespace Entities.Concrete
{
    public class FoodVictim : IEntity
    {
        public int Id { get; set; }
        public int VictimId { get; set; }
    }
}
