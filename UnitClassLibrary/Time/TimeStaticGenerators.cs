using System;

 namespace UnitClassLibrary
{

	public partial class Time
	{

		///<summary>Generator method that constructs Time with assumption that the passed value is in Nanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithNanoseconds(double passedValue)
		{
			return new Time(TimeType.Nanosecond, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Microseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithMicroseconds(double passedValue)
		{
			return new Time(TimeType.Microsecond, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Milliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithMilliseconds(double passedValue)
		{
			return new Time(TimeType.Millisecond, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Seconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithSeconds(double passedValue)
		{
			return new Time(TimeType.Second, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Minutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithMinutes(double passedValue)
		{
			return new Time(TimeType.Minute, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Hours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithHours(double passedValue)
		{
			return new Time(TimeType.Hour, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Days</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithDays(double passedValue)
		{
			return new Time(TimeType.Day, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Weeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithWeeks(double passedValue)
		{
			return new Time(TimeType.Week, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Months</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithMonths(double passedValue)
		{
			return new Time(TimeType.Month, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Years</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithYears(double passedValue)
		{
			return new Time(TimeType.Year, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Decades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithDecades(double passedValue)
		{
			return new Time(TimeType.Decade, passedValue);
		}

		///<summary>Generator method that constructs Time with assumption that the passed value is in Centuries</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Time MakeTimeWithCenturies(double passedValue)
		{
			return new Time(TimeType.Century, passedValue);
		}
	}
}