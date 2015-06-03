using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public delegate bool EqualityStrategy<T>(GenericUnit<T> Unit1, GenericUnit<T> Unit2) where T: IUnitType;


    public partial class GenericUnit<T>
    {
        public bool EqualsWithinEqualityStrategy(GenericUnit<T> unit, EqualityStrategy<T> userStrategy)
        {
            return userStrategy(this, unit) ;
        }

        /// <summary>
        /// Distances are equal if they differ by less than a percentage of the first Distance
        /// </summary>
        public bool EqualsWithinDeviationPercentage(GenericUnit<T> unit1, GenericUnit<T> unit2, double percentage = 0.0001)
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = unit1.GetValue(unit1.GetInternalUnitType());

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = unit2.GetValue(unit1.GetInternalUnitType());

            // find the difference in the two values
            double difference = dimension1Value - dimension2Value;

            // in case one of those numbers was negative take the absolute value
            difference = Math.Abs(difference);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            double tolerance = dimension1Value * .001;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            bool dimensionsAreEqual = (difference <= tolerance);

            return dimensionsAreEqual;
        }

        public static bool EqualsWithinDeviationPercentageStrategy(GenericUnit<T> unit1, GenericUnit<T> unit2,
            double percentage = 0.0001)
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = unit1.GetValue(unit1.GetInternalUnitType());

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = unit2.GetValue(unit1.GetInternalUnitType());

            // find the difference in the two values
            double difference = dimension1Value - dimension2Value;

            // in case one of those numbers was negative take the absolute value
            difference = Math.Abs(difference);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            double tolerance = dimension1Value * percentage;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            bool dimensionsAreEqual = (difference <= tolerance);

            return dimensionsAreEqual;
        }

        /// <summary>
        /// Distances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        public bool EqualsWithinDeviationConstant(GenericUnit<T> unit, GenericUnit<T> deviation)
        {
            return EqualsWithinDeviationConstantStrategy(this, unit, deviation);
        }

        public bool EqualsWithinDeviationConstant(GenericUnit<T> unit, Unit deviation)
        {
            return EqualsWithinDeviationConstantStrategy(this, unit, new GenericUnit<T>(new List<Unit>(){deviation}));
        }

        public static bool EqualsWithinDeviationConstantStrategy(GenericUnit<T> unit1, GenericUnit<T> unit2, GenericUnit<T> deviation)
        {
            var difference = _absoluteValueOfDifference(unit1, unit2);

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            var dimensionsAreEqual = difference.GetValue(deviation.GetInternalUnitType()) <= deviation._IntrinsicValue;

            return dimensionsAreEqual;
        }

        private static GenericUnit<T> _absoluteValueOfDifference(GenericUnit<T> unit1, GenericUnit<T> unit2)
        {
            // find the difference in the two values
            var difference = unit1 - unit2;

            // in case one of those numbers was negative take the absolute value
            difference = difference.AbsoluteValue();

            return difference;
        }


    }
}
