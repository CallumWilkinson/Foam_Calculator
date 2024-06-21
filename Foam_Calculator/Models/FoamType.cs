using System.Transactions;

namespace Foam_Calculator.Models
{
    public class FoamType
    {
        public int Id { get; set; }

        public string Colour { get; set; }

        public int Thickness { get; set; }

        public int SKU { get; set; }

        public decimal unitPrice { get; set; }



        //constructor takes in a string[] row, type casts all the values and sets then to the fields of the object
        public FoamType(string[] row)
        {
            Id = int.Parse(row[0]);
            Colour = row[1];
            Thickness = int.Parse(row[2]);
            SKU = int.Parse(row[3]);
            unitPrice = decimal.Parse(row[4]);
        }


    }

    
}
