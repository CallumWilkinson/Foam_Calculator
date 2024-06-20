using Foam_Calculator.Models;
using Foam_Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Foam_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private int _quantity;

        private QuantityCalculationModel _quantityCalculationModel;
  

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

        //[HttpPost]

        //public IActionResult RunCalculations(QuantityCalculationModel quantityCalculationModel, FoamUnitPriceService foamUnitPriceService)
        //{
        //    CalculateQuantity(quantityCalculationModel);
        //    CalculateTotalPrice(foamUnitPriceService);
        //    return View("Index");

        //}

        [HttpPost]
        public IActionResult CalculateQuantity(QuantityCalculationModel quantityCalculationModel)
        {
            ViewBag.quantity = (quantityCalculationModel.InputLength * quantityCalculationModel.InputWidth)/100 * quantityCalculationModel.InputNumber_of_Cushions;
            _quantity = ViewBag.quantity;
            _quantityCalculationModel = quantityCalculationModel;
            FoamUnitPriceService foamUnitPriceService = new FoamUnitPriceService("C:\\Users\\callu\\Documents\\GitHub\\Foam_Calculator\\Foam_Calculator\\FoamPrice.csv");
            CalculateTotalPrice(foamUnitPriceService);
            return View("Index");
        }

        [HttpPost]
        public IActionResult CalculateTotalPrice(FoamUnitPriceService foamUnitPriceService)
        {
            double unitPrice = foamUnitPriceService.GetUnitPriceByColourAndThickness(_quantityCalculationModel.InputColour, _quantityCalculationModel.InputThickness);
            double totalPrice = _quantity * unitPrice;
            ViewBag.totalPrice = totalPrice;

            return View("Index");
        }
    }
}
