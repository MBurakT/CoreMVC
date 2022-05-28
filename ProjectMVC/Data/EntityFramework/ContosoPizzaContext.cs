using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models.Concrete;

namespace ProjectMVC.Data.EntityFramework
{
    public class ContosoPizzaContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
