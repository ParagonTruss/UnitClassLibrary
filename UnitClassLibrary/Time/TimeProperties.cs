using System;

 namespace UnitClassLibrary
{

	public partial class Time
	{
		public double Nanoseconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Nanosecond); }
		}
		public double Microseconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Microsecond); }
		}
		public double Milliseconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Millisecond); }
		}
		public double Seconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Second); }
		}
		public double Minutes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Minute); }
		}
		public double Hours
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Hour); }
		}
		public double Days
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Day); }
		}
		public double Weeks
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Week); }
		}
		public double Months
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Month); }
		}
		public double Years
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Year); }
		}
		public double Decades
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Decade); }
		}
		public double Centuries
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TimeType.Century); }
		}

		public double GetValue(TimeType Units)
		{
			switch (Units)
			{
				case TimeType.Nanosecond:
					return Nanoseconds;
				case TimeType.Microsecond:
					return Microseconds;
				case TimeType.Millisecond:
					return Milliseconds;
				case TimeType.Second:
					return Seconds;
				case TimeType.Minute:
					return Minutes;
				case TimeType.Hour:
					return Hours;
				case TimeType.Day:
					return Days;
				case TimeType.Week:
					return Weeks;
				case TimeType.Month:
					return Months;
				case TimeType.Year:
					return Years;
				case TimeType.Decade:
					return Decades;
				case TimeType.Century:
					return Centuries;
			}
			throw new Exception("Unknown TimeType");
		}
	}
}