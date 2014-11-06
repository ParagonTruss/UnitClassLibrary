using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Dimension : IComparable<Dimension>
    {
        /// <summary>
        /// This implements the IComparable interface and allows Dimensions to be sorted and such
        /// </summary>
        /// <param name="other">Dimension being compared to</param>
        /// <returns></returns>
        public int CompareTo(Dimension other)
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
