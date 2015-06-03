using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.KilometerUnit
{
    public class Kilometer : IDistanceType
    {
        public double ConversionFactor
        {
            get { return 39370.0787401575D; }
        }
    }

    public static class KilometerExtensions
    {
        public static Distance FromKilometersToDistance(this double passedDouble)
        {
            return new Distance(new Kilometer(), passedDouble);
        }

        public static Distance FromKilometerToDistance(this int passedint)
        {
            return new Distance(new Kilometer(), passedint);
        }

        public static double AsKilometers(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Inch());
        }
    }
}
