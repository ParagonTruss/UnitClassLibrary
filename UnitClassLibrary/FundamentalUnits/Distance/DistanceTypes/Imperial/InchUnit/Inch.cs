using System;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit
{
    public class Inch : DistanceType
    {
        override public string AsStringPlural()
        {
            return "Inches";
        }

        override public string AsStringSingular()
        {
            return "Inch";
        }

        override public double ConversionFactor
        {
            get { return 1; }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return 0.015625;
                //return 0.03125;
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
