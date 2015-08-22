namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{
		#region _fields and Internal Properties

		internal ElectricCurrentType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private ElectricCurrentType _internalUnitType;

		private double _intrinsicValue;

		public ElectricCurrentEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private ElectricCurrentEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public ElectricCurrent(ElectricCurrentEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = ElectricCurrentType.Ampere;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public ElectricCurrent(ElectricCurrentType passedElectricCurrentType, double passedInput, ElectricCurrentEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedElectricCurrentType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public ElectricCurrent(ElectricCurrent passedElectricCurrent)
		{
			_intrinsicValue = passedElectricCurrent._intrinsicValue;
			_internalUnitType = passedElectricCurrent._internalUnitType;
			_equalityStrategy = passedElectricCurrent._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static ElectricCurrentEqualityStrategy _chooseDefaultOrPassedStrategy(ElectricCurrentEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return ElectricCurrentEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricCurrentType toElectricCurrentType)
		{
			return ConvertElectricCurrent(_internalUnitType, _intrinsicValue, toElectricCurrentType);
		}

		#endregion
	}
}