using Foam_Calculator.Models;

namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {

        public List<FoamType> _listOfFoamTypeObjects;

        //list of string arrays containing the data
        private List<string[]> _csvContents;

        public FoamUnitPriceService(string csvFilePath)
        {
            var csvReaderService = new CSVReaderService(csvFilePath);
            _csvContents = csvReaderService.ReadCsvFile();
            _listOfFoamTypeObjects = this.CreateFoamTypeObjects();

        }

        public List<FoamType> CreateFoamTypeObjects()
        {

            //store these objects into a List
            List<FoamType> listOfFoamTypeObjects = new List<FoamType>();


            foreach (string[] row in _csvContents)
            {
                //create new object
                FoamType singleFoamTypeObject = new FoamType(row);

                //add the object to the list of objects
                listOfFoamTypeObjects.Add(singleFoamTypeObject);

            }

            return listOfFoamTypeObjects;

        }
    }
}
