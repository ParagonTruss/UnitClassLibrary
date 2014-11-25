using System;
using System.Collections.Generic;
using System.Text;

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
                return new Distance(DistanceType.ThirtySecond, 1);
            }
        }

        /// <summary>
        /// When comparing two distances and deviation is allowed to be within a percentage of the first Distance. This is that percentage
        /// </summary>
        public static double AcceptedEqualityDeviationDistancePercentage
        {
            get
            {
                return 0.00001;
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
            return (Math.Abs(distance1.GetValue(distance1.InternalUnitType) - (distance2).GetValue(distance1.InternalUnitType))) <= Math.Abs(distance1.GetValue(distance1.InternalUnitType) * DeviationDefaults.AcceptedEqualityDeviationDistancePercentage);
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

