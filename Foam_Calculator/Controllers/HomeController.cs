using Foam_Calculator.Models;
using Foam_Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Foam_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private QuantityCalculationModel _quantityCalculationModel;

        private decimal _quantity;

        public decimal _totalPrice;

        public int _sku;

 
  

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
            decimal tempquantity = (quantityCalculationModel.InputLength * quantityCalculationModel.InputWidth) / 100m * quantityCalculationModel.InputNumber_of_Cushions;
            _quantity = tempquantity;
            

            _quantityCalculationModel = quantityCalculationModel;
            FoamUnitPriceService foamUnitPriceService = new FoamUnitPriceService("C:\\Users\\callu\\Documents\\GitHub\\Foam_Calculator\\Foam_Calculator\\FoamPrice.csv");
            CalculateTotalPrice(foamUnitPriceService);

            CalculatorViewModel viewModel = new CalculatorViewModel();
            {
                viewModel.Quantity = _quantity;
                viewModel.TotalPrice = _totalPrice;
                viewModel.SKU = _sku;
            }

            //should i be returning index here?
            return View(viewModel);
        }

        private void CalculateTotalPrice(FoamUnitPriceService foamUnitPriceService)
        {
            decimal unitPrice = foamUnitPriceService.GetUnitPriceByColourAndThickness(_quantityCalculationModel.InputColour, _quantityCalculationModel.InputThickness);
            decimal totalPrice = _quantity * unitPrice;
            _totalPrice = totalPrice;

            int sku = foamUnitPriceService.GetSkuByColourAndThickness(_quantityCalculationModel.InputColour, _quantityCalculationModel.InputThickness);
            _sku = sku;
        }
    }
}
