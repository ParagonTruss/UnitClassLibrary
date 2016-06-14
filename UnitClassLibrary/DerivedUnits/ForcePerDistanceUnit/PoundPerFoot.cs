using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class PoundPerFoot : ForcePerDistanceType
    {
        public override string AsStringSingular()
        {
            return "Pound per foot";
        }
        public override string AsStringPlural()
        {
            return "Pounds per foot";
        }

        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new Pound(), new Foot());
        }
    }
}
