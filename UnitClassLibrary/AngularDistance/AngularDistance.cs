using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitClassLibrary
{
    [JsonObject(MemberSerialization.OptIn)]
	public partial class AngularDistance
    {
        #region _fields and Internal Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DatabaseId { get; set; }

        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumDataType(typeof(AngleType))]
        internal AngleType InternalUnitType
		{
			get { return _internalUnitType; }
		}
        protected AngleType _internalUnitType;

        [JsonProperty(PropertyName="intrinsicValue")]
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
        [JsonConstructor]
		public AngularDistance(AngleType internalUnitType, double intrinsicValue, AngularDistanceEqualityStrategy passedStrategy = null)
		{
            _intrinsicValue = intrinsicValue;
            _internalUnitType = internalUnitType;
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
	}
}