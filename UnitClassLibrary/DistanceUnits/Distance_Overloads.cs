using System;
using UnitClassLibrary.BaseUnit;
using UnitClassLibrary.Core.BasicUnit;

namespace UnitClassLibrary.DistanceUnits
{
    public partial class Distance
    {
        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        public static Distance operator ^(Distance d1, double power)
        {
            return (Distance)((Unit)d1 ^ power);
        }

        /// <summary>
        /// returns a new Unit with the sum of the two passed distances
        /// </summary>
        public static Distance operator +(Distance d1, Distance d2)
        {
            return (Distance)((Unit)d1 + (Unit)d2);
        }

        /// <summary>
        /// returns a new Unit with the difference of the two passed distances
        /// </summary>
        public static Distance operator -(Distance d1, Distance d2)
        {
            //subtract the two Distances
            //return a new Unit with the new value
            return (Distance)((Unit)d1 - (Unit)d2); ;
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Distance operator *(Distance d1, double multiplier)
        {
            return (Distance)((Unit)d1 * multiplier);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Distance operator *(double multiplier, Distance d1)
        {
            return d1 * multiplier;
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Distance operator /(Distance d1, double divisor)
        {
            return (Distance)((Unit)d1 / divisor);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Distance operator /(double divisor, Distance d1)
        {
            return d1 / divisor;
        }
    }
}
