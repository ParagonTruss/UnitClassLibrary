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
    public delegate bool DistanceEqualityStrategy (Distance distance1, Distance distance2);

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
