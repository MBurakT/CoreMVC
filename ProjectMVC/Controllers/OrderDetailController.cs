using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly ILogger<OrderDetailController> _logger;

        public OrderDetailController(ILogger<OrderDetailController> logger)
        {
            _logger = logger;
        }

        public IActionResult OrderDetails()
        {
            return View();
        }
    }
}



