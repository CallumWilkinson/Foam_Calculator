using Microsoft.AspNetCore.Mvc;
using Foam_Calculator.Services;

namespace Foam_Calculator.Controllers
{
    public class CsvController : Controller
    {
        private readonly CSVReaderService _csvReaderService;

        public CsvController(CSVReaderService csvReaderService)
        {
            _csvReaderService = csvReaderService;
        }


        public ActionResult Index()
        {
            var records = _csvReaderService.ReadCsvFile("C:\\Users\\callu\\Documents\\GitHub\\FoamCalculator\\FoamPrice.csv");
            return View(records);
        }
    }
}
