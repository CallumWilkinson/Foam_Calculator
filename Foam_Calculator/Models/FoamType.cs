using System.Transactions;

namespace Foam_Calculator.Models
{
    public class FoamType
    {
        public int Id { get; set; }

        public string Colour { get; set; }

        public int Thickness { get; set; }

        public int SKU { get; set; }

        public double unitPrice { get; set; }


        public FoamType(string[] row)
        {
            Id = int.Parse(row[0]);
            Colour = row[1];
            Thickness = int.Parse(row[2]);
            SKU = int.Parse(row[3]);
            unitPrice = double.Parse(row[4]);
        }



        //foreach row in csv, run SetValuesOfObject(row) when you create and instance of foamtype class you 
        //run this function and pass through a row to populate the object with line from csv
        //i think i just want a constructor that takes in a string[] row, then run a foreach loop, foreach row create a new object

    }

    
}
