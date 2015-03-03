using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="energy1"></param>
	/// <param name="energy2"></param>
	/// <returns></returns>
	public delegate bool EnergyEqualityStrategy (Energy energy1, Energy energy2);

	public partial class Energy
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Energy energy, Energy passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Energy)(energy)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Energy energy, Energy passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (energy).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Energy energy, EnergyEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, energy);
		}
	}

	/// <summary> Default deviations allowed when comparing Energy objects </summary>
	public static partial class EnergyDeviationDefaults
	{

		/// <summary> When comparing two energy and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Energy AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Energy(EnergyType.Calorie, 1); }
		}

		/// <summary> When comparing two energy and deviation is allowed to be within a percentage of the firstEnergy. This is that percentage </summary>
		public static double  EnergyAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a energy object's equals functions </summary>
	public static class EnergyEqualityStrategyImplementations
	{

		/// <summary> Energys are equal if they differ by less than a percentage of the first Energy </summary>
		/// <param name="energy1">first energy being compared</param>
		/// <param name="energy2">second energy being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Energy energy1, Energy energy2)
		{
			return (Math.Abs(energy1.GetValue(energy1.InternalUnitType) - (energy2).GetValue(energy1.InternalUnitType))) <= Math.Abs(energy1.GetValue( energy1.InternalUnitType) * EnergyDeviationDefaults.EnergyAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Energys are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="energy1">first energy being compared</param>
		/// <param name="energy2">second energy being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Energy energy1, Energy energy2)
		{
			return (Math.Abs(energy1.GetValue(energy1.InternalUnitType) - (energy2).GetValue(energy1.InternalUnitType))) <= EnergyDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(energy1.InternalUnitType);
		}
	}
}