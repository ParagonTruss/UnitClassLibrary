using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.YardUnit
{
    public class Yard : IDistanceUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Yards";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Yard";
            }
        }

        public double ConversionFactor
        {
            get { return 36; }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return new Inch().DefaultErrorMargin / ConversionFactor;
            }
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
            return passedDistance.ConversionFromThisTo(new Yard());
        }
    }
}
