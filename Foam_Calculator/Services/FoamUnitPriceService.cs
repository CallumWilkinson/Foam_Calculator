using Foam_Calculator.Models;
using System.Diagnostics;
using System.Drawing;

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

        //private bool IsGreenAndThick(FoamType f) => f.Colour == "green" && f.Thickness == 1;


        //public List<FoamType> CreateFoamTypeObjects2()
        //{
        //    return _csvContents
        //        .Select(row => new FoamType(row))
        //        .Where(IsGreenAndThick)
        //        .ToList();
        //}


        //I want to write a proper test class for this i need to make sure i can correctly lookup my list of objects and retrieve the unitprice based on an id lookup
        //i want to be able to go green50mm.UnitPrice, then display it and perform math on it
        //foamunitpriceservice priceService = new FoamUnitPriceService(filepath)
        //priceService.getunitpricebycolorandthickness(green,100) should return the unit price for green100mm

        public double GetUnitPriceByColourAndThickness(string colour, int thickess)
        {
            FoamType selectedFoamType = _listOfFoamTypeObjects.Find(f => f.Colour == colour && f.Thickness == thickess);

            return selectedFoamType.unitPrice;
        }

        public int GetSkuByColourAndThickness(string colour, int thickess)
        {
            FoamType selectedFoamType = _listOfFoamTypeObjects.Find(f => f.Colour == colour && f.Thickness == thickess);

            return selectedFoamType.SKU;
        }
    }
}
