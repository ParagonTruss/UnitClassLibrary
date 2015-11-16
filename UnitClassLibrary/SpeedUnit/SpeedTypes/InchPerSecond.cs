using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.SpeedUnit.SpeedTypes
{
    public class InchPerSecond : ISpeedUnit
    {
        public string AsStringPlural
        {
            get
            {
                return "Inches per Second";
            }
        }

        public string AsStringSingular
        {
            get
            {
                return "Inch per Second";
            }
        }

        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1.0, new Inch(), new Second());
            }
        }

        public IDistanceType GetDistanceType()
        {
            return new Inch();
        }

        public ITimeType GetTimeType()
        {
            return new Second();
        }
    }
}