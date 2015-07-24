using System;
using Newtonsoft.Json;

 namespace UnitClassLibrary
{
    [JsonObject(MemberSerialization.OptIn)]
	public partial class Force
	{
		#region _fields and Internal Properties

        
		internal ForceType InternalUnitType
		{
			get { return _internalUnitType; }
		}
        [JsonProperty]
		private ForceType _internalUnitType;

        [JsonProperty]
		private double _intrinsicValue;

		public ForceEqualityStrategy EqualityStrategy
		{
			get { return _equalityStrategy; }
			set { _equalityStrategy = value; }
		}

		private ForceEqualityStrategy _equalityStrategy;

		#endregion

		#region Constructors

		/// <summary> Zero Constructor </summary>
		 public Force(ForceEqualityStrategy passedStrategy = null)
		{
			_intrinsicValue = 0;
			_internalUnitType = ForceType.Pound;
			_intrinsicValue = 0;
		}

		/// <summary> Accepts standard types for input. </summary>
        [JsonConstructor]
		public Force(ForceType internalUnitType, double intrinsicValue, ForceEqualityStrategy passedStrategy = null)
		{
            if (Double.IsNaN(intrinsicValue))
            {
                throw new Exception("Unit value is Not a Number!");
            }
            _intrinsicValue = intrinsicValue;
            _internalUnitType = internalUnitType;
			_equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
		}

		/// <summary> Copy constructor (new unit with same fields as the passed) </summary>
		public Force(Force passedForce)
		{
			_intrinsicValue = passedForce._intrinsicValue;
			_internalUnitType = passedForce._internalUnitType;
			_equalityStrategy = passedForce._equalityStrategy;
		}

		#endregion

		#region helper _methods

		private static ForceEqualityStrategy _chooseDefaultOrPassedStrategy(ForceEqualityStrategy passedStrategy)
		{
			if (passedStrategy == null)
			{
				return ForceEqualityStrategyImplementations.DefaultConstantEquality;
			}
			else
			{
				return passedStrategy;
			}
		}

		private double _retrieveIntrinsicValueAsDesiredExternalUnit(ForceType toForceType)
		{
			return ConvertForce(_internalUnitType, _intrinsicValue, toForceType);
		}

		#endregion
	}
}