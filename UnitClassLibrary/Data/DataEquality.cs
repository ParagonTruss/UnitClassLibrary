using System;

 namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="data1"></param>
	/// <param name="data2"></param>
	/// <returns></returns>
	public delegate bool DataEqualityStrategy (Data data1, Data data2);

	public partial class Data
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Data data, Data passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((Data)(data)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Data data, Data passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (data).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Data data, DataEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, data);
		}
	}

	/// <summary> Default deviations allowed when comparing Data objects </summary>
	public static partial class DataDeviationDefaults
	{

		/// <summary> When comparing two data and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Data AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Data(DataType.Bit, 1); }
		}

		/// <summary> When comparing two data and deviation is allowed to be within a percentage of the firstData. This is that percentage </summary>
		public static double  DataAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a data object's equals functions </summary>
	public static class DataEqualityStrategyImplementations
	{

		/// <summary> Datas are equal if they differ by less than a percentage of the first Data </summary>
		/// <param name="data1">first data being compared</param>
		/// <param name="data2">second data being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Data data1, Data data2)
		{
			return (Math.Abs(data1.GetValue(data1.InternalUnitType) - (data2).GetValue(data1.InternalUnitType))) <= Math.Abs(data1.GetValue( data1.InternalUnitType) * DataDeviationDefaults.DataAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Datas are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="data1">first data being compared</param>
		/// <param name="data2">second data being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Data data1, Data data2)
		{
			return (Math.Abs(data1.GetValue(data1.InternalUnitType) - (data2).GetValue(data1.InternalUnitType))) <= DataDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(data1.InternalUnitType);
		}
	}
}