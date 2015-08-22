namespace UnitClassLibrary
{

	public partial class Time
	{
		#region _fields and Internal Properties

		internal TimeType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private TimeType _internalUnitType;

		private double _intrinsicValue;

		public TimeEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private TimeEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Time(TimeEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = TimeType.Nanosecond;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Time(TimeType passedTimeType, double passedInput, TimeEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedTimeType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Time(Time passedTime)
		{
			_intrinsicValue = passedTime._intrinsicValue;
			_internalUnitType = passedTime._internalUnitType;
			_equalityStrategy = passedTime._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static TimeEqualityStrategy _chooseDefaultOrPassedStrategy(TimeEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return TimeEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType toTimeType)
		{
			return ConvertTime(_internalUnitType, _intrinsicValue, toTimeType);
		}

		#endregion
	}
}