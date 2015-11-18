using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.AngleUnit.AngleTypes
{
    public class Radian : AngleType
    {
        override public string AsStringPlural()
        {
            return "Radians";
        }

        override public string AsStringSingular()
        {
            get
            {
                return "Radian";
            }
        }

        override public double ConversionFactor
        {
            get
            {
                // 180 / pi. Degrees are the standard unit.
                return 57.2957795131D;
            }
        }

        override public double DefaultErrorMargin_
        {
            get
            {
                return new Degree().DefaultErrorMargin_ / this.ConversionFactor;
            }
        }
    }
}
