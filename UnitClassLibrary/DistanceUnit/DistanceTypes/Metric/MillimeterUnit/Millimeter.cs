using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit
{
    public class Millimeter : IDistanceType
    {
        public double GetConversionFactor()
        {
             return 2.54;
        }
    }

    public static class MillimeterExtensions
    {
        public static Distance FromMillimetersToDistance(this double passedDouble)
        {
            return new Distance(new Millimeter(), passedDouble);
        }

        public static Distance FromMillimetersToDistance(this int passedint)
        {
            return new Distance(new Millimeter(), passedint);
        }

        public static double AsMillimeters(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Inch());
        }
    }
}
