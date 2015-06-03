namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.MileUnit
{
    public class Mile : IDistanceType
    {
        public double ConversionFactor
        {
            get
            {
                return 63360;
                
            }
        }
    }

    public static class MileExtensions
    {
        public static Distance FromMilesToDistance(this double passedDouble)
        {
            return new Distance(new Mile(), passedDouble);
        }

        public static Distance FromMilesToDistance(this int passedint)
        {
            return new Distance(new Mile(), passedint);
        }

        public static double AsMiles(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Mile());
        }
    }
}
