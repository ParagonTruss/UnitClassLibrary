using System;

 namespace UnitClassLibrary
{

	public partial class DataTransferRate
	{
		#region _fields and Internal Properties
		private Data _Data;
		private Distance _Distance;

		internal DataTransferRateType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private DataTransferRateType _internalUnitType;

		private double _intrinsicValue;

		public DataTransferRateEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private DataTransferRateEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public DataTransferRate()
		{
			_Data = new Data();
			_Distance = new Distance();
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
		public DataTransferRate(Data passedData, Distance passedDistance)
		{
			_Data = passedData;
			_Distance = passedDistance;
		}

		/// <summary> Accepts standard types for input. </summary>
		public DataTransferRate(DataTransferRateType passedDataTransferRateType, double passedInput, DataTransferRateEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedDataTransferRateType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public DataTransferRate(DataTransferRate passedDataTransferRate)
		{
			_intrinsicValue = passedDataTransferRate._intrinsicValue;
			_internalUnitType = passedDataTransferRate._internalUnitType;
			_equalityStrategy = passedDataTransferRate._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static DataTransferRateEqualityStrategy _chooseDefaultOrPassedStrategy(DataTransferRateEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return DataTransferRateEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		#endregion
	}
}