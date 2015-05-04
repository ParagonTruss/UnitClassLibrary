using System;

namespace UnitClassLibrary.BaseUnit
{
    public partial class Unit
    {
        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        public IUnitType InternalUnitType { get; protected set; }

        /// <summary>
        /// The actual value of the stored unit. the 5 in "5 kilometers"
        /// </summary> 
        protected virtual double _IntrinsicValue { get { return _intrinsicValue; } }

        private readonly double _intrinsicValue = 0;

                /// <summary>
        /// The strategy by which this Distance will be compared to another Distance
        /// </summary>
        protected readonly EqualityStrategy _equalityStrategy = Unit.EqualsWithinConstantEquality;

        public virtual Unit DeviationConstant
        {
            get { return new Unit((IUnitType)InternalUnitType, _DeviationConstant); }
            set { _DeviationConstant = ((Unit)value).GetValue(InternalUnitType); }
        }

        protected double _DeviationConstant = 1 / 32.0;

         protected Unit(EqualityStrategy passedStrategy = null)
        {
            if (passedStrategy != null)
            {
                _equalityStrategy = passedStrategy;
            }
        }

         protected Unit(IUnitType unitType, EqualityStrategy passedStrategy = null)
            : this(passedStrategy)
        {
            _intrinsicValue = 1;
            this.InternalUnitType = unitType;
        }

         protected Unit(IUnitType unitType, double value, EqualityStrategy passedStrategy = null)
            : this(passedStrategy)
        {
            _intrinsicValue = value;
            this.InternalUnitType = unitType;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        protected Unit(Unit passedUnit)
        {
            _intrinsicValue = passedUnit._intrinsicValue;
            this.InternalUnitType = passedUnit.InternalUnitType;
            _equalityStrategy = passedUnit._equalityStrategy;
        }
    }
}