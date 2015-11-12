using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.InchesSquaredUnit
{
    public class SquareInch : IAreaType
    {
        public string AsStringPlural
        {
            get
            {
                return "Square Inches";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Square Inch";
            }
        }

        public double ConversionFactor
        {           
            get
            {
                return 1.0;
            }
        }
    }
}