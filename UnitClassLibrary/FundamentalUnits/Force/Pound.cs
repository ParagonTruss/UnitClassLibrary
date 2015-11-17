using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.ForceUnit
{
    public class Pound : FundamentalUnitType
    {
        public override string AsStringPlural
        {
            get
            {
                return "Pounds";
            }
        }

        public override string AsStringSingular
        {
            get
            {
                return "Pound";
            }
        }

        public override double ConversionFactor
        {
            get
            {
                return 1.0;
            }
        }

        public override double DefaultErrorMargin_
        {
            get
            {
                return 1;
            }
        }
    }
}
