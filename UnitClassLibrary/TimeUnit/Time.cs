using System.Collections.Generic;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public class Time:GenericUnit<ITimeType>
    {
        public Time(ITimeType TimeType, double passedDouble)
            : base(new List<Unit>() { new Unit(passedDouble, TimeType) }, new List<Unit>())
        {
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