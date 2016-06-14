using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class KilonewtonPerMeter : ForcePerDistanceType
    {
        public override string AsStringSingular()
        {
            return "Kilonewtons per Meter";
        }

        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new Kilonewton(), new Meter());
        }
    }
}