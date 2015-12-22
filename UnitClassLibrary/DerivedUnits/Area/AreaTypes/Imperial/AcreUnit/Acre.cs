using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;


namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.AcreUnit
{
    public class Acre : AreaType
    {
        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(43560, new List<FundamentalUnitType>() { new Foot(), new Foot() });
            }
        }

        override public string AsStringPlural() { return "Acres"; } 
        override public string AsStringSingular() { return "Acre"; }      
    }
}