using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.New_Attempt.UnitTypes
{
    public class SpeedType:ISpeedType
    {
        private IDistanceType distanceType;
        private ITimeType timeType;

        public SpeedType(Distance distance, Time time)
        {
            this.distanceType = (IDistanceType) distance.GetInternalUnitType();
            this.timeType = (ITimeType) time.GetInternalUnitType();
        }

        public IDistanceType GetDistanceType()
        {
            return distanceType;
        }

        public ITimeType GetTimeType()
        {
            return timeType;
        }

        public double GetConversionFactor()
        {
            return distanceType.GetConversionFactor()/timeType.GetConversionFactor();
        }
    }
}
