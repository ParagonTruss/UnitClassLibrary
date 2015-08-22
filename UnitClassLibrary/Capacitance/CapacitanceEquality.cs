using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="capacitance1"></param>
	/// <param name="capacitance2"></param>
	/// <returns></returns>
	public delegate bool CapacitanceEqualityStrategy (Capacitance capacitance1, Capacitance capacitance2);

	public partial class Capacitance
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Capacitance capacitance, Capacitance passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Capacitance)(capacitance)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Capacitance capacitance, Capacitance passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (capacitance).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Capacitance capacitance, CapacitanceEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, capacitance);
		}
	}

	/// <summary> Default deviations allowed when comparing Capacitance objects </summary>
	public static partial class CapacitanceDeviationDefaults
	{

		/// <summary> When comparing two capacitance and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Capacitance AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Capacitance(CapacitanceType.Picofarad, 1); }
		}

		/// <summary> When comparing two capacitance and deviation is allowed to be within a percentage of the firstCapacitance. This is that percentage </summary>
		public static double  CapacitanceAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a capacitance object's equals functions </summary>
	public static class CapacitanceEqualityStrategyImplementations
	{

		/// <summary> Capacitances are equal if they differ by less than a percentage of the first Capacitance </summary>
		/// <param name="capacitance1">first capacitance being compared</param>
		/// <param name="capacitance2">second capacitance being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Capacitance capacitance1, Capacitance capacitance2)
		{
			return (Math.Abs(capacitance1.GetValue(capacitance1.InternalUnitType) - (capacitance2).GetValue(capacitance1.InternalUnitType))) <= Math.Abs(capacitance1.GetValue( capacitance1.InternalUnitType) * CapacitanceDeviationDefaults.CapacitanceAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Capacitances are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="capacitance1">first capacitance being compared</param>
		/// <param name="capacitance2">second capacitance being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Capacitance capacitance1, Capacitance capacitance2)
		{
			return (Math.Abs(capacitance1.GetValue(capacitance1.InternalUnitType) - (capacitance2).GetValue(capacitance1.InternalUnitType))) <= CapacitanceDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(capacitance1.InternalUnitType);
		}
	}
}