using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Mass : IComparable, IComparable<Mass>
    {
        /// <summary>
        /// This implements the IComparable interface and allows Masses to be sorted and such
        /// </summary>
        /// <param name="other">Mass being compared to</param>
        /// <returns></returns>
        public int CompareTo(Mass other)
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
        /// Compares and returns the comparison of a mass and an object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (!(obj is Mass))
            {
                throw new ArgumentException("Expected type Mass.", "obj");
            }

            return this.CompareTo((Mass)obj);
        }
    }
}
