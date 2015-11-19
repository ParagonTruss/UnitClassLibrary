using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.YardUnit
{
    public class Yard : DistanceType
    {
        override public string AsStringSingular()
        {
            return "Yard";
        }

        override public double ConversionFactor
        {
            get { return 36; }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Inch().DefaultErrorMargin_ / ConversionFactor;
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
