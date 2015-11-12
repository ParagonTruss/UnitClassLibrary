using System.Collections.Generic;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public class Time:GenericUnit<ITimeType>
    {
        public Time(ITimeType TimeType, double passedDouble, double errorMargin)
            : base(new List<BasicUnit>() { new BasicUnit(passedDouble, TimeType.ConversionFactor) })
        {
            this.ErrorMargin = errorMargin;
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