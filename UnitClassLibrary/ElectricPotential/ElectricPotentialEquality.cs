using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="electricpotential1"></param>
	/// <param name="electricpotential2"></param>
	/// <returns></returns>
	public delegate bool ElectricPotentialEqualityStrategy (ElectricPotential electricpotential1, ElectricPotential electricpotential2);

	public partial class ElectricPotential
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(ElectricPotential electricpotential, ElectricPotential passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((ElectricPotential)(electricpotential)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(ElectricPotential electricpotential, ElectricPotential passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (electricpotential).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(ElectricPotential electricpotential, ElectricPotentialEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, electricpotential);
		}
	}

	/// <summary> Default deviations allowed when comparing ElectricPotential objects </summary>
	public static partial class ElectricPotentialDeviationDefaults
	{

		/// <summary> When comparing two electricpotential and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static ElectricPotential AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new ElectricPotential(ElectricPotentialType.Microvolt, 1); }
		}

		/// <summary> When comparing two electricpotential and deviation is allowed to be within a percentage of the firstElectricPotential. This is that percentage </summary>
		public static double  ElectricPotentialAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a electricpotential object's equals functions </summary>
	public static class ElectricPotentialEqualityStrategyImplementations
	{

		/// <summary> ElectricPotentials are equal if they differ by less than a percentage of the first ElectricPotential </summary>
		/// <param name="electricpotential1">first electricpotential being compared</param>
		/// <param name="electricpotential2">second electricpotential being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (ElectricPotential electricpotential1, ElectricPotential electricpotential2)
		{
			return (Math.Abs(electricpotential1.GetValue(electricpotential1.InternalUnitType) - (electricpotential2).GetValue(electricpotential1.InternalUnitType))) <= Math.Abs(electricpotential1.GetValue( electricpotential1.InternalUnitType) * ElectricPotentialDeviationDefaults.ElectricPotentialAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> ElectricPotentials are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="electricpotential1">first electricpotential being compared</param>
		/// <param name="electricpotential2">second electricpotential being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (ElectricPotential electricpotential1, ElectricPotential electricpotential2)
		{
			return (Math.Abs(electricpotential1.GetValue(electricpotential1.InternalUnitType) - (electricpotential2).GetValue(electricpotential1.InternalUnitType))) <= ElectricPotentialDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(electricpotential1.InternalUnitType);
		}
	}
}