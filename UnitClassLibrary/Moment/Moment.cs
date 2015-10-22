using Newtonsoft.Json;

namespace UnitClassLibrary
{

	public partial class Moment
	{
        #region _fields and Internal Properties

        public static readonly Moment Zero = 0 * NewtonsCentimeter;

		private Force _force;
		private Distance _distance;

        [JsonIgnore]
        public MomentEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private MomentEqualityStrategy _equalityStrategy;

        #endregion

        #region Constructors

        /// <summary>
        /// Null Constructor
        /// </summary>
        internal Moment() { }

		/// <summary> constructor that creates moment based on the passed units </summary>
		public Moment(Force passedForce, Distance passedDistance, MomentEqualityStrategy passedEqualityStrategy = null)
		{
			_force = passedForce;
			_distance = passedDistance;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedEqualityStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
        public Moment(MomentType passedMomentType, double passedValue, MomentEqualityStrategy passedEqualityStrategy = null)
		{
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedEqualityStrategy);

			switch (passedMomentType)
			{
			case MomentType.NewtonsMillimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case MomentType.NewtonsCentimeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case MomentType.NewtonsMeter:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case MomentType.NewtonsKilometer:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case MomentType.NewtonsInch:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case MomentType.NewtonsFoot:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case MomentType.NewtonsYard:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case MomentType.NewtonsMile:
				_force = new Force(ForceType.Newton, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
				break;
			case MomentType.PoundsMillimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case MomentType.PoundsCentimeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case MomentType.PoundsMeter:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case MomentType.PoundsKilometer:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case MomentType.PoundsInch:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case MomentType.PoundsFoot:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case MomentType.PoundsYard:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case MomentType.PoundsMile:
				_force = new Force(ForceType.Pound, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
				break;
			case MomentType.KipsMillimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Millimeter, 1);
				break;
			case MomentType.KipsCentimeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Centimeter, 1);
				break;
			case MomentType.KipsMeter:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Meter, 1);
				break;
			case MomentType.KipsKilometer:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Kilometer, 1);
				break;
			case MomentType.KipsInch:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Inch, 1);
				break;
			case MomentType.KipsFoot:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Foot, 1);
				break;
			case MomentType.KipsYard:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Yard, 1);
				break;
			case MomentType.KipsMile:
				_force = new Force(ForceType.Kip, passedValue);
				_distance = new Distance(DistanceType.Mile, 1);
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