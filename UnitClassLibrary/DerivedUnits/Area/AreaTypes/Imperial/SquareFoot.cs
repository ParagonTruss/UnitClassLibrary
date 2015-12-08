using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DerivedUnits.Area.AreaTypes.Imperial
{
    public class SquareFoot : AreaType
    {
        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(new List<FundamentalUnitType>() { new Foot(), new Foot() });
            }
        }

        public override string AsStringSingular()
        {
            return "Square Foot";
        }
        public override string AsStringPlural()
        {
            return "Square Feet";
        }
    }
}
