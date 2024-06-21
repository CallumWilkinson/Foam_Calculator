using System.ComponentModel.DataAnnotations;

namespace Foam_Calculator.Models
{
    public class CalculationModel
    {
        [Required(ErrorMessage = "Select a Colour")]
        public string InputColour { get; set; }

        [Required(ErrorMessage = "Select a Thickness")]
        public int InputThickness { get; set; }

        [Required(ErrorMessage = "Enter Length")]
        public decimal InputLength { get; set; }

        [Required(ErrorMessage = "Enter Width")]
        public decimal InputWidth { get; set; }

        [Required(ErrorMessage = "Enter number of cushions in this size")]
        public decimal InputNumber_of_Cushions { get; set; }

        public decimal? OutputQuantity { get; set; }

        public decimal? OutputTotalPrice { get; set; }

        public int OutputSKU { get; set; }

    }
}
