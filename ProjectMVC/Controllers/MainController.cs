using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Data.Concrete.EntityFramework;
using ProjectMVC.Models.Concrete;

namespace ProjectMVC.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
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
