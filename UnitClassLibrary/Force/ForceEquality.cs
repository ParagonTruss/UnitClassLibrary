using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="force1"></param>
	/// <param name="force2"></param>
	/// <returns></returns>
	public delegate bool ForceEqualityStrategy (Force force1, Force force2);

	public partial class Force
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Force force, Force passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Force)(force)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Force force, Force passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (force).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Force force, ForceEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, force);
		}
	}

	/// <summary> Default deviations allowed when comparing Force objects </summary>
	public static partial class ForceDeviationDefaults
	{

		/// <summary> When comparing two force and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Force AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Force(ForceType.Pound, 1); }
		}

		/// <summary> When comparing two force and deviation is allowed to be within a percentage of the firstForce. This is that percentage </summary>
		public static double  ForceAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a force object's equals functions </summary>
	public static class ForceEqualityStrategyImplementations
	{

		/// <summary> Forces are equal if they differ by less than a percentage of the first Force </summary>
		/// <param name="force1">first force being compared</param>
		/// <param name="force2">second force being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Force force1, Force force2)
		{
			return (Math.Abs(force1.GetValue(force1.InternalUnitType) - (force2).GetValue(force1.InternalUnitType))) <= Math.Abs(force1.GetValue( force1.InternalUnitType) * ForceDeviationDefaults.ForceAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Forces are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="force1">first force being compared</param>
		/// <param name="force2">second force being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Force force1, Force force2)
		{
			return (Math.Abs(force1.GetValue(force1.InternalUnitType) - (force2).GetValue(force1.InternalUnitType))) <= ForceDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(force1.InternalUnitType);
		}
	}
}