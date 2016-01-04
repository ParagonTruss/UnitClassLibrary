﻿using System;

namespace UnitClassLibrary
{
    public partial class Distance : IComparable, IComparable<Distance>
    {
        /// <summary>
        /// This implements the IComparable (Distance) interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="other">Distance being compared to</param>
        /// <returns></returns>
        public int CompareTo(Distance other)
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
        /// This implements the IComparable (Distance) interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="obj">object being compared to</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (!( obj is Distance))
            {
                throw new ArgumentException("Expected type Distance.", "obj");
            }

            return this.CompareTo((Distance)obj);
        }
    }
}