using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnitClassLibrary.TemperatureUnit;

namespace UnitClassLibrary.AngleUnit.Temperature
{
    public class Kelvin : TemperatureType
    {
        public override string AsStringPlural()
        {
            return "Kelvin";
        }

        public override string AsStringSingular()
        {
            return "Kelvin";
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
                return 0.5555555555555555D;
            }
        }
    }
}
