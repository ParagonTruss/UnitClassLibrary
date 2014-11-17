using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Distance : IComparable<Distance>
    {
        /// <summary>
        /// This implements the IComparable interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="other">Distance being compared to</param>
        /// <returns></returns>
        public int CompareTo(Distance other)
        {
            // We use the equals operator to avoid having to rehash the equality
            // deviation
            if (this.Equals(other))
                return 0;
            else
                return _intrinsicValue.CompareTo(other.GetValue(_internalUnitType));
        }
    }
}
