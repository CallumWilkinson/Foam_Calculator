namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {

        //create dictionary
        private readonly Dictionary<int, double> _foamPriceDictionary = new Dictionary<int, double>();

        //list of string arrays containing the data
        private List<string[]> _csvContents;

        public FoamUnitPriceService(string csvFilePath)
        {
            var csvReaderService = new CSVReaderService(csvFilePath);
            _csvContents = csvReaderService.ReadCsvFile();
            PopulateFoamPriceDictionary();
        }

        
        private void PopulateFoamPriceDictionary()
        {
            for (int i = 0; i < _csvContents.Count; i++)
            {
                _foamPriceDictionary.Add(i, _csvContents[i]);
            }
        }

        private void TypeCastRecords(string[] row)
        {
            int key = int.Parse(row[0]);
            string colour = row[1];
            int thickness = int.Parse(row[2]);
            int sku = int.Parse(row[3]);
            double unitPrice = double.Parse(row[4]);
        }

    }
}
