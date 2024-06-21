using Microsoft.AspNetCore.Mvc;

namespace Foam_Calculator.Models
{
    public class CalculatorViewModel
    {
        public decimal Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public int SKU {  get; set; } 

    }
}
