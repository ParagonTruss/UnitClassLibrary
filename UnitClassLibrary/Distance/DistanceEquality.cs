using System;

namespace UnitClassLibrary
{

    /// <summary>
    /// delegate that defines the form of 
    /// </summary>
    /// <param name="distance1"></param>
    /// <param name="distance2"></param>
    /// <returns></returns>
    public delegate bool DistanceEqualityStrategy (Distance distance1, Distance distance2);

    public partial class Distance
    {
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
    }

    /// <summary>
    /// Default deviations allowed when comparing Distance objects.
    /// </summary>
    public static partial class DeviationDefaults
    {
        /// <summary>
        /// When comparing two distances and deviation is allowed to be within a specific constant. This is that default constant
        /// </summary>
        public static Distance AcceptedEqualityDeviationDistance
        {
            get
            {
                return Distance.ThirtySecondInch;
            }
        }

        /// <summary>
        /// When comparing two distances and deviation is allowed to be within a percentage of the first Distance. This is that percentage
        /// </summary>
        public static double AcceptedEqualityDeviationDistancePercentage
        {
            get
            {
                return 0.0001;
            }
        }
    }

    /// <summary>
    /// functions that can be used for a distance object's equals function
    /// </summary>
    public static class EqualityStrategyImplementations
    {
        /// <summary>
        /// Distances are equal if they differ by less than a percentage of the first Distance
        /// </summary>
        /// <param name="distance1">first distance being compared</param>
        /// <param name="distance2">second distance being compared</param>
        /// <returns></returns>
        public static bool DefaultPercentageEquality(Distance distance1, Distance distance2)
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = distance1.GetValue(distance1.InternalUnitType);

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = distance2.GetValue(distance1.InternalUnitType);

            // find the difference in the two values
            double difference = dimension1Value - dimension2Value;

            // in case one of those numbers was negative take the absolute value
            difference = Math.Abs(difference);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            double tolerance = dimension1Value * DeviationDefaults.AcceptedEqualityDeviationDistancePercentage;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            bool dimensionsAreEqual = (difference <= tolerance);

            return dimensionsAreEqual;
        }

        /// <summary>
        /// Distances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        /// <param name="distance1">first distance being compared</param>
        /// <param name="distance2">second distance being compared</param>
        /// <returns></returns>
        public static bool DefaultConstantEquality(Distance distance1, Distance distance2)
        {
            return (Math.Abs(distance1.GetValue(distance1.InternalUnitType) - (distance2).GetValue(distance1.InternalUnitType))) <= DeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(distance1.InternalUnitType);
        }
    }
}

