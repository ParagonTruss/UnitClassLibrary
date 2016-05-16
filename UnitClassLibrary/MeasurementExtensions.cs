using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class MeasurementExtensions
    {
        public static Unit<T> ToUnit<T>(this Measurement m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }

        public static Unit<T> ToUnit<T>(this double m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }

        public static Unit<T> ToUnit<T>(this int m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }
    }
}
