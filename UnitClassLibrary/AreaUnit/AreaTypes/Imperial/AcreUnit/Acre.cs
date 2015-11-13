using System;

namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.AcreUnit
{
    public class Acre : IAreaUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Acres";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Acre";
            }
        }

        public double ConversionFactor
        {
            get { return 1; }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return 0;
            }
        }
    }
}