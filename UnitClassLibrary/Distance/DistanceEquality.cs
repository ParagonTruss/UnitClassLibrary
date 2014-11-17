using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Distance1"></param>
    /// <param name="Distance2"></param>
    /// <param name="DeviationConstant"></param>
    /// <returns></returns>
    public delegate bool DistanceEqualityStrategy (Distance distance1, Distance distance2, Distance? deviationConstant = null, double? deviationPercentage = null);

    public static partial class DeviationConstants
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

    /// <summary>
    /// 
    /// </summary>
    public static class EqualityFunctionImplementations
    {
        /// <summary>
        /// Distances are equal if they differ by less than a percentage of the first Distance
        /// </summary>
        /// <param name="distance1"></param>
        /// <param name="distance2"></param>
        /// <param name="deviationConstant"></param>
        /// <returns></returns>
        public static bool PercentageEquality(Distance distance1, Distance distance2, Distance? deviationConstant = null, double? deviationPercentage = null)
        {
            if (deviationPercentage == null)
            {
                deviationPercentage = DeviationConstants.AcceptedEqualityDeviationDistancePercentage;
            }

            return (Math.Abs(distance1.GetValue(distance1.InternalUnitType) - (distance2).GetValue(distance1.InternalUnitType))) <= Math.Abs(distance1.GetValue(distance1.InternalUnitType) * deviationPercentage.Value);
        }

        /// <summary>
        /// Distances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        /// <param name="distance1"></param>
        /// <param name="distance2"></param>
        /// <param name="deviationConstant"></param>
        /// <returns></returns>
        public static bool ConstantEquality(Distance distance1, Distance distance2, Distance? deviationConstant = null, double? deviationPercentage = null)
        {
            if (deviationConstant == null)
            {
                deviationConstant = DeviationConstants.AcceptedEqualityDeviationDistance;
            }

            return (Math.Abs(distance1.GetValue(distance1.InternalUnitType) - (distance2).GetValue(distance1.InternalUnitType))) <= deviationConstant.Value.GetValue(distance1.InternalUnitType);
        }
    }
}
