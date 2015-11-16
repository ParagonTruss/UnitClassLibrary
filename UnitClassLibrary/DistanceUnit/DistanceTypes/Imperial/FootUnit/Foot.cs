using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit
{
    public class Foot : IDistanceType
    {
        override public string AsStringPlural
        {
            get
            {
                return "Feet";
            }
        }

        override public string AsStringSingular
        {
            get
            {
                return "Foot";
            }
        }

        override public double ConversionFactor
        {
            get { return 12; }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Inch().DefaultErrorMargin_ / ConversionFactor;
            }
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
            return passedDistance.ConversionFromThisTo(new Foot());
        }
    }
}
