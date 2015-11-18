using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit
{
    public class Millimeter : DistanceType
    {

        override public string AsStringSingular()
        {
            return "Millimeter";
        }

        override public double ConversionFactor
                        
            {
                get
                {
                    return 0.0393700787401575D;
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

    public static class MillimeterExtensions
    {
        public static Distance FromMillimetersToDistance(this double passedDouble)
        {
            return new Distance(new Millimeter(), passedDouble);
        }

        public static Distance FromMillimetersToDistance(this int passedint)
        {
            return new Distance(new Millimeter(), passedint);
        }

        public static double AsMillimeters(this Distance passedDistance)
        {
            return passedDistance.ConversionFromThisTo(new Inch());
        }
    }
}
