using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit;
using UnitClassLibrary.ForceUnit;


namespace UnitClassLibrary.DerivedUnits
{
    public class NewtonMeter : MomentType
    {
        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Newton(), new Meter() });
        }

        public override string AsStringSingular()
        {
            return "Newton-Meter";
        }
    }
}
