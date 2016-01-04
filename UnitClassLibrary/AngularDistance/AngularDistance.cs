using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UnitClassLibrary
{
    [JsonObject(MemberSerialization.OptIn)]
	public partial class AngularDistance
    {
        #region _fields and Internal Properties

        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public AngleType InternalUnitType
		{
			get { return _internalUnitType; }
            private set { _internalUnitType = value; }
		}
        protected AngleType _internalUnitType;

        [JsonProperty]
        public double IntrinsicValue
        {
            get { return _intrinsicValue; }
            private set { _intrinsicValue = value; }
        }
        protected double _intrinsicValue;

		public AngularDistanceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		public AngularDistanceEqualityStrategy _equalityStrategy;

        #endregion

        #region Constructors

        /// <summary>
        /// Null Constructor
        /// </summary>
        protected AngularDistance() { }

		/// <summary> Accepts standard types for input. </summary>
        [JsonConstructor]
		public AngularDistance(AngleType internalUnitType, double intrinsicValue, AngularDistanceEqualityStrategy passedStrategy = null)
		{
            _intrinsicValue = intrinsicValue;
            _internalUnitType = internalUnitType;
            _equalityStrategy = _DefaultOrPassedStrategy(passedStrategy);
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

		protected static AngularDistanceEqualityStrategy _DefaultOrPassedStrategy(AngularDistanceEqualityStrategy passedStrategy)
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
	}
}