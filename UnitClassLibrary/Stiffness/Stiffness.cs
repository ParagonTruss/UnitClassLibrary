using System;

 namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		#region _fields and Internal Properties

		internal StiffnessType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private StiffnessType _internalUnitType;

		private double _intrinsicValue;

		public StiffnessEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private StiffnessEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Stiffness(StiffnessEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = StiffnessType.NewtonsPerMillimeter;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Stiffness(StiffnessType passedStiffnessType, double passedInput, StiffnessEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedStiffnessType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Stiffness(Stiffness passedStiffness)
		{
			_intrinsicValue = passedStiffness._intrinsicValue;
			_internalUnitType = passedStiffness._internalUnitType;
			_equalityStrategy = passedStiffness._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static StiffnessEqualityStrategy _chooseDefaultOrPassedStrategy(StiffnessEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return StiffnessEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType toStiffnessType)
		{
			return ConvertStiffness(_internalUnitType, _intrinsicValue, toStiffnessType);
		}

		#endregion
	}
}