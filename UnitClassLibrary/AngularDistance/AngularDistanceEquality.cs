using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="angulardistance1"></param>
	/// <param name="angulardistance2"></param>
	/// <returns></returns>
	public delegate bool AngularDistanceEqualityStrategy (AngularDistance angulardistance1, AngularDistance angulardistance2);

	public partial class AngularDistance
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(AngularDistance angulardistance, AngularDistance passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((AngularDistance)(angulardistance)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(AngularDistance angulardistance, AngularDistance passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (angulardistance).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(AngularDistance angulardistance, AngularDistanceEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, angulardistance);
		}
	}

	/// <summary> Default deviations allowed when comparing AngularDistance objects </summary>
	public static partial class AngularDistanceDeviationDefaults
	{

		/// <summary> When comparing two angulardistance and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static AngularDistance AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new AngularDistance(AngleType.Radian, 1); }
		}

		/// <summary> When comparing two angulardistance and deviation is allowed to be within a percentage of the firstAngularDistance. This is that percentage </summary>
		public static double  AngularDistanceAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a angulardistance object's equals functions </summary>
	public static class AngularDistanceEqualityStrategyImplementations
	{

		/// <summary> AngularDistances are equal if they differ by less than a percentage of the first AngularDistance </summary>
		/// <param name="angulardistance1">first angulardistance being compared</param>
		/// <param name="angulardistance2">second angulardistance being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (AngularDistance angulardistance1, AngularDistance angulardistance2)
		{
			return (Math.Abs(angulardistance1.GetValue(angulardistance1.InternalUnitType) - (angulardistance2).GetValue(angulardistance1.InternalUnitType))) <= Math.Abs(angulardistance1.GetValue( angulardistance1.InternalUnitType) * AngularDistanceDeviationDefaults.AngularDistanceAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> AngularDistances are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="angulardistance1">first angulardistance being compared</param>
		/// <param name="angulardistance2">second angulardistance being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (AngularDistance angulardistance1, AngularDistance angulardistance2)
		{
			return (Math.Abs(angulardistance1.GetValue(angulardistance1.InternalUnitType) - (angulardistance2).GetValue(angulardistance1.InternalUnitType))) <= AngularDistanceDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(angulardistance1.InternalUnitType);
		}
	}
}