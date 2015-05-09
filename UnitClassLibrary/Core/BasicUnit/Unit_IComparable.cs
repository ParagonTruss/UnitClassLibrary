using System;

namespace UnitClassLibrary.Core.BasicUnit
{
    public partial class Unit : IComparable, IComparable<Unit>
    {
        /// <summary>
        /// This implements the IComparable (Unit) interface and allows Distances to be sorted and such
        /// </summary>
        public int CompareTo(Unit other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            return _IntrinsicValue.CompareTo(other.GetValue(InternalUnitType));
        }

        /// <summary>
        /// This implements the IComparable (Unit) interface and allows Distances to be sorted and such
        /// </summary>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(String.Format("obj: {0}", obj));
            }

            if (!(obj is Unit))
            {
                throw new ArgumentException(String.Format("Expected type Unit, but found {0}", obj));
            }

            return this.CompareTo((Unit)obj);
        }
    }
}
