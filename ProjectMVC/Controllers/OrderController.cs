using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
