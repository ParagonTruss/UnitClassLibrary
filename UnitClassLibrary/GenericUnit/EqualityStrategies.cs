using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public static class EqualityStrategies
    {
        public static bool EqualsWithinDeviationPercentageStrategy<T>(GenericUnit unit1, GenericUnit unit2) where T : IUnit
        {
            return EqualsWithinDeviationPercentage(unit1, unit2, unit1.PercentageError);
        }

        public static bool EqualsWithinDeviationPercentage<T>(GenericUnit unit1, GenericUnit unit2, double percentage ) where T : IUnit
        {
            // find the value of dimension1 in terms of its own _internalUnitType
            double dimension1Value = unit1.GetValue(unit1.ConversionFactor);

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = unit2.GetValue(unit1.ConversionFactor);

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

        public static bool EqualsWithinDeviationConstantStrategy<T>(GenericUnit unit1, GenericUnit unit2) where T : IUnit
        {
            return EqualsWithinDeviationConstant(unit1, unit2, unit1.DeviationAsConstant);
        }


        public static bool EqualsWithinDeviationConstant<T>(GenericUnit unit1, GenericUnit unit2, GenericUnit deviation) where T : IUnit
        {
            var difference = _absoluteValueOfDifference(unit1, unit2);

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            var dimensionsAreEqual = difference.GetValue(deviation.ConversionFactor) <= deviation._IntrinsicValue;

            return dimensionsAreEqual;
        }

        private static GenericUnit _absoluteValueOfDifference<T>(GenericUnit unit1, GenericUnit unit2) where T : IUnit
        {
            // find the difference in the two values
            var difference = unit1 - unit2;

            // in case one of those numbers was negative take the absolute value
            difference = difference.AbsoluteValue();

            return difference;
        }
        
    }
}
