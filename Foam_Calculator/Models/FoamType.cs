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

        //constructor takes in a string[] row, type casts all the values and sets then to the fields of the object
        public FoamType(string[] row)
        {
            Id = int.Parse(row[0]);
            Colour = row[1];
            Thickness = int.Parse(row[2]);
            SKU = int.Parse(row[3]);
            unitPrice = double.Parse(row[4]);
        }


        // run a foreach loop over the csv, foreach row create a new foamtype object

    }

    
}
