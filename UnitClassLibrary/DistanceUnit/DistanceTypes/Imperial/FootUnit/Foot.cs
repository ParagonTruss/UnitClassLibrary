namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit
{
    public class Foot : IDistanceType
    {
        public double GetConversionFactor()
        {
             return 2.54;
        }
    }

    public static class FootExtensions
    {
        public static Distance FromFeetToDistance(this double passedDouble)
        {
            return new Distance(new Foot(), passedDouble);
        }

        public static Distance FromFeetToDistance(this int passedint)
        {
            return new Distance(new Foot(), passedint);
        }

        public static double AsFeet(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Foot());
        }
    }
}
