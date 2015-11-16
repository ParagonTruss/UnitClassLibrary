using System;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit
{
    public class Inch : IDistanceType
    {
        override public string AsStringPlural
        {
            get
            {
                return "Inches";
            }
        }

        override public string AsStringSingular
        {
            get
            {
                return "Inch";
            }
        }

        override public double ConversionFactor
        {
            get { return 1; }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return 0.03125;
            }
        }
    }

    public static class InchExtensions
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
            return passedDistance.ConversionFromThisTo(new Inch());
        }
    }
}
