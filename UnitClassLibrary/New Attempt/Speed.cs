using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.New_Attempt.UnitTypes;

namespace UnitClassLibrary.New_Attempt
{
    public class Speed : GenericUnit
    {
        public Speed(ISpeedType SpeedType, double passedDouble)
            : base(new List<KeyValuePair<double, IUnitType>>() { new KeyValuePair<double, IUnitType>(passedDouble, SpeedType) }, new List<KeyValuePair<double, IUnitType>>())
        {
        }

        public Speed(Distance distance, Time time)
            : this(new SpeedType(distance, time), distance.GetValue(distance.GetInternalUnitType()) / time.GetValue(time.GetInternalUnitType()))
        {
        }

        private Speed(GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Speed Negate()
        {
            return new Speed(base.Negate());
        }
    }
}
