using Foam_Calculator.Models;
using Foam_Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace Foam_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private CalculationModel _CalculationModel;

        private decimal _quantity;

        public decimal _totalPrice;

        public int _sku;

        public string _errorMessage = "";

 
  

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult CalculateQuantity(CalculationModel calculationModel)
        {
            if (!ModelState.IsValid)
            {
                // Return the same view with validation messages
                return View("Index", _CalculationModel);
            }

            _CalculationModel = calculationModel;
            decimal tempquantity = (calculationModel.InputLength * calculationModel.InputWidth) / 100m * calculationModel.InputNumber_of_Cushions;
            _quantity = tempquantity;
            _CalculationModel.OutputQuantity = _quantity;


            FoamUnitPriceService foamUnitPriceService = new FoamUnitPriceService("C:\\Users\\callu\\Documents\\GitHub\\Foam_Calculator\\Foam_Calculator\\FoamPrice.csv");
            CalculateTotalPrice(foamUnitPriceService);

            _CalculationModel.OutputTotalPrice = _totalPrice;
            _CalculationModel.OutputSKU = _sku;

            
            return View("Index", _CalculationModel);
        }

        private void CalculateTotalPrice(FoamUnitPriceService foamUnitPriceService)
        {
            decimal unitPrice = foamUnitPriceService.GetUnitPriceByColourAndThickness(_CalculationModel.InputColour, _CalculationModel.InputThickness);
            decimal totalPrice = _quantity * unitPrice;
            _totalPrice = totalPrice;

            int sku = foamUnitPriceService.GetSkuByColourAndThickness(_CalculationModel.InputColour, _CalculationModel.InputThickness);
            _sku = sku;
        }
    }
}
