using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{
		#region _fields and Internal Properties

		internal AngleType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private AngleType _internalUnitType;

		private double _intrinsicValue;

		public AngleEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private AngleEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Angle(AngleEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = AngleType.Degree;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Angle(AngleType passedAngleType, double passedInput, AngleEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedAngleType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Angle(Angle passedAngle)
		{
			_intrinsicValue = passedAngle._intrinsicValue;
			_internalUnitType = passedAngle._internalUnitType;
			_equalityStrategy = passedAngle._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static AngleEqualityStrategy _chooseDefaultOrPassedStrategy(AngleEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return AngleEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType toAngleType)
		{
			return ConvertAngle(_internalUnitType, _intrinsicValue, toAngleType);
		}
		
		        /// <summary>
        /// Finds the angle that points 180 degrees from this one
        /// </summary>
        /// <returns>Angle 180 degrees from this one</returns>
        public Angle Reverse()
        {
            return this - new Angle(AngleType.Degree, 180);
        }


		#endregion
	}
}