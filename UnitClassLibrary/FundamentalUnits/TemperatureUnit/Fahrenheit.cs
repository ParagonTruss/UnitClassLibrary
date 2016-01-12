using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.TemperatureUnit;

namespace UnitClassLibrary.FundamentalUnits.TemperatureUnit
{
    public class Fahrenheit : TemperatureType
    {
        public override double DefaultErrorMargin
        {
            get { return 0.1; }        
        }
        public override double ConversionFactor { get { return 1.0; } }
        public override string AsStringSingular()
        {
            return "Degree Fahrenheit";
        }
        public override string AsStringPlural()
        {
            return "Degrees Fahrenheit";
        }

    }
}
