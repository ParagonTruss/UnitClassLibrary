using System;
using System.Collections.Generic;
 
using System.Text;
using System.Diagnostics;


namespace UnitClassLibrary
{
    /// <summary>
    /// Class used for storing Distances that may need to be accessed in a different measurement system
    /// Will accept anything as input
    /// 
    /// For an explanation of why this class is immutable: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// decimal inches into AutoCAD notation
    /// 
    /// double inches = 14.1875
    /// Distance dm = new Distance( inches, DistanceTypes.Inch);
    /// 
    /// Print(dm.Architectural)
    /// 
    /// ========Output==========
    /// 1'2 3/16"
    /// 
    /// </example>
    /// </summary>
    public partial class Distance
    {
        #region _fields and Internal Properties

        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        internal DistanceType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private DistanceType _internalUnitType;

        /// <summary>
        /// The actual value of the stored unit. the 5 in "5 kilometers"
        /// </summary> 
        private double _intrinsicValue;

        /// <summary>
        /// The strategy by which this Distance will be compared to another Distance
        /// </summary>
        public DistanceEqualityStrategy EqualityStrategy
        {
            get { return _equalityStrategy; }
            set { _equalityStrategy = value; } 
        }
        private DistanceEqualityStrategy _equalityStrategy;
        #endregion

        #region Constructors

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Distance(DistanceEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = 0;
            _internalUnitType = DistanceType.Inch;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// Accepts any valid AutoCAD architectural string value for input.
        /// </summary>
        public Distance(string passedArchitecturalString, DistanceEqualityStrategy passedStrategy = null)
        {
            //we will always make the internal unit type of a passed String Inches 
            _internalUnitType = DistanceType.Inch;
            _intrinsicValue = _getArchitecturalStringAsNumberOfInches(passedArchitecturalString);
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// Accepts standard types for input.
        /// </summary>
        public Distance(DistanceType passedDistanceType, double passedInput, DistanceEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = passedInput;
            _internalUnitType = passedDistanceType;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// copy constructor - create a new Distance with the same fields as the passed Distance
        /// </summary>
        public Distance(Distance passedDistance)
        {
            _intrinsicValue = passedDistance._intrinsicValue;
            _internalUnitType = passedDistance._internalUnitType;
            _equalityStrategy = passedDistance._equalityStrategy;
        }

        #endregion

        #region helper _methods

        private static DistanceEqualityStrategy _chooseDefaultOrPassedStrategy(DistanceEqualityStrategy passedStrategy)
        {
            if (passedStrategy == null)
            {
                return EqualityStrategyImplementations.DefaultConstantEquality;
            }
            else
            {
                return passedStrategy;
            }
        }

        private static double _getArchitecturalStringAsNumberOfInches(string passedArchitecturalString)
        {
            return ConvertArchitectualStringtoUnit(DistanceType.Inch, passedArchitecturalString);
        }

        private double _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType toDistanceType)
        {
            return ConvertDistance(_internalUnitType, _intrinsicValue, toDistanceType);
        }

        private string _retrieveIntrinsicValueAsArchitecturalString()
        {
            return ConvertDistanceIntoArchitecturalString(this);
        }
        #endregion
    }
}
