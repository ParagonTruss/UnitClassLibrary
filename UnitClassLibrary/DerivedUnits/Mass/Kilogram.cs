using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit;
using UnitClassLibrary.ForceUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.DerivedUnits.Mass
{
    public class Kilogram : MassType
    {
        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Newton(), new Second(), new Second() }, new List<FundamentalUnitType>() { new Meter() });
            }
        }

        public override string AsStringSingular()
        {
            return "Kilogram";
        }
    }
}
