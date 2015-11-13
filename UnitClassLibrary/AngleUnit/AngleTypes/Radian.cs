using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.AngleUnit.AngleTypes
{
    public class Radian : IAngleUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Radians";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Radian";
            }
        }

        public double ConversionFactor
        {
            get
            {
                // 180 / pi. Degrees are the standard unit.
                return 57.2957795131D;
            }
        }

        public double DefaultErrorMargin
        {
            get
            {
                return new Degree().DefaultErrorMargin / this.ConversionFactor;
            }
        }
    }
}
