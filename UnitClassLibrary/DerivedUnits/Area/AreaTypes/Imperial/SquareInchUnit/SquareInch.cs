using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;


namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.InchesSquaredUnit
{
    public class SquareInch : AreaType
    {
        
        public override string AsStringPlural(){ return "Square Inches"; } 
        public override string AsStringSingular() { return "Square Inch"; }

        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1, new List<FundamentalUnitType>() { new Inch(), new Inch() });
            }
        }
    }
}