using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="speed1"></param>
	/// <param name="speed2"></param>
	/// <returns></returns>
	public delegate bool SpeedEqualityStrategy (Speed speed1, Speed speed2);

	public partial class Speed
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Speed speed, Speed passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Speed)(speed)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Speed speed, Speed passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (speed).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Speed speed, SpeedEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, speed);
		}
	}

	/// <summary> Default deviations allowed when comparing Speed objects </summary>
	public static partial class SpeedDeviationDefaults
	{

		/// <summary> When comparing two speed and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Speed AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Speed(SpeedType.MillimetersPerNanosecond, 1); }
		}

		/// <summary> When comparing two speed and deviation is allowed to be within a percentage of the firstSpeed. This is that percentage </summary>
		public static double  SpeedAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a speed object's equals functions </summary>
	public static class SpeedEqualityStrategyImplementations
	{

		/// <summary> Speeds are equal if they differ by less than a percentage of the first Speed </summary>
		/// <param name="speed1">first speed being compared</param>
		/// <param name="speed2">second speed being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Speed speed1, Speed speed2)
		{
			return (Math.Abs(speed1.GetValue(speed1.InternalUnitType) - (speed2).GetValue(speed1.InternalUnitType))) <= Math.Abs(speed1.GetValue( speed1.InternalUnitType) * SpeedDeviationDefaults.SpeedAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Speeds are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="speed1">first speed being compared</param>
		/// <param name="speed2">second speed being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Speed speed1, Speed speed2)
		{
			return (Math.Abs(speed1.GetValue(speed1.InternalUnitType) - (speed2).GetValue(speed1.InternalUnitType))) <= SpeedDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(speed1.InternalUnitType);
		}
	}
}