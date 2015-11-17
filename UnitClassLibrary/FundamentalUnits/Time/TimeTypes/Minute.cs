using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Minute : TimeType
    {
        override public string AsStringPlural
        {
            get
            {
                return "Minutes";
            }
        }

        override public string AsStringSingular
        {
            get
            {
                return "Minute";
            }
        }

        override public double ConversionFactor
        {
            get
            {
                return 0.0166666666666667D;
            }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Second().DefaultErrorMargin_ / ConversionFactor;
            }
        }
    }
}