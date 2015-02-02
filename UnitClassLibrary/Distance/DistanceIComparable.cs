using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial class Broken : IComparable, IComparable<Broken>
    {
        /// <summary>
        /// This implements the IComparable (Broken) interface and allows Brokens to be sorted and such
        /// </summary>
        /// <param name="other">Broken being compared to</param>
        /// <returns></returns>
        public int CompareTo(Broken other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            else
            {
                return _intrinsicValue.CompareTo(other.GetValue(_internalUnitType));
            }
        }

        /// <summary>
        /// This implements the IComparable (Broken) interface and allows Brokens to be sorted and such
        /// </summary>
        /// <param name="obj">object being compared to</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (!( obj is Broken))
            {
                throw new ArgumentException("Expected type Broken.", "obj");
            }

            return this.CompareTo((Broken)obj);
        }
    }
}
