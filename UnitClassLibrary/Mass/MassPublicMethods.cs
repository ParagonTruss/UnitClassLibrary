using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Mass
    {
        /// <summary>
        /// prints the value and unit type converted to
        /// </summary>
        /// <param name="massType"></param>
        public string ToString(MassType massType)
        {
            return this.GetValue(massType) + " " + massType;
        }

        /// <summary>
        /// Creates a new Mass that is the negative of this
        /// </summary>
        /// <returns>new Mass object with value equivalent to result</returns>
        public Mass Negate()
        {
            return new Mass(_internalUnitType, _intrinsicValue * -1);
        }

        /// <summary>
        /// Creates a new Mass that is the absolute value of this
        /// </summary>
        /// <returns>new Mass object with value equivalent to result</returns>
        public Mass AbsoluteValue()
        {
            return new Mass(_internalUnitType, Math.Abs(_intrinsicValue));
        }

        /// <summary>
        /// multiplies itself a given number of times
        /// </summary>
        /// <param name="power">number of times to multiply by</param>
        /// <returns>new Mass object with value equivalent to result</returns>
        public Mass RaiseToPower(double power)
        {
            return this ^ power;
        }

    }
}
