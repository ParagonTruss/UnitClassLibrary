using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial class Broken
    {
        /// <summary>
        /// prints the value and unit type converted to
        /// </summary>
        /// <param name="BrokenType"></param>
        public string ToString(BrokenType BrokenType)
        {
            return this.GetValue(BrokenType) + " " + BrokenType;
        }

        /// <summary>
        /// Creates a new Broken that is the negative of this
        /// </summary>
        /// <returns>new Broken object with value equivalent to result</returns>
        public Broken Negate()
        {
            return new Broken(_internalUnitType, _intrinsicValue * -1);
        }

        /// <summary>
        /// Creates a new Broken that is the absolute value of this
        /// </summary>
        /// <returns>new Broken object with value equivalent to result</returns>
        public Broken AbsoluteValue()
        {
            return new Broken(_internalUnitType, Math.Abs(_intrinsicValue));
        }

        /// <summary>
        /// multiplies itself a given number of times
        /// </summary>
        /// <param name="power">number of times to multiply by</param>
        /// <returns>new Broken object with value equivalent to result</returns>
        public Broken RaiseToPower(double power)
        {
            return this ^ power;
        }

    }
}
