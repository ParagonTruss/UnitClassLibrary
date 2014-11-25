using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Enum for specifying the type of unit a Mass is
    /// </summary>
    public enum MassType { MetricTons, Kilograms, Grams, Milligrams, Micrograms, LongTons, ShortTons, Stones, Pounds, Ounces };

    /// <summary>
    /// Class used for storing Masses that may need to be accessed in a different measurement system
    /// Will accept anything as input
    /// 
    /// For an explanation of why this class is immutable: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// decimal inches into AutoCAD notation
    /// 
    /// double grams = 24.1224
    /// Mass ms = new Mass( meters, MassTypes.Gram);
    /// 
    /// Print(ms.Architectural)
    /// 
    /// ========Output==========
    /// 
    /// 
    /// </example>
    /// </summary>
    public partial class Mass
    {
        #region _fields and Internal Properties
        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        internal MassType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private MassType _internalUnitType;

        /// <summary>
        /// The actual value of the stored unit. the 5 in "5 kilometers"
        /// </summary>
        private double _intrinsicValue;

        public MassEqualityStrategy EqualityStrategy
        {
            get { return _equalityStrategy; }
            set { _equalityStrategy = value; }
        }
        private MassEqualityStrategy _equalityStrategy;
        #endregion

        #region Constructors
        public Mass(MassEqualityStrategy passedStrategy = null)
        {
            _internalUnitType = MassType.Grams;
            _intrinsicValue = 0;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }
        public Mass(MassType passedMassType, double passedValue, MassEqualityStrategy passedStrategy = null)
        {
            _internalUnitType = passedMassType;
            _intrinsicValue = passedValue;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }
        #endregion

        #region helper _methods
        private static MassEqualityStrategy _chooseDefaultOrPassedStrategy(MassEqualityStrategy passedStrategy)
        {
            if (passedStrategy == null)
            {
                return MassEqualityStrategyImplementations.DefaultConstantEquality;
            }
            else
            {
                return passedStrategy;
            }
        }

        private double _retrieveIntrinsicValueAsDesiredExternalUnit(MassType toMassType)
        {
            return ConvertMass(_internalUnitType, _intrinsicValue, toMassType);
        }
        #endregion
    }
}
