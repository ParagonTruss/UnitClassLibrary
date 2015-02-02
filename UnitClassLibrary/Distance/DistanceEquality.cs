using System;
using System.Collections.Generic;
using System.Text;

namespace UnitClassLibrary
{

    /// <summary>
    /// delegate that defines the form of 
    /// </summary>
    /// <param name="Broken1"></param>
    /// <param name="Broken2"></param>
    /// <returns></returns>
    public delegate bool BrokenEqualityStrategy (Broken Broken1, Broken Broken2);

    public partial class Broken
    {
        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinDeviationConstant(Broken Broken, Broken passedAcceptedEqualityDeviationBroken)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Broken)(Broken)).GetValue(this._internalUnitType))
                ))
                <= passedAcceptedEqualityDeviationBroken.GetValue(_internalUnitType);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinDeviationPercentage(Broken Broken, double passedAcceptedEqualityDeviationPercentage)
        {
            return (Math.Abs(this.GetValue(this.InternalUnitType) - (Broken).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType) * passedAcceptedEqualityDeviationPercentage;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinBrokenEqualityStrategy(Broken Broken, BrokenEqualityStrategy passedStrategy)
        {
            return passedStrategy(this, Broken);
        }
    }

    /// <summary>
    /// Default deviations allowed when comparing Broken objects.
    /// </summary>
    public static partial class DeviationDefaults
    {
        /// <summary>
        /// When comparing two Brokens and deviation is allowed to be within a specific constant. This is that default constant
        /// </summary>
        public static Broken AcceptedEqualityDeviationBroken
        {
            get
            {
                return new Broken(BrokenType.ThirtySecond, 1);
            }
        }

        /// <summary>
        /// When comparing two Brokens and deviation is allowed to be within a percentage of the first Broken. This is that percentage
        /// </summary>
        public static double AcceptedEqualityDeviationBrokenPercentage
        {
            get
            {
                return 0.0001;
            }
        }
    }

    /// <summary>
    /// functions that can be used for a Broken object's equals function
    /// </summary>
    public static class EqualityStrategyImplementations
    {
        /// <summary>
        /// Brokens are equal if they differ by less than a percentage of the first Broken
        /// </summary>
        /// <param name="Broken1">first Broken being compared</param>
        /// <param name="Broken2">second Broken being compared</param>
        /// <returns></returns>
        public static bool DefaultPercentageEquality(Broken Broken1, Broken Broken2)
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = Broken1.GetValue(Broken1.InternalUnitType);

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = Broken2.GetValue(Broken1.InternalUnitType);

            // find the difference in the two values
            double difference = dimension1Value - dimension2Value;

            // in case one of those numbers was negative take the absolute value
            difference = Math.Abs(difference);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            double tolerance = dimension1Value * DeviationDefaults.AcceptedEqualityDeviationBrokenPercentage;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            bool dimensionsAreEqual = (difference <= tolerance);

            return dimensionsAreEqual;
        }

        /// <summary>
        /// Brokens are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        /// <param name="Broken1">first Broken being compared</param>
        /// <param name="Broken2">second Broken being compared</param>
        /// <returns></returns>
        public static bool DefaultConstantEquality(Broken Broken1, Broken Broken2)
        {
            return (Math.Abs(Broken1.GetValue(Broken1.InternalUnitType) - (Broken2).GetValue(Broken1.InternalUnitType))) <= DeviationDefaults.AcceptedEqualityDeviationBroken.GetValue(Broken1.InternalUnitType);
        }
    }
}

