using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.Time
{
    public partial struct Time
    {
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1._internalUnitType, (t1.GetValue(t1._internalUnitType) + t2.GetValue(t1._internalUnitType)));
        }
    }
}
