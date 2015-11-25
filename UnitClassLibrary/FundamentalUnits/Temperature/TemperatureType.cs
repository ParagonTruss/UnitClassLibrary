using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.TemperatureUnit
{
    abstract public class TemperatureType : FundamentalUnitType
    {
        public override string Type
        {
           get { return nameof(TemperatureType); }
        }
    }
}
