using System;

 namespace UnitClassLibrary
{

	public partial class Moment
	{
		#region _fields and Internal Properties
		private Force _force;
		private Distance _distance;

		internal MomentType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private MomentType _internalUnitType;

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
			_force = new Force();
			_distance = new Distance();
		}

		/// <summary> constructor that creates moment based on the passed units </summary>
		public Moment(Force passedForce, Distance passedDistance)
		{
			_force = passedForce;
			_distance = passedDistance;
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Moment(MomentType passedMomentType, double passedValue)
		{
			switch (passedMomentType)
			{
			case MomentType.NewtonsMillimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Millimeter, passedValue);
				break;
			case MomentType.NewtonsCentimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Centimeter, passedValue);
				break;
			case MomentType.NewtonsMeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Meter, passedValue);
				break;
			case MomentType.NewtonsKilometer:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Kilometer, passedValue);
				break;
			case MomentType.NewtonsInch:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Inch, passedValue);
				break;
			case MomentType.NewtonsFoot:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Foot, passedValue);
				break;
			case MomentType.NewtonsYard:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Yard, passedValue);
				break;
			case MomentType.NewtonsMile:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Mile, passedValue);
				break;
			case MomentType.PoundsMillimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Millimeter, passedValue);
				break;
			case MomentType.PoundsCentimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Centimeter, passedValue);
				break;
			case MomentType.PoundsMeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Meter, passedValue);
				break;
			case MomentType.PoundsKilometer:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Kilometer, passedValue);
				break;
			case MomentType.PoundsInch:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Inch, passedValue);
				break;
			case MomentType.PoundsFoot:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Foot, passedValue);
				break;
			case MomentType.PoundsYard:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Yard, passedValue);
				break;
			case MomentType.PoundsMile:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Mile, passedValue);
				break;
			case MomentType.KipsMillimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Millimeter, passedValue);
				break;
			case MomentType.KipsCentimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Centimeter, passedValue);
				break;
			case MomentType.KipsMeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Meter, passedValue);
				break;
			case MomentType.KipsKilometer:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Kilometer, passedValue);
				break;
			case MomentType.KipsInch:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Inch, passedValue);
				break;
			case MomentType.KipsFoot:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Foot, passedValue);
				break;
			case MomentType.KipsYard:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Yard, passedValue);
				break;
			case MomentType.KipsMile:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Mile, passedValue);
				break;
			}
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