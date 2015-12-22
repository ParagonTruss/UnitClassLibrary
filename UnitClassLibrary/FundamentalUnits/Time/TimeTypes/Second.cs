using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Second : TimeType
    {

        override public string AsStringSingular()
        {
            return "Second";
        }

        override public double ConversionFactor
        {
            get
            {
                return 1;
            }
        }

        override public double DefaultErrorMargin
        {
            get
            {
                return 0.01;
            }
        }
    }
}