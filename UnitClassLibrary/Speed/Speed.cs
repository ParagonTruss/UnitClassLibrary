namespace UnitClassLibrary
{

	public partial class Speed
	{
		#region _fields and Internal Properties
		private Distance _distance;
		private Time _time;

		internal SpeedType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private SpeedType _internalUnitType;

		public SpeedEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private SpeedEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
        public Speed(SpeedEqualityStrategy passedStrategy = null)
		{
			_distance = Distance.Zero;
			_time = new Time();
            _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
        public Speed(Distance passedDistance, Time passedTime, SpeedEqualityStrategy passedStrategy = null)
		{
			_distance = passedDistance;
			_time = passedTime;
            _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
        public Speed(SpeedType passedSpeedType, double passedValue, SpeedEqualityStrategy passedStrategy = null)
		{
            _chooseDefaultOrPassedStrategy(passedStrategy);

			switch (passedSpeedType)
			{
			case SpeedType.MillimetersPerNanosecond:
				_distance = new Distance(DistanceType.Millimeter, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case SpeedType.MillimetersPerMicrosecond:
				_distance = new Distance(DistanceType.Centimeter, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case SpeedType.MillimetersPerMillisecond:
				_distance = new Distance(DistanceType.Meter, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case SpeedType.MillimetersPerSecond:
				_distance = new Distance(DistanceType.Kilometer, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case SpeedType.MillimetersPerMinute:
				_distance = new Distance(DistanceType.Inch, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case SpeedType.MillimetersPerHour:
				_distance = new Distance(DistanceType.Foot, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case SpeedType.MillimetersPerDay:
				_distance = new Distance(DistanceType.Yard, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case SpeedType.MillimetersPerWeek:
				_distance = new Distance(DistanceType.Mile, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			}
		}

		#endregion

		#region helper _methods

		private static SpeedEqualityStrategy _chooseDefaultOrPassedStrategy(SpeedEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return SpeedEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		#endregion
	}
}