using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public static partial class DeviationDefaults
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
