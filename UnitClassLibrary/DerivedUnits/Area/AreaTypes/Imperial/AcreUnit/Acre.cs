using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.GenericUnit;

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

        public string AsStringPlural { get { return "Acres"; } }
        public string AsStringSingular { get { return "Acre"; } }      
    }
}