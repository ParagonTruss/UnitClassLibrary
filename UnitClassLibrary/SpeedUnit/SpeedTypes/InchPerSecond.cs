using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
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

        public double ConversionFactor
        {
            get { return new Inch().ConversionFactor/new Second().ConversionFactor; }
        }

        public IDistanceUnit GetDistanceType()
        {
            return new Inch();
        }

        public ITimeType GetTimeType()
        {
            return new Second();
        }
    }
}