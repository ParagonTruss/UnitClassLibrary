using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.AngleUnit.AngleTypes
{
    class Degree : IAngleUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Degrees";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Degree";
            }
        }

        public double ConversionFactor
        {
            get
            {
                return 1.0;
            }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return 1.0;
            }
        }
    }
}
