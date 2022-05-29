using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models.Abstract;

namespace ProjectMVC.Controllers
{
    public class OperationController : Controller
    {
        private readonly ILogger<OperationController> _logger;

        public OperationController(ILogger<OperationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Edit(int? id)
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }
    }
}
