using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="mass1"></param>
	/// <param name="mass2"></param>
	/// <returns></returns>
	public delegate bool MassEqualityStrategy (Mass mass1, Mass mass2);

	public partial class Mass
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Mass mass, Mass passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Mass)(mass)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Mass mass, Mass passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (mass).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Mass mass, MassEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, mass);
		}
	}

	/// <summary> Default deviations allowed when comparing Mass objects </summary>
	public static partial class MassDeviationDefaults
	{

		/// <summary> When comparing two mass and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Mass AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Mass(MassType.Gram, 1); }
		}

		/// <summary> When comparing two mass and deviation is allowed to be within a percentage of the firstMass. This is that percentage </summary>
		public static double  MassAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a mass object's equals functions </summary>
	public static class MassEqualityStrategyImplementations
	{

		/// <summary> Masss are equal if they differ by less than a percentage of the first Mass </summary>
		/// <param name="mass1">first mass being compared</param>
		/// <param name="mass2">second mass being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Mass mass1, Mass mass2)
		{
			return (Math.Abs(mass1.GetValue(mass1.InternalUnitType) - (mass2).GetValue(mass1.InternalUnitType))) <= Math.Abs(mass1.GetValue( mass1.InternalUnitType) * MassDeviationDefaults.MassAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Masss are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="mass1">first mass being compared</param>
		/// <param name="mass2">second mass being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Mass mass1, Mass mass2)
		{
			return (Math.Abs(mass1.GetValue(mass1.InternalUnitType) - (mass2).GetValue(mass1.InternalUnitType))) <= MassDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(mass1.InternalUnitType);
		}
	}
}