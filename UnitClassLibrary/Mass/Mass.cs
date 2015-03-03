using System;

 namespace UnitClassLibrary
{

	public partial class Mass
	{
		#region _fields and Internal Properties

		internal MassType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private MassType _internalUnitType;

		private double _intrinsicValue;

		public MassEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private MassEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Mass(MassEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = MassType.Gram;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Mass(MassType passedMassType, double passedInput, MassEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedMassType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Mass(Mass passedMass)
		{
			_intrinsicValue = passedMass._intrinsicValue;
			_internalUnitType = passedMass._internalUnitType;
			_equalityStrategy = passedMass._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static MassEqualityStrategy _chooseDefaultOrPassedStrategy(MassEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return MassEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(MassType toMassType)
		{
			return ConvertMass(_internalUnitType, _intrinsicValue, toMassType);
		}

		#endregion
	}
}