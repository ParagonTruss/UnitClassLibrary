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
    /// For an explanation of why this class is immutatble: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
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
    [DebuggerDisplay("Millimeters = {Millimeters}")]
    public class Dimension : IComparable<Dimension>
    {
        #region private fields and constants
        //internal Dimension type is set to millimeter to cause the least amount of rounding error when performing calculations.
        const DimensionType InternalUnitType = DimensionType.Millimeter;

        //dimension value
        private double _intrinsicValue = 0.0;

        #endregion

        #region Constructors

        /// <summary>
        /// Accepts any valid AutoCAD architectural string value for input.
        /// </summary>
        public Dimension(string passedArchitecturalString)
        {
             storeArchitecturalStringAsInternalUnit(passedArchitecturalString);
        }

        /// <summary>
        /// Accepts standard types for input.
        /// </summary>
        public Dimension(DimensionType passedDimensionType, double passedInput)
        {
            storeAsInternalUnit(passedDimensionType, passedInput);
        }

        /// <summary>
        /// copy constructor - create a new Dimension with the same _intrinsicValue as the passed Dimension
        /// </summary>
        public Dimension(Dimension passedDimension)
        {
            _intrinsicValue = passedDimension._intrinsicValue;
        }

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Dimension()
        {
            _intrinsicValue = 0;
        }

        #endregion

        #region Properties

        public double Sixteenths
        {
            get { return retrieveAsExternalUnit(DimensionType.Sixteenth); }
        }

        public double ThirtySeconds
        {
            get { return retrieveAsExternalUnit(DimensionType.ThirtySecond); }
        }

        public double Inches
        {
            get { return retrieveAsExternalUnit(DimensionType.Inch); }
        }

        public double Feet
        {
            get { return retrieveAsExternalUnit(DimensionType.Foot); }
        }

        public double Yards
        {
            get { return retrieveAsExternalUnit(DimensionType.Yard); }
        }

        public double Miles
        {
            get { return retrieveAsExternalUnit(DimensionType.Mile); }
        }

        public double Millimeters
        {
            get { return retrieveAsExternalUnit(DimensionType.Millimeter); }
        }

        public double Centimeters
        {
            get { return retrieveAsExternalUnit(DimensionType.Centimeter); }
        }

        public double Meters
        {
            get { return retrieveAsExternalUnit(DimensionType.Meter); }
        }

        public double Kilometers
        {
            get { return retrieveAsExternalUnit(DimensionType.Kilometer); }
        }

        /// <summary>
        /// Returns the dimension as a string in AutoCAD notation with sixteenths of an inch percision
        /// </summary>
        public string Architectural
        {
            get { return retrieveInternalUnitAsArchitecturalString(); }
        }

        public double GetValue(DimensionType Units)
        {
            switch (Units)
            {
                case DimensionType.Millimeter:
                    return Millimeters;
                case DimensionType.Centimeter:
                    return Centimeters;
                case DimensionType.Meter:
                    return Meters;
                case DimensionType.Kilometer:
                    return Kilometers;
                case DimensionType.ThirtySecond:
                    return ThirtySeconds;
                case DimensionType.Sixteenth:
                    return Sixteenths;
                case DimensionType.Inch:
                    return Inches;
                case DimensionType.Foot:
                    return Feet;
                case DimensionType.Yard:
                    return Yards;
                case DimensionType.Mile:
                    return Miles;
                case DimensionType.ArchitecturalString:
                    throw new Exception("Cannot return a double value from architectural string");
            }
            throw new Exception("Unknown DimensionType");
        }

        #endregion

        #region helper methods

        private void storeAsInternalUnit(DimensionType fromDimensionType, double passedValue)
        {
            _intrinsicValue = ConvertDimension( fromDimensionType, passedValue, InternalUnitType);
        }

        private void storeArchitecturalStringAsInternalUnit(string passedArchitecturalString)
        {
            _intrinsicValue = ConvertDimension(InternalUnitType, passedArchitecturalString);
        }

        private double retrieveAsExternalUnit(DimensionType toDimensionType)
        {
            return ConvertDimension(InternalUnitType, _intrinsicValue, toDimensionType);
        }

        private string retrieveInternalUnitAsArchitecturalString()
        {
            return ConvertDimensionIntoArchitecturalString(InternalUnitType, _intrinsicValue);
        }

        #region Actual Conversion Code
        /// <summary>
        /// Converts any possible type of Architectual String into internal units
        /// <remarks>Throws FormatException on bad input</remarks>
        /// </summary>
        /// <param name="passedArchitecturalString">the input string</param>
        /// <returns>decimal Millimeters</returns>
        private static Double ConvertArchitectualStringtoInternalUnits(String passedArchitecturalString)
        {
            // for details on where this solution came from, check here: http://stackoverflow.com/questions/22794466/parsing-all-possible-types-of-varying-architectural-dimension-input
            // answer by Trygve Flathen: http://stackoverflow.com/users/2795177/trygve-flathen

            //trim the input
            passedArchitecturalString = passedArchitecturalString.Trim();

            //define the regular expression (witchcraft)
            String expression = "^\\s*(?<minus>-)?\\s*(((?<feet>\\d+)(?<inch>\\d{2})(?<sixt>\\d{2}))|((?<feet>[\\d.]+)')?[\\s-]*((?<inch>\\d+)?[\\s-]*((?<numer>\\d+)/(?<denom>\\d+))?\")?)\\s*$";

            //find out what strings match 
            Match match = new Regex(expression).Match(passedArchitecturalString);

            //test for failure cases
            if (!match.Success || passedArchitecturalString == "" || passedArchitecturalString == "\"")
            {
                throw new FormatException("Input was not a valid architectural string");
            }

            //parse the results
            Int32 sign = match.Groups["minus"].Success ? -1 : 1;
            Double feet = match.Groups["feet"].Success ? Convert.ToDouble(match.Groups["feet"].Value) : 0;
            Int32 inch = match.Groups["inch"].Success ? Convert.ToInt32(match.Groups["inch"].Value) : 0;
            Int32 sixt = match.Groups["sixt"].Success ? Convert.ToInt32(match.Groups["sixt"].Value) : 0;
            Int32 numer = match.Groups["numer"].Success ? Convert.ToInt32(match.Groups["numer"].Value) : 0;
            Int32 denom = match.Groups["denom"].Success ? Convert.ToInt32(match.Groups["denom"].Value) : 1;

            //combine the results
            double result = sign * (feet * 12 + inch + sixt / 16.0 + numer / Convert.ToDouble(denom));

            return ConvertDimension(DimensionType.Inch, result, DimensionType.Millimeter);
        }

        /// <summary>
        /// Returns a string formatted in a standard AutoCAD format
        /// </summary>
        /// <param name="millimeters"> the millimeters being converted into a string</param>
        /// <returns></returns>
        private static string ConvertMillimetersToArchitecturalString(double millimeters, int precision = 16)
        {
            //Convert into inches before proceeding
            double workingValue = ConvertDimension(DimensionType.Millimeter, millimeters, DimensionType.Inch);

            //detect need for sign
            string sign = "";
            if (workingValue < 0)
            {
                sign = "-";

                //if it is negative, then make it positive for the rest of the calculations
                workingValue = workingValue * -1;
            }

            //get number of whole feet contained in inches by rounding down after calculation
            double feet = Math.Floor(workingValue / 12);

            //remove whole feet from inches
            workingValue = workingValue - (feet * 12);

            //save whole inches now that they are the largest unit
            double inches = Math.Floor(workingValue);

            //remove whole inches from working value, leaving only a fraction
            workingValue = workingValue - inches;

            double numerator = Math.Round(workingValue * precision);

            //handles the case where the leftover fraction is rounded up to a whole inch
            if (numerator == precision)
            {
                numerator = 0;

                //handles the case where the rounded up inches is equal to 12
                inches++;
                if (inches == 12)
                {
                    feet++;
                    inches = 0;
                }
                numerator = 0;
            }

            //if there is no leftover fraction then make the fractionString empty
            string fractionString = (numerator == 0) ? "" : numerator + "/" + precision.ToString();

            //if the value is less than a foot then make the feetString empty
            string feetString = (feet == 0) ? "" : feet.ToString();

            //if the value is less than a inches then make the inchesString empty
            string inchesString = (inches == 0) ? "" : inches.ToString();

            //if all valuse are present, insert both symbols
            string inchesSymbol = "\"";
            string feetSymbol = "'";

            //if the value is an even footage make the inchesSymbol empty
            if (fractionString == "" && inchesString == "")
            {
                inchesSymbol = "";
            }

            //if the feetString is empty make the feetSymbol empty
            if (feetString == "")
            {
                feetSymbol = "";
            }

            //add and return all of the strings together, the only addition is a space that will be trimmed if there is no fraction
            return (sign + feetString + feetSymbol + inchesString + " " + fractionString).Trim() + inchesSymbol;
        }

        /// <summary>
        /// Converts any dimension into another
        /// </summary>
        /// <param name="typeConvertingTo">input unit type</param>
        /// <param name="typeConvertingFrom">desired output unit type</param>
        /// <returns>converted dimension</returns>
        public static double ConvertDimension(DimensionType typeConvertingFrom, double passedValue, DimensionType typeConvertingTo)
        {
            double returnDouble = 0.0;
            double internalDecimalMillimeters = 0.0;

            //first convert value passedValue to inches
            switch (typeConvertingFrom)
            {
                case DimensionType.ThirtySecond:
                    internalDecimalMillimeters = (passedValue / 32) * 0.0393701;
                    break;
                case DimensionType.Sixteenth:
                    internalDecimalMillimeters = (passedValue / 16) * 0.0393701;
                    break;
                case DimensionType.Inch:
                    internalDecimalMillimeters = passedValue * 25.4;
                    break;
                case DimensionType.Foot:
                    internalDecimalMillimeters = passedValue * 304.8;
                    break;
                case DimensionType.Yard:
                    internalDecimalMillimeters = passedValue * 914.4;
                    break;
                case DimensionType.Mile:
                    internalDecimalMillimeters = passedValue * 1609344;
                    break;
                case DimensionType.Millimeter:
                    internalDecimalMillimeters = passedValue;
                    break;
                case DimensionType.Centimeter:
                    internalDecimalMillimeters = passedValue * 10;
                    break;
                case DimensionType.Meter:
                    internalDecimalMillimeters = passedValue * 1000;
                    break;
                case DimensionType.Kilometer:
                    internalDecimalMillimeters = passedValue * 1000000;
                    break;
            }

            //Now convert the value from inches to the desired output
            switch (typeConvertingTo)
            {
                case DimensionType.ThirtySecond:
                    returnDouble = (internalDecimalMillimeters / 0.0393701) * 32;
                    break;
                case DimensionType.Sixteenth:
                    returnDouble = (internalDecimalMillimeters / 0.0393701) * 16;
                    break;
                case DimensionType.Inch:
                    returnDouble = internalDecimalMillimeters / 25.4;
                    break;
                case DimensionType.Foot:
                    returnDouble = internalDecimalMillimeters / 304.8;
                    break;
                case DimensionType.Yard:
                    returnDouble = internalDecimalMillimeters / 914.4;
                    break;
                case DimensionType.Mile:
                    returnDouble = internalDecimalMillimeters / 1609344;
                    break;
                case DimensionType.Millimeter:
                    returnDouble = internalDecimalMillimeters;
                    break;
                case DimensionType.Centimeter:
                    returnDouble = internalDecimalMillimeters / 10;
                    break;
                case DimensionType.Meter:
                    returnDouble = internalDecimalMillimeters / 1000;
                    break;
                case DimensionType.Kilometer:
                    returnDouble = internalDecimalMillimeters / 1000000;
                    break;
            }

            return returnDouble;
        }

        /// <summary>
        /// Converts Architectural strings into a decimal unit
        /// </summary>
        public static double ConvertDimension(DimensionType typeConvertingTo, string passedValue)
        {
            //first convert value passedValue to millimeters
            double internalUnits = ConvertArchitectualStringtoInternalUnits(passedValue);

            //Now convert the value from millimeters to the desired output
            return ConvertDimension(DimensionType.Millimeter, internalUnits, typeConvertingTo);
        }

        /// <summary>
        /// Converts any dimension into an architectural string representation
        /// </summary>
        /// <param name="typeConvertingFrom">desired output unit type</param>
        /// <returns>converted dimension</returns>
        public static string ConvertDimensionIntoArchitecturalString(DimensionType typeConvertingFrom, double passedValue)
        {
            //first convert value passedValue to millimeters
            double internalDecimalMillimeters = ConvertDimension(DimensionType.Millimeter, passedValue, typeConvertingFrom);

            //Now convert the value from millimeters to the desired output
            return ConvertMillimetersToArchitecturalString(internalDecimalMillimeters);
        }
        
        #endregion
        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Dimension operator +(Dimension d1, Dimension d2)
        {
            //add the two dimensions together
            //return a new dimension with the new value
            return new Dimension(InternalUnitType, (d1._intrinsicValue + d2._intrinsicValue));
        }

        public static Dimension operator -(Dimension d1, Dimension d2)
        {
            //subtract the two dimensions
            //return a new dimension with the new value
            return new Dimension(InternalUnitType, (d1._intrinsicValue - d2._intrinsicValue));
        }

        public static double operator /(Dimension d1, Dimension d2)
        {
            return d1._intrinsicValue / d2._intrinsicValue;
        }

        public static Dimension operator *(Dimension d1, Dimension d2)
        {
            return new Dimension(InternalUnitType, d1._intrinsicValue * d2._intrinsicValue);
        }

        public static Dimension operator *(Dimension d1, double multiplier)
        {
            return new Dimension(InternalUnitType, d1._intrinsicValue * multiplier);
        }
        
        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Dimension d1, Dimension d2)
        {
            return !d1.Equals(d2);
        }

        public static bool operator >(Dimension d1, Dimension d2)
        {
            return d1._intrinsicValue > d2._intrinsicValue;
        }

        public static bool operator <(Dimension d1, Dimension d2)
        {
            return d1._intrinsicValue < d2._intrinsicValue;
        }

        public static bool operator <=(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        public static bool operator >=(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2) || d1 > d2;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return _intrinsicValue.GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Dimension class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call dimension.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Dimension class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call dimension.[unit].ToString() instead");
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within an accepted equality deviation
        /// </summary>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._intrinsicValue - ((Dimension)(obj))._intrinsicValue) < Constants.AcceptedEqualityDeviationConstant;
        }

        /// <summary>
        /// Creates a new dimension that is the negative of the current one
        /// </summary>
        /// <returns></returns>
        public Dimension Negate()
        {
            return new Dimension(InternalUnitType, _intrinsicValue * -1);
        }

        public Dimension AbsoluteValue()
        {
            return new Dimension(InternalUnitType, Math.Abs(_intrinsicValue));
        }

        #endregion

        /// <summary>
        /// This implements the IComparable interface and allows Dimensions to be sorted and such
        /// </summary>
        /// <param name="other">Dimension being compared to</param>
        /// <returns></returns>
        public int CompareTo(Dimension other)
        {
            // We use the equals operator to avoid having to rehash the equality
            // deviation
            if (this.Equals(other))
                return 0;
            else
                return _intrinsicValue.CompareTo(other._intrinsicValue);
        }
    }
}
