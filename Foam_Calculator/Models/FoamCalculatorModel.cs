namespace Foam_Calculator.Models
{
    public class FoamCalculatorModel
    {
        public int Id {  get; set; }
        public string Colour { get; set; }
        public string Thickness { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int AmountOfCushions { get; set; }
        public double FoamQuantity { get; set; }
        public double FoamPrice { get; set; }
    }
}
