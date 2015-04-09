using System;
using System.Collections.Generic;
using System.Text;

namespace UnitClassLibrary
{

    /// <summary>
    /// delegate that defines the form of 
    /// </summary>
    /// <param name="AngularDistance1"></param>
    /// <param name="AngularDistance2"></param>
    /// <returns></returns>
    public delegate bool AngularDistanceEqualityStrategy(AngularDistance AngularDistance1, AngularDistance AngularDistance2);

    public partial class AngularDistance
    {
        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinDeviationConstant(AngularDistance AngularDistance, AngularDistance passedAcceptedEqualityDeviationAngularDistance)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((AngularDistance)(AngularDistance)).GetValue(this._internalUnitType))
                ))
                <= passedAcceptedEqualityDeviationAngularDistance.GetValue(_internalUnitType);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinDeviationPercentage(AngularDistance AngularDistance, double passedAcceptedEqualityDeviationPercentage)
        {
            return (Math.Abs(this.GetValue(this.InternalUnitType) - (AngularDistance).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType) * passedAcceptedEqualityDeviationPercentage;


        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinAngularDistanceEqualityStrategy(AngularDistance AngularDistance, AngularDistanceEqualityStrategy passedStrategy)
        {
            return passedStrategy(this, AngularDistance);
        }
    }

    /// <summary>
    /// Default deviations allowed when comparing AngularDistance objects.
    /// </summary>
    public static partial class DeviationDefaults
    {
        /// <summary>
        /// When comparing two AngularDistances and deviation is allowed to be within a specific constant. This is that default constant
        /// </summary>
        public static AngularDistance AcceptedEqualityDeviationAngularDistance
        {
            get
            {
                return AngularDistance.Degree;
            }
        }

        /// <summary>
        /// When comparing two AngularDistances and deviation is allowed to be within a percentage of the first AngularDistance. This is that percentage
        /// </summary>
        public static double AcceptedEqualityDeviationAngularDistancePercentage
        {
            get
            {
                return 1;
            }
        }
    }

    /// <summary>
    /// functions that can be used for a AngularDistance object's equals function
    /// </summary>
    public static class AngularDistanceEqualityStrategyImplementations
    {
        /// <summary>
        /// AngularDistances are equal if they differ by less than a percentage of the first AngularDistance
        /// </summary>
        /// <param name="AngularDistance1">first AngularDistance being compared</param>
        /// <param name="AngularDistance2">second AngularDistance being compared</param>
        /// <returns></returns>
        public static bool DefaultPercentageEquality(AngularDistance AngularDistance1, AngularDistance AngularDistance2)
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = AngularDistance1.GetValue(AngularDistance1.InternalUnitType);

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = AngularDistance2.GetValue(AngularDistance1.InternalUnitType);

            // find the difference in the two values
            double difference = dimension1Value - dimension2Value;

            // in case one of those numbers was negative take the absolute value
            difference = Math.Abs(difference);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            double tolerance = dimension1Value * DeviationDefaults.AcceptedEqualityDeviationAngularDistancePercentage;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            bool dimensionsAreEqual = (difference <= tolerance);

            return dimensionsAreEqual;
        }

        /// <summary>
        /// AngularDistances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        /// <param name="AngularDistance1">first AngularDistance being compared</param>
        /// <param name="AngularDistance2">second AngularDistance being compared</param>
        /// <returns></returns>
        public static bool DefaultConstantEquality(AngularDistance AngularDistance1, AngularDistance AngularDistance2)
        {
            return (Math.Abs(AngularDistance1.GetValue(AngularDistance1.InternalUnitType) - (AngularDistance2).GetValue(AngularDistance1.InternalUnitType))) <= DeviationDefaults.AcceptedEqualityDeviationAngularDistance.GetValue(AngularDistance1.InternalUnitType);
        }
    }
}

