using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.SpeedUnit.SpeedTypes
{
    public class InchPerSecond : SpeedType
    {
        override public string AsStringPlural()
        {
            return "Inches per Second";
        }

        override public string AsStringSingular()
        {
            return "Inch per Second";
        }

        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1.0, new Inch(), new Second());
            }
        }

        public DistanceType GetDistanceType()
        {
            return new Inch();
        }

        public TimeType GetTimeType()
        {
            return new Second();
        }
    }
}