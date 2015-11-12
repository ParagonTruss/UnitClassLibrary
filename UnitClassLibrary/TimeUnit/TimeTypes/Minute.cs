using System;

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public class Minute : ITimeType
    {
        public string AsStringPlural
        {
            get
            {
                return "Minutes";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Minute";
            }
        }

        public double ConversionFactor
        {
            get
            {
                return 0.0166666666666667D;
            }
        }
    }
}