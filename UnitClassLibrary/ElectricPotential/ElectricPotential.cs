namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{
		#region _fields and Internal Properties

		internal ElectricPotentialType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private ElectricPotentialType _internalUnitType;

		private double _intrinsicValue;

		public ElectricPotentialEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private ElectricPotentialEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public ElectricPotential(ElectricPotentialEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = ElectricPotentialType.Microvolt;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public ElectricPotential(ElectricPotentialType passedElectricPotentialType, double passedInput, ElectricPotentialEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedElectricPotentialType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public ElectricPotential(ElectricPotential passedElectricPotential)
		{
			_intrinsicValue = passedElectricPotential._intrinsicValue;
			_internalUnitType = passedElectricPotential._internalUnitType;
			_equalityStrategy = passedElectricPotential._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static ElectricPotentialEqualityStrategy _chooseDefaultOrPassedStrategy(ElectricPotentialEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return ElectricPotentialEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType toElectricPotentialType)
		{
			return ConvertElectricPotential(_internalUnitType, _intrinsicValue, toElectricPotentialType);
		}

		#endregion
	}
}