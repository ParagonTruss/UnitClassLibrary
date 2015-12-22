using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.ForceUnit
{
    public class Pound : ForceType
    {

        public override string AsStringSingular()
        {     
            return "Pound";
        }

        public override double ConversionFactor
        {
            get
            {
                return 1.0;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return 1;
            }
        }
    }
}
