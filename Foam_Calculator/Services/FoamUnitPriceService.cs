using Foam_Calculator.UtilityClasses;

namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {
        private Dictionary<ColourThicknessKey, double> _unitPriceTable;

        private CSVReaderService _csvReaderService;
        
        private IEnumerable<string[]> _csvContents;

        public FoamUnitPriceService(string csvFilePath)
        {
            _csvReaderService = new CSVReaderService(csvFilePath);
            _csvContents = _csvReaderService.ReadCsvFile();
        }

        

        //public double GetUnitPriceByColourAndThickness(string colour, int thickness) 
        //{
            
        //}

    }
}
