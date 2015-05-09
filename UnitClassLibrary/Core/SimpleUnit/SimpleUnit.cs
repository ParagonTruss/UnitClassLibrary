using System;
using UnitClassLibrary.Core.BasicUnit;

namespace UnitClassLibrary.BaseUnit
{
    public partial class SimpleUnit:Unit
    {

        /// <summary>
        /// The standard Unit Constructor that takes the value and the unit type that describes it.
        /// </summary>
        public SimpleUnit(ISimpleUnitType passedSimpleUnitType, double passedInput, EqualityStrategy passedStrategy = null)
            : base(passedSimpleUnitType, passedInput, passedStrategy)
        {
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="passedSimpleUnit">SimpleUnit objet to copy</param>
        public SimpleUnit(SimpleUnit passedSimpleUnit)
            : base(passedSimpleUnit)
        {
        }

        public double GetValue(ISimpleUnitType typeConvertingTo)
        {
            return _ConvertUnit(((ISimpleUnitType)InternalUnitType), _IntrinsicValue, typeConvertingTo);
        }

        protected static double _ConvertUnit(ISimpleUnitType typeConvertingFrom, double value, ISimpleUnitType typeConvertingTo)
        {
            return value * (typeConvertingFrom.ConversionFactor / typeConvertingTo.ConversionFactor);
        }

        public override double GetValue(IUnitType unitTypeConvertingTo)
        {
            return this.GetValue((ISimpleUnitType)unitTypeConvertingTo);
        }
    }
}