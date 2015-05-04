namespace UnitClassLibrary.DistanceUnits.DistanceTypes.Imperial.InchUnit
{
    public class Inch : IDistanceType
    {
        public double ConversionFactor
        {
            get { return 2.54; }
        }
    }

    public static class Extensions
    {
        public static Distance FromInchesToDistance(this double passedDouble)
        {
            return new Distance(new Inch(), passedDouble);
        }

        public static Distance FromInchesToDistance(this int passedint)
        {
            return new Distance(new Inch(), passedint);
        }

        public static double AsInches(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Inch());
        }
    }
}
