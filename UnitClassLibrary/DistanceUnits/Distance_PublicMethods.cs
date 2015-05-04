using System;
using UnitClassLibrary.BaseUnit;

namespace UnitClassLibrary.DistanceUnits
{
    public partial class Distance
    {
        /// <summary>
        /// Creates a new Distance that is the negative of this one
        /// </summary>
        public new Distance Negate()
        {
            return (Distance) base.Negate();
        }

        /// <summary>
        /// Creates a new Distance that is the absolute value of this one
        /// </summary>
        public new Distance AbsoluteValue()
        {
            return (Distance) base.AbsoluteValue(); ;
        }
    }
}
