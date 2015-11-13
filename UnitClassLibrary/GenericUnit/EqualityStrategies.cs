using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public static class EqualityStrategies
    {
        public static bool EqualsWithinDeviationPercentageStrategy<T>(DerivedUnit unit1, DerivedUnit unit2) where T : IFundamentalUnit
        {
            return EqualsWithinDeviationPercentage<T>(unit1, unit2, unit1.PercentageError);
        }

        public static bool EqualsWithinDeviationPercentage<T>(DerivedUnit unit1, DerivedUnit unit2, double percentage ) where T : IFundamentalUnit
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

        public static bool EqualsWithinDeviationConstantStrategy<T>(DerivedUnit unit1, DerivedUnit unit2) where T : IFundamentalUnit
        {
            return EqualsWithinDeviationConstant<T>(unit1, unit2, unit1.DeviationAsConstant);
        }


        public static bool EqualsWithinDeviationConstant<T>(DerivedUnit unit1, DerivedUnit unit2, DerivedUnit deviation) where T : IFundamentalUnit
        {
            var difference = _absoluteValueOfDifference<T>(unit1, unit2);

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            var dimensionsAreEqual = difference.GetValue(deviation.ConversionFactor) <= deviation.IntrinsicValue;

            return dimensionsAreEqual;
        }

        private static DerivedUnit _absoluteValueOfDifference<T>(DerivedUnit unit1, DerivedUnit unit2) where T : IFundamentalUnit
        {
            throw new NotImplementedException();
           // return (unit1 - unit2).AbsoluteValue();
        }
        
    }
}
