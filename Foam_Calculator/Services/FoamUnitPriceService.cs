using Foam_Calculator.UtilityClasses;

namespace Foam_Calculator.Services
{
    public class FoamUnitPriceService
    {
        private Dictionary<ColourThicknessKey, double> _unitPriceTable;

        public FoamUnitPriceService()
        {
            _unitPriceTable = new Dictionary<ColourThicknessKey, double>();
        }

        public double GetUnitPriceByColourAndThickness(string colour, int thickness) 
        {

        }

    }
}
