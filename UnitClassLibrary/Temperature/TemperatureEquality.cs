using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="temperature1"></param>
	/// <param name="temperature2"></param>
	/// <returns></returns>
	public delegate bool TemperatureEqualityStrategy (Temperature temperature1, Temperature temperature2);

	public partial class Temperature
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Temperature temperature, Temperature passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Temperature)(temperature)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Temperature temperature, Temperature passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (temperature).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Temperature temperature, TemperatureEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, temperature);
		}
	}

	/// <summary> Default deviations allowed when comparing Temperature objects </summary>
	public static partial class TemperatureDeviationDefaults
	{

		/// <summary> When comparing two temperature and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Temperature AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Temperature(TemperatureType.Celsius, 1); }
		}

		/// <summary> When comparing two temperature and deviation is allowed to be within a percentage of the firstTemperature. This is that percentage </summary>
		public static double  TemperatureAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a temperature object's equals functions </summary>
	public static class TemperatureEqualityStrategyImplementations
	{

		/// <summary> Temperatures are equal if they differ by less than a percentage of the first Temperature </summary>
		/// <param name="temperature1">first temperature being compared</param>
		/// <param name="temperature2">second temperature being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Temperature temperature1, Temperature temperature2)
		{
			return (Math.Abs(temperature1.GetValue(temperature1.InternalUnitType) - (temperature2).GetValue(temperature1.InternalUnitType))) <= Math.Abs(temperature1.GetValue( temperature1.InternalUnitType) * TemperatureDeviationDefaults.TemperatureAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Temperatures are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="temperature1">first temperature being compared</param>
		/// <param name="temperature2">second temperature being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Temperature temperature1, Temperature temperature2)
		{
			return (Math.Abs(temperature1.GetValue(temperature1.InternalUnitType) - (temperature2).GetValue(temperature1.InternalUnitType))) <= TemperatureDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(temperature1.InternalUnitType);
		}
	}
}