using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace UnitClassLibrary
{
    /// <summary>
    /// Class used for storing dimensions that may need to be accessed in a different measurement system
    /// Will accept anything as input
    /// 
    /// For an explanation of why this class is immutable: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// decimal inches into AutoCAD notation
    /// 
    /// double inches = 14.1875
    /// Dimension dm = new Dimension( inches, DimensionTypes.Inch);
    /// 
    /// Print(dm.Architectural)
    /// 
    /// ========Output==========
    /// 1'2 3/16"
    /// 
    /// </example>
    /// </summary>
    
    /// <summary>
    /// Enum for specifying the type of unit a dimension is
    /// </summary>
    public enum DimensionType { Inch, Millimeter, Centimeter, Meter, Kilometer, ThirtySecond, Sixteenth, Foot, Yard, Mile, ArchitecturalString };

    [DebuggerDisplay("Inches = {Inches}")]
    public partial struct Dimension
    {
        #region private _fields and Internal Properties

        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        internal DimensionType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private DimensionType _internalUnitType;

        private double _intrinsicValue;

        #endregion

        #region Constructors

        /// <summary>
        /// Accepts any valid AutoCAD architectural string value for input.
        /// </summary>
        public Dimension(string passedArchitecturalString)
        {
            //we will always make the internal unit type of a passed String Inches 

            _internalUnitType = DimensionType.Inch;
            _intrinsicValue = _architecturalStringAsInches(passedArchitecturalString);
        }

        /// <summary>
        /// Accepts standard types for input.
        /// </summary>
        public Dimension(DimensionType passedDimensionType, double passedInput)
        {
            _intrinsicValue = passedInput;
            _internalUnitType = passedDimensionType;
        }

        /// <summary>
        /// copy constructor - create a new Dimension with the same _intrinsicValue as the passed Dimension
        /// </summary>
        public Dimension(Dimension passedDimension)
        {
            _intrinsicValue = passedDimension._intrinsicValue;
            _internalUnitType = passedDimension._internalUnitType;
        }

        #endregion

        #region helper methods

        private static double _architecturalStringAsInches(string passedArchitecturalString)
        {
            return ConvertArchitectualStringtoUnit(DimensionType.Inch, passedArchitecturalString);
        }

        private double _retrieveAsExternalUnit(DimensionType toDimensionType)
        {
            return ConvertDimension(_internalUnitType, _intrinsicValue, toDimensionType);
        }

        private string _retrieveInternalUnitAsArchitecturalString()
        {
            return ConvertDimensionIntoArchitecturalString(this);
        }
        #endregion
    }
}
