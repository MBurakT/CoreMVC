using ProjectMVC.Models.Abstract;

namespace ProjectMVC.Models.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
