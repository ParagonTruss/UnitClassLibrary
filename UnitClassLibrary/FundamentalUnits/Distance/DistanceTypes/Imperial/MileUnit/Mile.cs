using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.MileUnit
{
    public class Mile : DistanceType
    {

        override public string AsStringSingular()
        {
            return "Mile";
        }

        override public double ConversionFactor
        {
            get
            {
                return 63360;            
            }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Inch().DefaultErrorMargin_ / ConversionFactor;
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
            return passedDistance.ConversionFromThisTo(new Mile());
        }
    }
}
