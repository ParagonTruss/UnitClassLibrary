using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.BaseUnit
{
    public delegate bool EqualityStrategy(Unit distance1, Unit distance2);


    public partial class Unit
    {
        /// <summary>
        /// Distances are equal if they differ by less than a percentage of the first Distance
        /// </summary>
        public static bool EqualsWithinDeviationPercentage(Unit unit1, Unit unit2, double percentage = 0.0001)
        {
            var difference = _absoluteValueOfDifference(unit1, unit2);

            // because of rounding errors introduced by type conversions, set a tolerance of .01% of the first dimension's value
            var tolerance = unit1 *percentage;

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            var unitsAreEqual = difference <= tolerance;

            return unitsAreEqual;
        }

        /// <summary>
        /// Distances are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        public static bool EqualsWithinConstantEquality(Unit unit1, Unit unit2)
        {
            var difference = _absoluteValueOfDifference(unit1, unit2);

            // see if the difference is less than or equal to the tolerance, if it is, then they are close enough to be considered equal
            var dimensionsAreEqual = difference <= unit1.DeviationConstant;

            return dimensionsAreEqual;
        }

        private static Unit _absoluteValueOfDifference(Unit unit1, Unit unit2)
        {
            // find the difference in the two values
            var difference = unit1 - unit2;

            // in case one of those numbers was negative take the absolute value
            difference = difference.AbsoluteValue();

            return difference;
        }
    }
}
