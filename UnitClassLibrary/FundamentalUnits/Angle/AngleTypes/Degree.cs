using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.AngleUnit
{
    public class Degree : AngleType
    {
        public override string AsStringPlural()
        {
            return "Degrees";
        }

        public override string AsStringSingular()
        {
            return "Degree";
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
                return 1.0;
            }
        }
    }
}
