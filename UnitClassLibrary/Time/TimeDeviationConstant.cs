using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static partial class DeviationConstants
    {
        public static Time AcceptedEqualityDeviationTime
        {
            get
            {
                return new Time(TimeType.Nanosecond, 1);
            }
        }
    }
}
