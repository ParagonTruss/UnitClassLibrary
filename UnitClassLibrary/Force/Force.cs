using System;

 namespace UnitClassLibrary
{

	public partial class Force
	{
		#region _fields and Internal Properties

		internal ForceType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private ForceType _internalUnitType;

		private double _intrinsicValue;

		public ForceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private ForceEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Force(ForceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = ForceType.Pound;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Force(ForceType passedForceType, double passedInput, ForceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedForceType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Force(Force passedForce)
		{
			_intrinsicValue = passedForce._intrinsicValue;
			_internalUnitType = passedForce._internalUnitType;
			_equalityStrategy = passedForce._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static ForceEqualityStrategy _chooseDefaultOrPassedStrategy(ForceEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return ForceEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(ForceType toForceType)
		{
			return ConvertForce(_internalUnitType, _intrinsicValue, toForceType);
		}

		#endregion
	}
}