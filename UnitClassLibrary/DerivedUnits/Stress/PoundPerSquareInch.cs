using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.SquareInchesUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits.Stress
{
    public class PoundPerSquareInch : StressType
    {
        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new Pound(), new SquareInch());
        }

        public override string AsStringSingular()
        {
            return "Pound per Square Inch.";
        }
        public override string AsStringPlural()
        {
            return "Pounds per Square Inch.";
        }
    }
}
