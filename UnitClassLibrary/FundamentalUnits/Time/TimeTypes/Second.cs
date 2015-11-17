using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Second : TimeType
    {
        override public string AsStringPlural
        {
            get
            {
                return "Seconds";
            }
        }

        override public string AsStringSingular
        {
            get
            {
                return "Second";
            }
        }

        override public double ConversionFactor
        {
            get
            {
                return 1;
            }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return 0.01;
            }
        }
    }
}