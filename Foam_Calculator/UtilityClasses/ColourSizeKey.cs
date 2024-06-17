namespace Foam_Calculator.UtilityClasses
{
    public class ColourThicknessKey
    {
        public string Colour { get; }

        public int Thickness { get; }

        public ColourThicknessKey(string colour, int thickness)
        {
            Colour = colour;
            Thickness = thickness;
        }

        public override bool Equals(object? obj)
        {
            return obj is ColourThicknessKey key &&
                Colour == key.Colour &&
                Thickness == key.Thickness;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Colour, Thickness);
        }

    }
}
