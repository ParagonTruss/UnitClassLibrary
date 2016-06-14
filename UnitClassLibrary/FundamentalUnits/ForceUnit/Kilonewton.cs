using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.ForceUnit
{
    public class Kilonewton : ForceType
    {
        public override string AsStringSingular()
        {
            return "Kilonewton";
        }

        public override double ConversionFactor
        {
            get
            {
                return 224.80894309971;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return new Pound().DefaultErrorMargin / ConversionFactor;
            }
        }
    }
}
