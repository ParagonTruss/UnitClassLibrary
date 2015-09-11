namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		#region _fields and Internal Properties
		private Force _force;
		private Distance _distance;

		internal StiffnessType InternalUnitType
		{
			get { return _internalUnitType; }
		}
		private StiffnessType _internalUnitType;

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
			_force = new Force();
			_distance = Distance.Zero;
            _chooseDefaultOrPassedStrategy(passedStrategy);

		}

		/// <summary> constructor that creates moment based on the passed units </summary>
        public Stiffness(Force passedForce, Distance passedDistance, StiffnessEqualityStrategy passedStrategy = null)
		{
			_force = passedForce;
			_distance = passedDistance;
            _chooseDefaultOrPassedStrategy(passedStrategy);

		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Stiffness(StiffnessType passedStiffnessType, double passedValue)
		{
			switch (passedStiffnessType)
			{
			case StiffnessType.NewtonsPerMillimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case StiffnessType.NewtonsPerCentimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case StiffnessType.NewtonsPerMeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case StiffnessType.NewtonsPerKilometer:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case StiffnessType.NewtonsPerInch:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case StiffnessType.NewtonsPerFoot:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case StiffnessType.NewtonsPerYard:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case StiffnessType.NewtonsPerMile:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
				break;
			case StiffnessType.PoundsPerMillimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case StiffnessType.PoundsPerCentimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case StiffnessType.PoundsPerMeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case StiffnessType.PoundsPerKilometer:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case StiffnessType.PoundsPerInch:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case StiffnessType.PoundsPerFoot:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case StiffnessType.PoundsPerYard:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case StiffnessType.PoundsPerMile:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
				break;
			case StiffnessType.KipsPerMillimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case StiffnessType.KipsPerCentimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case StiffnessType.KipsPerMeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case StiffnessType.KipsPerKilometer:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case StiffnessType.KipsPerInch:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case StiffnessType.KipsPerFoot:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case StiffnessType.KipsPerYard:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case StiffnessType.KipsPerMile:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
				break;
			}
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

		#endregion
	}
}