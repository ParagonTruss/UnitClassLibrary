using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.TimeUnit;

namespace UnitClassLibrary.SpeedUnit
{
    public class Speed : GenericUnit<ISpeedType>
    {
        public Speed(ISpeedType SpeedType, double passedDouble)
            : base(new List<Unit>() { new Unit(passedDouble, SpeedType) }, new List<Unit>())
        {
        }

        public Speed(Distance distance, Time time)
            : base(new List<Unit>() { _makeIntoUnit(distance) }, new List<Unit>() { _makeIntoUnit(time) })
        {
        }

        private static Unit _makeIntoUnit(Time time)
        {
            return new Unit(time.GetValue(time.GetInternalUnitType()), time.GetInternalUnitType());
        }

        private static Unit _makeIntoUnit(Distance distance)
        {
            return new Unit(distance.GetValue(distance.GetInternalUnitType()), distance.GetInternalUnitType());
        }

        private Speed(GenericUnit<ISpeedType> toCopy)
            : base(toCopy)
        {
        }

        new public Speed Negate()
        {
            return new Speed(base.Negate());
        }
    }
}
