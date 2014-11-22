using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{

    /// <summary>
    /// delegate that defines the form of 
    /// </summary>
    /// <param name="distance1"></param>
    /// <param name="distance2"></param>
    /// <returns></returns>
    public delegate bool MassEqualityStrategy(Mass mass1, Mass mass2);

    public partial class Mass
    {
        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinDeviationConstant(Mass distance, Mass passedAcceptedEqualityDeviationDistance)
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

    public static partial class DeviationDefaults
    {
        public static Distance AcceptedEqualityDeviationDistance
        {
            get
            {
                return new Distance(DistanceType.ThirtySecond, 1);
            }
        }

        public static double AcceptedEqualityDeviationDistancePercentage
        {
            get
            {
                return 0.00001;
            }
        }
    }

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