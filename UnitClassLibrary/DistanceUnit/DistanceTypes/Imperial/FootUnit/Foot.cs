using System;

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
