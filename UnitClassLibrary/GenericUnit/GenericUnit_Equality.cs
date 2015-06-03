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
            double dimension1Value = unit1.GetValue(unit1.ConversionFactor);

            // find the value of dimension2 in terms of dimension1's _internalUnitType
            double dimension2Value = unit2.GetValue(unit1.ConversionFactor);

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

        

        /// <summary>
        /// Distances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        public bool EqualsWithinDeviationConstant(GenericUnit<T> unit, GenericUnit<T> deviation)
        {
            return EqualityStrategies.EqualsWithinDeviationConstant<T>(this, unit, deviation);
        }

        public bool EqualsWithinDeviationConstant(GenericUnit<T> unit, BasicUnit deviation)
        {
            return EqualityStrategies.EqualsWithinDeviationConstant(this, unit, new GenericUnit<T>(new List<BasicUnit>(){deviation}));
        }
    }
}
