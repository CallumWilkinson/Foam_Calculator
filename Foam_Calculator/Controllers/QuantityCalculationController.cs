using Foam_Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foam_Calculator.Controllers
{
    public class QuantityCalculationController : Controller
    {
        QuantityCalculationModel _quantityCalculationModel;

        public QuantityCalculationController()
        {
            QuantityCalculationModel quantityCalculationModel = new QuantityCalculationModel();
            _quantityCalculationModel = quantityCalculationModel;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateQuantity()
        {
            ViewBag.quanity = _quantityCalculationModel.InputLength * _quantityCalculationModel.InputWidth * _quantityCalculationModel.InputNumber_of_Cushions;
            return View();
        }
    }
}
