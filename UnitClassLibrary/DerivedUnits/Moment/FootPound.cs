using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits
{
    public class FootPound : MomentType
    {

        public override UnitDimensions Dimensions => _dimensions;
        private static readonly UnitDimensions _dimensions = new UnitDimensions(1.0, new List<FundamentalUnitType>() {new Pound(), new Foot()});

        public override string AsStringSingular()
        {
            return "lb-ft";
        }
        public override string AsStringPlural()
        {
            return "lb-ft";
        }
    }
}
