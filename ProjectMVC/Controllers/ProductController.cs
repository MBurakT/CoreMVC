using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Data.Concrete.EntityFramework;
using ProjectMVC.Models.Concrete;

namespace ProjectMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Products()
        {
            using(var context = new ContosoPizzaContext())
            {
                return View(context.Products.ToList());
            }
            //return View();
        }
    }
}
