using System;

 namespace UnitClassLibrary
{

	public partial class Capacitance
	{
		#region _fields and Internal Properties

		internal CapacitanceType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private CapacitanceType _internalUnitType;

		private double _intrinsicValue;

		public CapacitanceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private CapacitanceEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Capacitance(CapacitanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = CapacitanceType.Picofarad;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Capacitance(CapacitanceType passedCapacitanceType, double passedInput, CapacitanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedCapacitanceType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Capacitance(Capacitance passedCapacitance)
		{
			_intrinsicValue = passedCapacitance._intrinsicValue;
			_internalUnitType = passedCapacitance._internalUnitType;
			_equalityStrategy = passedCapacitance._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static CapacitanceEqualityStrategy _chooseDefaultOrPassedStrategy(CapacitanceEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return CapacitanceEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType toCapacitanceType)
		{
			return ConvertCapacitance(_internalUnitType, _intrinsicValue, toCapacitanceType);
		}

		#endregion
	}
}