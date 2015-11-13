using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Second : ITimeType
    {
        public string AsStringPlural
        {
            get
            {
                return "Seconds";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Second";
            }
        }

        public double ConversionFactor
        {
            get
            {
                return 1;
            }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return 0.01;
            }
        }
    }
}