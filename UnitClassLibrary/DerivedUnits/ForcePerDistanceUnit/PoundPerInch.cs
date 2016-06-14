using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class PoundPerInch : ForcePerDistanceType
    {
        public override string AsStringSingular()
        {
            return "Pound per Inch";
        }
        public override string AsStringPlural()
        {
            return "Pounds per Inch";
        }

        public override UnitDimensions Dimensions()
        {
            throw new NotImplementedException();
        }
    }
}
