namespace UnitClassLibrary
{

	public partial class Energy
	{
		#region _fields and Internal Properties

		internal EnergyType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private EnergyType _internalUnitType;

		private double _intrinsicValue;

		public EnergyEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private EnergyEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Energy(EnergyEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = EnergyType.Calorie;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Energy(EnergyType passedEnergyType, double passedInput, EnergyEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedEnergyType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Energy(Energy passedEnergy)
		{
			_intrinsicValue = passedEnergy._intrinsicValue;
			_internalUnitType = passedEnergy._internalUnitType;
			_equalityStrategy = passedEnergy._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static EnergyEqualityStrategy _chooseDefaultOrPassedStrategy(EnergyEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return EnergyEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType toEnergyType)
		{
			return ConvertEnergy(_internalUnitType, _intrinsicValue, toEnergyType);
		}

		#endregion
	}
}