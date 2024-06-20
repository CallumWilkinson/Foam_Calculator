using Foam_Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Foam_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
  

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CalculateQuantity(QuantityCalculationModel quantityCalculationModel)
        {
            ViewBag.quantity = quantityCalculationModel.InputLength * quantityCalculationModel.InputWidth * quantityCalculationModel.InputNumber_of_Cushions;
            return View("Index");
        }
    }
}
