using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="electriccurrent1"></param>
	/// <param name="electriccurrent2"></param>
	/// <returns></returns>
	public delegate bool ElectricCurrentEqualityStrategy (ElectricCurrent electriccurrent1, ElectricCurrent electriccurrent2);

	public partial class ElectricCurrent
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(ElectricCurrent electriccurrent, ElectricCurrent passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((ElectricCurrent)(electriccurrent)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(ElectricCurrent electriccurrent, ElectricCurrent passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (electriccurrent).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(ElectricCurrent electriccurrent, ElectricCurrentEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, electriccurrent);
		}
	}

	/// <summary> Default deviations allowed when comparing ElectricCurrent objects </summary>
	public static partial class ElectricCurrentDeviationDefaults
	{

		/// <summary> When comparing two electriccurrent and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static ElectricCurrent AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new ElectricCurrent(ElectricCurrentType.Ampere, 1); }
		}

		/// <summary> When comparing two electriccurrent and deviation is allowed to be within a percentage of the firstElectricCurrent. This is that percentage </summary>
		public static double  ElectricCurrentAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a electriccurrent object's equals functions </summary>
	public static class ElectricCurrentEqualityStrategyImplementations
	{

		/// <summary> ElectricCurrents are equal if they differ by less than a percentage of the first ElectricCurrent </summary>
		/// <param name="electriccurrent1">first electriccurrent being compared</param>
		/// <param name="electriccurrent2">second electriccurrent being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (ElectricCurrent electriccurrent1, ElectricCurrent electriccurrent2)
		{
			return (Math.Abs(electriccurrent1.GetValue(electriccurrent1.InternalUnitType) - (electriccurrent2).GetValue(electriccurrent1.InternalUnitType))) <= Math.Abs(electriccurrent1.GetValue( electriccurrent1.InternalUnitType) * ElectricCurrentDeviationDefaults.ElectricCurrentAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> ElectricCurrents are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="electriccurrent1">first electriccurrent being compared</param>
		/// <param name="electriccurrent2">second electriccurrent being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (ElectricCurrent electriccurrent1, ElectricCurrent electriccurrent2)
		{
			return (Math.Abs(electriccurrent1.GetValue(electriccurrent1.InternalUnitType) - (electriccurrent2).GetValue(electriccurrent1.InternalUnitType))) <= ElectricCurrentDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(electriccurrent1.InternalUnitType);
		}
	}
}