using System;

 namespace UnitClassLibrary
{

	public partial class Temperature
	{
		#region _fields and Internal Properties

		internal TemperatureType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private TemperatureType _internalUnitType;

		private double _intrinsicValue;

		public TemperatureEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private TemperatureEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Temperature(TemperatureEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = TemperatureType.Celsius;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Temperature(TemperatureType passedTemperatureType, double passedInput, TemperatureEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedTemperatureType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Temperature(Temperature passedTemperature)
		{
			_intrinsicValue = passedTemperature._intrinsicValue;
			_internalUnitType = passedTemperature._internalUnitType;
			_equalityStrategy = passedTemperature._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static TemperatureEqualityStrategy _chooseDefaultOrPassedStrategy(TemperatureEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return TemperatureEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType toTemperatureType)
		{
			return ConvertTemperature(_internalUnitType, _intrinsicValue, toTemperatureType);
		}

		#endregion
	}
}