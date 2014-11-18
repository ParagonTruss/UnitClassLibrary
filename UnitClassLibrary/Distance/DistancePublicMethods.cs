using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Distance
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
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinDeviationConstant(Distance distance, Distance passedAcceptedEqualityDeviationDistance)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Distance)(distance)).GetValue(this._internalUnitType))
                ))
                <= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinDeviationPercentage(Distance distance, double passedAcceptedEqualityDeviationPercentage)
        {
            return (Math.Abs(this.GetValue(this.InternalUnitType) - (distance).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType) * passedAcceptedEqualityDeviationPercentage;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinDistanceEqualityStrategy(Distance distance, DistanceEqualityStrategy passedStrategy)
        {
            return passedStrategy(this, distance);
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
