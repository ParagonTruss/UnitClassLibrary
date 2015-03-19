using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="angle1"></param>
	/// <param name="angle2"></param>
	/// <returns></returns>
	public delegate bool AngleEqualityStrategy (Angle angle1, Angle angle2);

	public partial class Angle
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Angle angle, Angle passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Angle)(angle)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Angle angle, Angle passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (angle).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Angle angle, AngleEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, angle);
		}
	}

	/// <summary> Default deviations allowed when comparing Angle objects </summary>
	public static partial class AngleDeviationDefaults
	{

		/// <summary> When comparing two angle and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Angle AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Angle(AngleType.Degree, 1); }
		}

		/// <summary> When comparing two angle and deviation is allowed to be within a percentage of the firstAngle. This is that percentage </summary>
		public static double  AngleAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a angle object's equals functions </summary>
	public static class AngleEqualityStrategyImplementations
	{

		/// <summary> Angles are equal if they differ by less than a percentage of the first Angle </summary>
		/// <param name="angle1">first angle being compared</param>
		/// <param name="angle2">second angle being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Angle angle1, Angle angle2)
		{
			return (Math.Abs(angle1.GetValue(angle1.InternalUnitType) - (angle2).GetValue(angle1.InternalUnitType))) <= Math.Abs(angle1.GetValue( angle1.InternalUnitType) * AngleDeviationDefaults.AngleAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Angles are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="angle1">first angle being compared</param>
		/// <param name="angle2">second angle being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Angle angle1, Angle angle2)
		{
			return (Math.Abs(angle1.GetValue(angle1.InternalUnitType) - (angle2).GetValue(angle1.InternalUnitType))) <= AngleDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(angle1.InternalUnitType);
		}
	}
}