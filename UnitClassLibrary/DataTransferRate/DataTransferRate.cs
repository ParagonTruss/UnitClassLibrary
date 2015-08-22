namespace UnitClassLibrary
{

	public partial class DataTransferRate
	{
		#region _fields and Internal Properties
		private Data _data;
		private Time _time;

		internal DataTransferRateType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private DataTransferRateType _internalUnitType;

		public DataTransferRateEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private DataTransferRateEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public DataTransferRate(DataTransferRateEqualityStrategy passedStrategy = null)
		{
			_data = new Data();
			_time = new Time();
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
         public DataTransferRate(Data passedData, Time passedTime, DataTransferRateEqualityStrategy passedStrategy = null)
		{
			_data = passedData;
			_time = passedTime;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);

		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public DataTransferRate(DataTransferRateType passedDataTransferRateType, double passedValue)
		{
			switch (passedDataTransferRateType)
			{
			case DataTransferRateType.BitsPerNanosecond:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.BitsPerMicrosecond:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.BitsPerMillisecond:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.BitsPerSecond:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.BitsPerMinute:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.BitsPerHour:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.BitsPerDay:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.BitsPerWeek:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.BitsPerMonth:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.BitsPerYear:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.BitsPerDecade:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.BitsPerCentury:
				_data = new Data(DataType.Bit, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.BytesPerNanosecond:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.BytesPerMicrosecond:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.BytesPerMillisecond:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.BytesPerSecond:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.BytesPerMinute:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.BytesPerHour:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.BytesPerDay:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.BytesPerWeek:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.BytesPerMonth:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.BytesPerYear:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.BytesPerDecade:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.BytesPerCentury:
				_data = new Data(DataType.Byte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.KilobytesPerNanosecond:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.KilobytesPerMicrosecond:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.KilobytesPerMillisecond:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.KilobytesPerSecond:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.KilobytesPerMinute:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.KilobytesPerHour:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.KilobytesPerDay:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.KilobytesPerWeek:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.KilobytesPerMonth:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.KilobytesPerYear:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.KilobytesPerDecade:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.KilobytesPerCentury:
				_data = new Data(DataType.Kilobyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.MegabytesPerNanosecond:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.MegabytesPerMicrosecond:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.MegabytesPerMillisecond:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.MegabytesPerSecond:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.MegabytesPerMinute:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.MegabytesPerHour:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.MegabytesPerDay:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.MegabytesPerWeek:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.MegabytesPerMonth:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.MegabytesPerYear:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.MegabytesPerDecade:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.MegabytesPerCentury:
				_data = new Data(DataType.Megabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.GigabytesPerNanosecond:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.GigabytesPerMicrosecond:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.GigabytesPerMillisecond:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.GigabytesPerSecond:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.GigabytesPerMinute:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.GigabytesPerHour:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.GigabytesPerDay:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.GigabytesPerWeek:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.GigabytesPerMonth:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.GigabytesPerYear:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.GigabytesPerDecade:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.GigabytesPerCentury:
				_data = new Data(DataType.Gigabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.TerabytesPerNanosecond:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.TerabytesPerMicrosecond:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.TerabytesPerMillisecond:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.TerabytesPerSecond:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.TerabytesPerMinute:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.TerabytesPerHour:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.TerabytesPerDay:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.TerabytesPerWeek:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.TerabytesPerMonth:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.TerabytesPerYear:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.TerabytesPerDecade:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.TerabytesPerCentury:
				_data = new Data(DataType.Terabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.PetabytesPerNanosecond:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.PetabytesPerMicrosecond:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.PetabytesPerMillisecond:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.PetabytesPerSecond:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.PetabytesPerMinute:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.PetabytesPerHour:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.PetabytesPerDay:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.PetabytesPerWeek:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.PetabytesPerMonth:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.PetabytesPerYear:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.PetabytesPerDecade:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.PetabytesPerCentury:
				_data = new Data(DataType.Petabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.ExabytesPerNanosecond:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.ExabytesPerMicrosecond:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.ExabytesPerMillisecond:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.ExabytesPerSecond:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.ExabytesPerMinute:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.ExabytesPerHour:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.ExabytesPerDay:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.ExabytesPerWeek:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.ExabytesPerMonth:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.ExabytesPerYear:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.ExabytesPerDecade:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.ExabytesPerCentury:
				_data = new Data(DataType.Exabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.ZettabytesPerNanosecond:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.ZettabytesPerMicrosecond:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.ZettabytesPerMillisecond:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.ZettabytesPerSecond:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.ZettabytesPerMinute:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.ZettabytesPerHour:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.ZettabytesPerDay:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.ZettabytesPerWeek:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.ZettabytesPerMonth:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.ZettabytesPerYear:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.ZettabytesPerDecade:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.ZettabytesPerCentury:
				_data = new Data(DataType.Zettabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			case DataTransferRateType.YottabytesPerNanosecond:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Nanosecond, 1);
				break;
			case DataTransferRateType.YottabytesPerMicrosecond:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Microsecond, 1);
				break;
			case DataTransferRateType.YottabytesPerMillisecond:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Millisecond, 1);
				break;
			case DataTransferRateType.YottabytesPerSecond:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Second, 1);
				break;
			case DataTransferRateType.YottabytesPerMinute:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Minute, 1);
				break;
			case DataTransferRateType.YottabytesPerHour:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Hour, 1);
				break;
			case DataTransferRateType.YottabytesPerDay:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Day, 1);
				break;
			case DataTransferRateType.YottabytesPerWeek:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Week, 1);
				break;
			case DataTransferRateType.YottabytesPerMonth:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Month, 1);
				break;
			case DataTransferRateType.YottabytesPerYear:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Year, 1);
				break;
			case DataTransferRateType.YottabytesPerDecade:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Decade, 1);
				break;
			case DataTransferRateType.YottabytesPerCentury:
				_data = new Data(DataType.Yottabyte, passedValue);
				_time = new Time(TimeType.Century, 1);
				break;
			}
		}

		#endregion

		#region helper _methods

		private static DataTransferRateEqualityStrategy _chooseDefaultOrPassedStrategy(DataTransferRateEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return DataTransferRateEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		#endregion
	}
}