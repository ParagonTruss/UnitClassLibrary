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
            : base(new List<BasicUnit>() { new BasicUnit(passedDouble, SpeedType.ConversionFactor) }, new List<BasicUnit>())
        {
        }

        public Speed(Distance distance, Time time)
            : base(new List<BasicUnit>() { new BasicUnit(distance.GetValue(distance.ConversionFactor), distance.ConversionFactor) }, new List<BasicUnit>() { new BasicUnit(time.GetValue(time.ConversionFactor), time.ConversionFactor) })
        {
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
