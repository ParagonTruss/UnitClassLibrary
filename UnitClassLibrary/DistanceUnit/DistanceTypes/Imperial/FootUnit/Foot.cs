using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit
{
    public class Foot : IDistanceUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Feet";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Foot";
            }
        }

        public double ConversionFactor
        {
            get { return 12; }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return new Inch().DefaultErrorMargin / ConversionFactor;
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
