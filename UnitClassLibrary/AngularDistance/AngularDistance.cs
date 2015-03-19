using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{
		#region _fields and Internal Properties

		internal AngularDistanceType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		public AngularDistanceType _internalUnitType;

        public double _intrinsicValue;

		public AngularDistanceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private AngularDistanceEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public AngularDistance(AngularDistanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = AngularDistanceType.Radian;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public AngularDistance(AngularDistanceType passedAngularDistanceType, double passedInput, AngularDistanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedAngularDistanceType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public AngularDistance(AngularDistance passedAngularDistance)
		{
			_intrinsicValue = passedAngularDistance._intrinsicValue;
			_internalUnitType = passedAngularDistance._internalUnitType;
			_equalityStrategy = passedAngularDistance._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static AngularDistanceEqualityStrategy _chooseDefaultOrPassedStrategy(AngularDistanceEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return AngularDistanceEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(AngularDistanceType toAngularDistanceType)
		{
			return ConvertAngularDistance(_internalUnitType, _intrinsicValue, toAngularDistanceType);
		}

		#endregion
	}
}