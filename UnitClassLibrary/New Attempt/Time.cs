using System.Collections.Generic;

namespace UnitClassLibrary.New_Attempt
{
    public class Time:GenericUnit, ISimpleUnit
    {
        public Time(ITimeType TimeType, double passedDouble)
            : base(new List<KeyValuePair<double, IUnitType>>() { new KeyValuePair<double, IUnitType>(passedDouble, TimeType) }, new List<KeyValuePair<double, IUnitType>>())
        {
        }

        private Time(GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Time Negate()
        {
            return new Time(base.Negate());
        }

        public IUnitType GetInternalUnitType()
        {
            return base.numerators[0].Value;
        }
    }
}