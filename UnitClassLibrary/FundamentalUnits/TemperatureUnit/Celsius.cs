using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.TemperatureUnit;

namespace UnitClassLibrary.FundamentalUnits.TemperatureUnit
{
    public class Celsius : TemperatureType
    {
        public override double DefaultErrorMargin
        {
            get { return 5.0/90.0; }
        }
        public override double ConversionFactor
        { get {throw new NotImplementedException();} }
        public override string AsStringSingular()
        {
            return "Degree Celsius";
        }
        public override string AsStringPlural()
        {
            return "Degrees Celsius";
        }
    }
}
