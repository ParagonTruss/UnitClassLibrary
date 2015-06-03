using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.SpeedUnit.SpeedTypes
{
    public class InchPerSecond:ISpeedType
    {


        public double ConversionFactor
        {
            get { return new Inch().ConversionFactor/new Second().ConversionFactor; }
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