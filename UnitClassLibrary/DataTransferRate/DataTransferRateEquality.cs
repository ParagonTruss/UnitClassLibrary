using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="datatransferrate1"></param>
	/// <param name="datatransferrate2"></param>
	/// <returns></returns>
	public delegate bool DataTransferRateEqualityStrategy (DataTransferRate datatransferrate1, DataTransferRate datatransferrate2);

	public partial class DataTransferRate
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(DataTransferRate datatransferrate, DataTransferRate passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(this._internalUnitType)
				- ((DataTransferRate)(datatransferrate)).GetValue(this._internalUnitType))
				))
				<= passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(DataTransferRate datatransferrate, DataTransferRate passedAcceptedEqualityDeviationPercentage)
		{
			return (Math.Abs(this.GetValue(this.InternalUnitType) - (datatransferrate).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(DataTransferRate datatransferrate, DataTransferRateEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, datatransferrate);
		}
	}

	/// <summary> Default deviations allowed when comparing DataTransferRate objects </summary>
	public static partial class DataTransferRateDeviationDefaults
	{

		/// <summary> When comparing two datatransferrate and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static DataTransferRate AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new DataTransferRate(DataTransferRateType.BitsPerNanosecond, 1); }
		}

		/// <summary> When comparing two datatransferrate and deviation is allowed to be within a percentage of the firstDataTransferRate. This is that percentage </summary>
		public static double  DataTransferRateAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a datatransferrate object's equals functions </summary>
	public static class DataTransferRateEqualityStrategyImplementations
	{

		/// <summary> DataTransferRates are equal if they differ by less than a percentage of the first DataTransferRate </summary>
		/// <param name="datatransferrate1">first datatransferrate being compared</param>
		/// <param name="datatransferrate2">second datatransferrate being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (DataTransferRate datatransferrate1, DataTransferRate datatransferrate2)
		{
			return (Math.Abs(datatransferrate1.GetValue(datatransferrate1.InternalUnitType) - (datatransferrate2).GetValue(datatransferrate1.InternalUnitType))) <= Math.Abs(datatransferrate1.GetValue( datatransferrate1.InternalUnitType) * DataTransferRateDeviationDefaults.DataTransferRateAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> DataTransferRates are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="datatransferrate1">first datatransferrate being compared</param>
		/// <param name="datatransferrate2">second datatransferrate being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (DataTransferRate datatransferrate1, DataTransferRate datatransferrate2)
		{
			return (Math.Abs(datatransferrate1.GetValue(datatransferrate1.InternalUnitType) - (datatransferrate2).GetValue(datatransferrate1.InternalUnitType))) <= DataTransferRateDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(datatransferrate1.InternalUnitType);
		}
	}
}