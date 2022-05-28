using ProjectMVC.Models.Abstract;

namespace ProjectMVC.Models.Concrete
{
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
