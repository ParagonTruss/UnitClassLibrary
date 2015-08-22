using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="stiffness1"></param>
	/// <param name="stiffness2"></param>
	/// <returns></returns>
	public delegate bool StiffnessEqualityStrategy (Stiffness stiffness1, Stiffness stiffness2);

	public partial class Stiffness
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Stiffness stiffness, Stiffness passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Stiffness)(stiffness)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Stiffness stiffness, Stiffness passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (stiffness).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Stiffness stiffness, StiffnessEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, stiffness);
		}
	}

	/// <summary> Default deviations allowed when comparing Stiffness objects </summary>
	public static partial class StiffnessDeviationDefaults
	{

		/// <summary> When comparing two stiffness and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Stiffness AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Stiffness(StiffnessType.NewtonsPerMillimeter, 1); }
		}

		/// <summary> When comparing two stiffness and deviation is allowed to be within a percentage of the firstStiffness. This is that percentage </summary>
		public static double  StiffnessAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a stiffness object's equals functions </summary>
	public static class StiffnessEqualityStrategyImplementations
	{

		/// <summary> Stiffnesss are equal if they differ by less than a percentage of the first Stiffness </summary>
		/// <param name="stiffness1">first stiffness being compared</param>
		/// <param name="stiffness2">second stiffness being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Stiffness stiffness1, Stiffness stiffness2)
		{
			return (Math.Abs(stiffness1.GetValue(stiffness1.InternalUnitType) - (stiffness2).GetValue(stiffness1.InternalUnitType))) <= Math.Abs(stiffness1.GetValue( stiffness1.InternalUnitType) * StiffnessDeviationDefaults.StiffnessAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Stiffnesss are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="stiffness1">first stiffness being compared</param>
		/// <param name="stiffness2">second stiffness being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Stiffness stiffness1, Stiffness stiffness2)
		{
			return (Math.Abs(stiffness1.GetValue(stiffness1.InternalUnitType) - (stiffness2).GetValue(stiffness1.InternalUnitType))) <= StiffnessDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(stiffness1.InternalUnitType);
		}
	}
}