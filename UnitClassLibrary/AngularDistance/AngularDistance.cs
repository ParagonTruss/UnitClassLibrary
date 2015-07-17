using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{
		#region _fields and Internal Properties

		internal AngleType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		public AngleType _internalUnitType;

        public double _intrinsicValue;

		public AngularDistanceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		public AngularDistanceEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public AngularDistance(AngularDistanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
            _internalUnitType = AngleType.Radian;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Accepts standard types for input. </summary>
		public AngularDistance(AngleType passedAngleType, double passedInput, AngularDistanceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedAngleType;
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

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType toAngleType)
		{
			return ConvertAngularDistance(_internalUnitType, _intrinsicValue, toAngleType);
		}

		#endregion

        public static AngularDistance operator %(AngularDistance angle1, AngularDistance angle2)
        {
            return new AngularDistance(angle1._internalUnitType, angle1.GetValue(angle1._internalUnitType) % angle2.GetValue(angle1._internalUnitType));
        }
	}
}