using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="time1"></param>
	/// <param name="time2"></param>
	/// <returns></returns>
	public delegate bool TimeEqualityStrategy (Time time1, Time time2);

	public partial class Time
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Time time, Time passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Time)(time)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Time time, Time passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (time).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Time time, TimeEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, time);
		}
	}

	/// <summary> Default deviations allowed when comparing Time objects </summary>
	public static partial class TimeDeviationDefaults
	{

		/// <summary> When comparing two time and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Time AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Time(TimeType.Second, 1); }
		}

		/// <summary> When comparing two time and deviation is allowed to be within a percentage of the firstTime. This is that percentage </summary>
		public static double  TimeAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 1; }
		}
	}

	/// <summary> functions that can be used for a time object's equals functions </summary>
	public static class TimeEqualityStrategyImplementations
	{

		/// <summary> Times are equal if they differ by less than a percentage of the first Time </summary>
		/// <param name="time1">first time being compared</param>
		/// <param name="time2">second time being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Time time1, Time time2)
		{
			return (Math.Abs(time1.GetValue(time1.InternalUnitType) - (time2).GetValue(time1.InternalUnitType))) <= Math.Abs(time1.GetValue( time1.InternalUnitType) * TimeDeviationDefaults.TimeAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Times are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="time1">first time being compared</param>
		/// <param name="time2">second time being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Time time1, Time time2)
		{
			return (Math.Abs(time1.GetValue(time1.InternalUnitType) - (time2).GetValue(time1.InternalUnitType))) <= TimeDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(time1.InternalUnitType);
		}
	}
}