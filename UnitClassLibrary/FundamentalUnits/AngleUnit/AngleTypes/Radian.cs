using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.AngleUnit
{
    public class Radian : AngleType
    {
        public static readonly Radian s = new Radian();

        override public string AsStringPlural()
        {
            return "Radians";
        }

        override public string AsStringSingular()
        {
            return "Radian";
        }

        override public double ConversionFactor
        {
            get
            {
                // 180 / pi. Degrees are the standard unit.
                return 57.2957795131D;
            }
        }

        override public double DefaultErrorMargin
        {
            get
            {
                return new Degree().DefaultErrorMargin / this.ConversionFactor;
            }
        }
    }
}
