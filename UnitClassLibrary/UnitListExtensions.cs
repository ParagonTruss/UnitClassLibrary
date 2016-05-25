using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class UnitListExtensions
    {
        public static Unit<T> Sum<T>(this IEnumerable<Unit<T>> units)
            where T : IUnitType
        {
            return units.Aggregate((u, v) => u + v);
        }
    }
}
