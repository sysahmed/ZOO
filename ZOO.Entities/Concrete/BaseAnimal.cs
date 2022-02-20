using ZOO.Core.Entities;

namespace ZOO.Entities.Concrete
{
    public class BaseAnimal : IEntity
    {
        public int AnimalId { get; set; }
        public int AnimalHealtPoints { get; set; } = 100;
        public string AnimalName { get; set; }
        public Life life { get; set; }
    }
}
