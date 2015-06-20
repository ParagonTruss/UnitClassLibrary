using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Xml.Serialization;

namespace UnitClassLibrary
{
    /// <summary>
    /// Class used for storing Distances that may need to be accessed in a different measurement system
    /// 
    /// For an explanation of why this class is immutable: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// decimal inches into architectural notation
    /// 
    /// double inches = 14.1875
    /// Distance dm = new Distance(DistanceTypes.Inch, inches);
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
        [XmlIgnore]
        public DistanceEqualityStrategy EqualityStrategy
        {
            get { return _equalityStrategy; }
            set { _equalityStrategy = value; } 
        }
        private DistanceEqualityStrategy _equalityStrategy;

        #endregion

        #region Constructors
        /// <summary>
        /// Parameterless constructor for XML Serialization
        /// </summary>
        public Distance()
        {

        }

        /// <summary>
        /// Zero Constructor
        /// </summary>
        /// <param name="passedStrategy">Strategy to compare equality by</param>
        public Distance(DistanceEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = 0;
            _internalUnitType = DistanceType.Inch;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// Accepts any valid architectural string value for input
        /// </summary>
        /// <param name="passedArchitecturalString"> Architecturally formatted string to create distance from</param>
        /// <param name="passedStrategy">Strategy to compare equality by</param>
        public Distance(string passedArchitecturalString, DistanceEqualityStrategy passedStrategy = null)
        {
            //we will always make the internal unit type of a passed String Inches 
            _internalUnitType = DistanceType.Inch;
            _intrinsicValue = _getArchitecturalStringAsNumberOfInches(passedArchitecturalString);
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// The standard Unit Constructor that takes the value and the unit type that describes it.
        /// </summary>
        /// <param name="passedDistanceType">The unit of distance the input is in</param>
        /// <param name="passedInput">value of the distance</param>
        /// <param name="passedStrategy">Strategy to compare equality by</param>
        public Distance(DistanceType passedDistanceType, double passedInput, DistanceEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = passedInput;
            _internalUnitType = passedDistanceType;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="passedDistance">Distance objet to copy</param>
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
