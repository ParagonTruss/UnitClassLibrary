using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.ForceUnit;


namespace UnitClassLibrary.DerivedUnits
{
    public class PoundInch : MomentType
    {
        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Pound(), new Inch() });
        }

        public override string AsStringSingular()
        {
            return "Pound-Inch";
        }
        public override string AsStringPlural()
        {
            return "Pound-Inches";
        }
    }
}
