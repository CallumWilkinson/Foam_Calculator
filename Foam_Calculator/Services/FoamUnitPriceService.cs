namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {

     
        //list of string arrays containing the data
        private List<string[]> _csvContents;

        public FoamUnitPriceService(string csvFilePath)
        {
            var csvReaderService = new CSVReaderService(csvFilePath);
            _csvContents = csvReaderService.ReadCsvFile();
          
        }


        //private void TypeCastRecords(string[] row)
        //{
        //    int key = int.Parse(row[0]);
        //    string colour = row[1];
        //    int thickness = int.Parse(row[2]);
        //    int sku = int.Parse(row[3]);
        //    double unitPrice = double.Parse(row[4]);
        //}

    }
}
