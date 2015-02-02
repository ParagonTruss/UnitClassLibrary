using System;
using System.Collections.Generic;
 
using System.Text;
using System.Diagnostics;


namespace UnitClassLibrary
{
    /// <summary>
    /// Class used for storing Brokens that may need to be accessed in a different measurement system
    /// Will accept anything as input
    /// 
    /// For an explanation of why this class is immutable: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// decimal inches into AutoCAD notation
    /// 
    /// double inches = 14.1875
    /// Broken dm = new Broken( inches, BrokenTypes.Inch);
    /// 
    /// Print(dm.Architectural)
    /// 
    /// ========Output==========
    /// 1'2 3/16"
    /// 
    /// </example>
    /// </summary>
    public partial class Broken
    {
        #region _fields and Internal Properties

        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        internal BrokenType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private BrokenType _internalUnitType;

        /// <summary>
        /// The actual value of the stored unit. the 5 in "5 kilometers"
        /// </summary> 
        private double _intrinsicValue;

        /// <summary>
        /// The strategy by which this Broken will be compared to another Broken
        /// </summary>
        public BrokenEqualityStrategy EqualityStrategy
        {
            get { return _equalityStrategy; }
            set { _equalityStrategy = value; } 
        }
        private BrokenEqualityStrategy _equalityStrategy;
        #endregion

        #region Constructors

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Broken(BrokenEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = 0;
            _internalUnitType = BrokenType.Inch;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// Accepts any valid AutoCAD architectural string value for input.
        /// </summary>
        public Broken(string passedArchitecturalString, BrokenEqualityStrategy passedStrategy = null)
        {
            //we will always make the internal unit type of a passed String Inches 
            _internalUnitType = BrokenType.Inch;
            _intrinsicValue = _getArchitecturalStringAsNumberOfInches(passedArchitecturalString);
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// Accepts standard types for input.
        /// </summary>
        public Broken(BrokenType passedBrokenType, double passedInput, BrokenEqualityStrategy passedStrategy = null)
        {
            _intrinsicValue = passedInput;
            _internalUnitType = passedBrokenType;
            _equalityStrategy = _chooseDefaultOrPassedStrategy(passedStrategy);
        }

        /// <summary>
        /// copy constructor - create a new Broken with the same fields as the passed Broken
        /// </summary>
        public Broken(Broken passedBroken)
        {
            _intrinsicValue = passedBroken._intrinsicValue;
            _internalUnitType = passedBroken._internalUnitType;
            _equalityStrategy = passedBroken._equalityStrategy;
        }

        #endregion

        #region helper _methods

        private static BrokenEqualityStrategy _chooseDefaultOrPassedStrategy(BrokenEqualityStrategy passedStrategy)
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
            return ConvertArchitectualStringtoUnit(BrokenType.Inch, passedArchitecturalString);
        }

        private double _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType toBrokenType)
        {
            return ConvertBroken(_internalUnitType, _intrinsicValue, toBrokenType);
        }

        private string _retrieveIntrinsicValueAsArchitecturalString()
        {
            return ConvertBrokenIntoArchitecturalString(this);
        }
        #endregion
    }
}
