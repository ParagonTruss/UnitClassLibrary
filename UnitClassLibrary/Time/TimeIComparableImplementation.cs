using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Time : IComparable<Time>
    {
        /// <summary>
        /// This implements the IComparable interface and allows Times to be sorted and such
        /// </summary>
        /// <param name="other">Time being compared to</param>
        /// <returns></returns>
        public int CompareTo(Time other)
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
