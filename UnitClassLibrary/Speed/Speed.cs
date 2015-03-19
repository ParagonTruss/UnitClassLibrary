using System;

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
		 public Speed()
		{
			_distance = new Distance();
			_time = new Time();
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
		public Speed(Distance passedDistance, Time passedTime)
		{
			_distance = passedDistance;
			_time = passedTime;
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Speed(SpeedType passedSpeedType, double passedValue)
		{
			switch (passedSpeedType)
			{
			case SpeedType.MillimetersPerNanosecond:
				_distance = new Distance(DistanceType.Millimeter, passedValue);
				_time = new Time(TimeType.Nanosecond, passedValue);
				break;
			case SpeedType.MillimetersPerMicrosecond:
				_distance = new Distance(DistanceType.Centimeter, passedValue);
				_time = new Time(TimeType.Microsecond, passedValue);
				break;
			case SpeedType.MillimetersPerMillisecond:
				_distance = new Distance(DistanceType.Meter, passedValue);
				_time = new Time(TimeType.Millisecond, passedValue);
				break;
			case SpeedType.MillimetersPerSecond:
				_distance = new Distance(DistanceType.Kilometer, passedValue);
				_time = new Time(TimeType.Second, passedValue);
				break;
			case SpeedType.MillimetersPerMinute:
				_distance = new Distance(DistanceType.Inch, passedValue);
				_time = new Time(TimeType.Minute, passedValue);
				break;
			case SpeedType.MillimetersPerHour:
				_distance = new Distance(DistanceType.Foot, passedValue);
				_time = new Time(TimeType.Hour, passedValue);
				break;
			case SpeedType.MillimetersPerDay:
				_distance = new Distance(DistanceType.Yard, passedValue);
				_time = new Time(TimeType.Day, passedValue);
				break;
			case SpeedType.MillimetersPerWeek:
				_distance = new Distance(DistanceType.Mile, passedValue);
				_time = new Time(TimeType.Week, passedValue);
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