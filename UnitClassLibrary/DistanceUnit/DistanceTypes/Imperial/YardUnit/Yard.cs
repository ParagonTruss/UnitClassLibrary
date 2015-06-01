namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.YardUnit
{
    public class Yard : IDistanceType
    {
        public double GetConversionFactor()
        {
             return 2.54;
        }
    }

    public static class YardExtensions
    {
        public static Distance FromYardsToDistance(this double passedDouble)
        {
            return new Distance(new Yard(), passedDouble);
        }

        public static Distance FromYardsToDistance(this int passedint)
        {
            return new Distance(new Yard(), passedint);
        }

        public static double AsYards(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Yard());
        }
    }
}
