using Foam_Calculator.UtilityClasses;

namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {
        private readonly Dictionary<int, double> _foamPriceDictionary = new Dictionary<int, double>();
        
        private IEnumerable<string[]> _csvContents;

        public FoamUnitPriceService(string csvFilePath)
        {
            var csvReaderService = new CSVReaderService(csvFilePath);
            _csvContents = csvReaderService.ReadCsvFile();
            PopulateFoamPriceDictionary();
        }

        
        private void PopulateFoamPriceDictionary()
        {
            foreach (string[] row in _csvContents) 
            {
                if (row.Length >=5) //each row should have a key, colour, thickness, sku and unitprice
                {
                    GetPrice(row);
                }
            }
        }

        private void GetPrice(string[] row)
        {
            int key = int.Parse(row[0]);
            string colour = row[1];
            int thickness = int.Parse(row[2]);
            int sku = int.Parse(row[3]);
            double unitPrice = double.Parse(row[4]);
        }

    }
}
