using System;

 namespace UnitClassLibrary
{

	public partial class Data
	{
		#region _fields and Internal Properties

		internal DataType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private DataType _internalUnitType;

		private double _intrinsicValue;

		public DataEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private DataEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Data(DataEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = DataType.Bit;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Data(DataType passedDataType, double passedInput, DataEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedDataType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Data(Data passedData)
		{
			_intrinsicValue = passedData._intrinsicValue;
			_internalUnitType = passedData._internalUnitType;
			_equalityStrategy = passedData._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static DataEqualityStrategy _chooseDefaultOrPassedStrategy(DataEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return DataEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(DataType toDataType)
		{
			return ConvertData(_internalUnitType, _intrinsicValue, toDataType);
		}

		#endregion
	}
}