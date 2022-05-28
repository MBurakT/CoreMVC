using ProjectMVC.Models.Abstract;

namespace ProjectMVC.Models.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFulfilled { get; set; }
        public int CustomerId { get; set; }
    }
}
