namespace Foam_Calculator.Models
{
    public class CalculationModel
    {
        public string InputColour { get; set; }

        public int InputThickness { get; set; }

        public decimal InputLength { get; set; }

        public decimal InputWidth { get; set; }

        public decimal InputNumber_of_Cushions { get; set; }

        public decimal? OutputQuantity { get; set; }

        public decimal? OutputTotalPrice { get; set; }

        public int OutputSKU { get; set; }

    }
}
