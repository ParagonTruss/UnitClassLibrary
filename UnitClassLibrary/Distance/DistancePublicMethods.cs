using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Distance
    {
        /// <summary>
        /// prints the value and unit type converted to
        /// </summary>
        /// <param name="distanceType"></param>
        public string ToString(DistanceType distanceType)
        {
            return this.GetValue(distanceType) + " " + distanceType;
        }

        /// <summary>
        /// Creates a new Distance that is the negative of this
        /// </summary>
        /// <returns>new Distance object with value equivalent to result</returns>
        public Distance Negate()
        {
            return new Distance(_internalUnitType, _intrinsicValue * -1);
        }

        /// <summary>
        /// Creates a new Distance that is the absolute value of this
        /// </summary>
        /// <returns>new Distance object with value equivalent to result</returns>
        public Distance AbsoluteValue()
        {
            return new Distance(_internalUnitType, Math.Abs(_intrinsicValue));
        }

        /// <summary>
        /// multiplies itself a given number of times
        /// </summary>
        /// <param name="power">number of times to multiply by</param>
        /// <returns>new Distance object with value equivalent to result</returns>
        public Distance RaiseToPower(double power)
        {
            return this ^ power;
        }

    }
}
