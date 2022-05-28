using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        public IActionResult Start()
        {
            return View();
        }
    }
}
