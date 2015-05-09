using System;

namespace UnitClassLibrary.Core.BasicUnit
{
    public partial class Unit
    {
        /// <summary>
        /// Creates a new Distance that is the negative of this one
        /// </summary>
        public Unit Negate()
        {
            return new Unit(InternalUnitType, _intrinsicValue * -1);
        }

        /// <summary>
        /// Creates a new Distance that is the absolute value of this one
        /// </summary>
        public Unit AbsoluteValue()
        {
            return new Unit(InternalUnitType, Math.Abs(_intrinsicValue));
        }

        public virtual double GetValue(IUnitType unitTypeConvertingTo)
        {
            throw new NotImplementedException();
        }
    }
}