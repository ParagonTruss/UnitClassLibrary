using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit
{
    public class Meter : IDistanceType
    {
        public double GetConversionFactor()
        {
             return 2.54;
        }
    }

    public static class MeterExtensions
    {
        public static Distance FromMetersToDistance(this double passedDouble)
        {
            return new Distance(new Meter(), passedDouble);
        }

        public static Distance FromMetersToDistance(this int passedint)
        {
            return new Distance(new Meter(), passedint);
        }

        public static double AsMeters(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Inch());
        }
    }
}
