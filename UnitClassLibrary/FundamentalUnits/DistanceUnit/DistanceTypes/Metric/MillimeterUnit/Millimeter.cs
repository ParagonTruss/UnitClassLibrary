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

        override public double DefaultErrorMargin
        {
            get
            {
                return new Inch().DefaultErrorMargin / ConversionFactor;
            }
        }
    }
}
