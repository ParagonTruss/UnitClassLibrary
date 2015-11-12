using System;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit
{
    public class Centimeter : IDistanceUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Centimeters";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Centimeter";
            }
        }

        public double ConversionFactor
        {
            get { return 0.393700787401575D; }
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
            return passedDistance.GetValue(new Centimeter());
        }
    }
}
