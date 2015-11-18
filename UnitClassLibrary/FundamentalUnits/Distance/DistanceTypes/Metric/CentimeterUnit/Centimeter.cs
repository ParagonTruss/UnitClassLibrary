using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit
{
    public class Centimeter : DistanceType
    {
        override public string AsStringSingular()
        {
            return "Centimeter";
        }

        override public double ConversionFactor
        {
            get { return 0.393700787401575D; }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Inch().DefaultErrorMargin_ / ConversionFactor;
            }
        }
    }

    public static class CentimeterExtensions
    {
        public static Distance FromCentimetersToDistance(this double passedDouble)
        {
            return new Distance(new Centimeter(), passedDouble);
        }

        public static Distance FromCentimetersToDistance(this int passedint)
        {
            return new Distance(new Centimeter(), passedint);
        }

        public static double AsCentimeters(this Distance passedDistance)
        {
            return passedDistance.ConversionFromThisTo(new Centimeter());
        }
    }
}
