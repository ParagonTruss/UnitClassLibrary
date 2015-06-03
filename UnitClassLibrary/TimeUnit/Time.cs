using System.Collections.Generic;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public class Time:GenericUnit<ITimeType>
    {
        public Time(ITimeType TimeType, double passedDouble, Time acceptableDeviationConstant)
            : base(new List<BasicUnit>() { new BasicUnit(passedDouble, TimeType.ConversionFactor) })
        {
            base._DeviationConstant = acceptableDeviationConstant;
        }

        private Time(GenericUnit<ITimeType> toCopy)
            : base(toCopy)
        {
        }

        new public Time Negate()
        {
            return new Time(base.Negate());
        }
    }
}