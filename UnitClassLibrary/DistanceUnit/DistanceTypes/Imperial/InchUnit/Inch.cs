using System;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit
{
    public class Inch : IDistanceUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Inches";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Inch";
            }
        }

        public double ConversionFactor
        {
            get { return 1; }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return 0.03125;
            }
        }

        new public string ToString(bool isPlural = false)
        {
            return ToStringPlural();

        }

        public string ToStringPlural()
        {
            return "Inches";
        }

        public string ToStringSingular()
        {
            return "Inch";
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
