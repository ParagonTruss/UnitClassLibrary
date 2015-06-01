using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.SpeedUnit.SpeedTypes
{
    public class InchPerSecond:ISpeedType
    {


        public double GetConversionFactor()
        {
            return new Inch().GetConversionFactor()/new Second().GetConversionFactor();
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