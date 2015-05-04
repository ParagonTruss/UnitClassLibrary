using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AreaUnits.AreaTypes;
using UnitClassLibrary.AreaUnits.AreaTypes.Imperial.AcreUnit;
using UnitClassLibrary.BaseUnit;

namespace UnitClassLibrary.AreaUnits
{
    public partial class Area
    {

        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        public static Area operator ^(Area d1, double power)
        {
            return (Area)((Unit)d1 ^ power);
        }

        /// <summary>
        /// returns a new Unit with the sum of the two passed distances
        /// </summary>
        public static Area operator +(Area d1, Area d2)
        {
            return (Area)((Unit)d1 + (Unit)d2);
        }

        /// <summary>
        /// returns a new Unit with the difference of the two passed distances
        /// </summary>
        public static Area operator -(Area d1, Area d2)
        {
            //subtract the two Distances
            //return a new Unit with the new value
            return (Area)((Unit)d1 - (Unit)d2); ;
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Area operator *(Area d1, double multiplier)
        {
            return (Area)((Unit)d1 * multiplier);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Area operator *(double multiplier, Area d1)
        {
            return d1 * multiplier;
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Area operator /(Area d1, double divisor)
        {
            return (Area)((Unit)d1 / divisor);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Area operator /(double divisor, Area d1)
        {
            return d1 / divisor;
        }
    }
}
