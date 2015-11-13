using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.TimeUnit;

namespace UnitClassLibrary.SpeedUnit
{
    public class Speed : DerivedUnit<ISpeedUnit>
    {
        private DerivedUnit derivedUnit;

        public Speed(ISpeedUnit SpeedType, double intrinsicValue, double errorMargin = 0)
            : base(SpeedType, intrinsicValue, errorMargin) { }

        //public Speed(Distance distance, Time time)
        //    : base(distance.Measurement/time.Measurement,)
        //{
        //}

        public Speed(DerivedUnit<ISpeedUnit> toCopy) : base(toCopy) { }


        new public Speed Negate()
        {
            return (Speed)((DerivedUnit)this).Negate();
        }
    }
}
