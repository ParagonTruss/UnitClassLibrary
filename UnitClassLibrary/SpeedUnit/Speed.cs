using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.TimeUnit;

namespace UnitClassLibrary.SpeedUnit
{
    public class Speed : BasicUnit<ISpeedUnit>
    {
        public Speed(ISpeedUnit SpeedType, double intrinsicValue)
            : base(SpeedType, intrinsicValue) { }

        //public Speed(Distance distance, Time time)
        //    : base(BasicUnit(distance.GetValue(distance.ConversionFactor), distance.ConversionFactor) }, new List<BasicUnit>() { new BasicUnit(time.GetValue(time.ConversionFactor), time.ConversionFactor) })
        //{
        //}

        public Speed(BasicUnit<ISpeedUnit> toCopy) : base(toCopy) { }

        new public Speed Negate()
        {
            return new Speed(base.Negate());
        }
    }
}
