using System;

 namespace UnitClassLibrary
{

	public partial class Moment
	{
		#region _fields and Internal Properties
		private Force _Force;
		private Distance _Distance;

		internal MomentType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private MomentType _internalUnitType;

		private double _intrinsicValue;

		public MomentEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private MomentEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Moment()
		{
			_Force = new Force();
			_Distance = new Distance();
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
		public Moment(Force passedForce, Distance passedDistance)
		{
			_Force = passedForce;
			_Distance = passedDistance;
		}

		/// <summary> Accepts standard types for input. </summary>
		public Moment(MomentType passedMomentType, double passedInput, MomentEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = passedInput;
			_internalUnitType = passedMomentType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Moment(Moment passedMoment)
		{
			_intrinsicValue = passedMoment._intrinsicValue;
			_internalUnitType = passedMoment._internalUnitType;
			_equalityStrategy = passedMoment._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static MomentEqualityStrategy _chooseDefaultOrPassedStrategy(MomentEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return MomentEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		#endregion
	}
}