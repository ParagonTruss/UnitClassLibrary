using System.Collections.Generic;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public class Time:GenericUnit.GenericUnit
    {
        public Time(ITimeType TimeType, double passedDouble)
            : base(new List<KeyValuePair<double, IUnitType>>() { new KeyValuePair<double, IUnitType>(passedDouble, TimeType) }, new List<KeyValuePair<double, IUnitType>>())
        {
        }

        private Time(GenericUnit.GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Time Negate()
        {
            return new Time(base.Negate());
        }
    }
}