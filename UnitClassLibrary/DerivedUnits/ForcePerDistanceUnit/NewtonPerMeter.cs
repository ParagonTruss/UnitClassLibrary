using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class NewtonPerMeter : ForcePerDistanceType
    {
        public override string AsStringSingular()
        {
            return "Newtons per Meter";
        }

        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new Newton(), new Meter());
        }
    }
}
