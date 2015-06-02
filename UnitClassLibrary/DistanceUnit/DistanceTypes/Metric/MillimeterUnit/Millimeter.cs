using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit
{
    public class Millimeter : IDistanceType
    {
        public double GetConversionFactor()
        {
            return 0.0393700787401575D;
        }

        public override string ToString()
        {

            return ToStringPlural();


        }

        public string ToStringPlural()
        {
            return "Millimeters";
        }

        public string ToStringSingular()
        {
            return "Millimeter";
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
