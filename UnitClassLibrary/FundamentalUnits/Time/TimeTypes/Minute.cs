using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Minute : TimeType
    {

        override public string AsStringSingular()
        {
            return "Minute";
        }

        override public double ConversionFactor
        {
            get
            {
                return 60;
            }
        }

        override public double DefaultErrorMargin
        {
            get
            {
                return new Second().DefaultErrorMargin / ConversionFactor;
            }
        }
    }
}