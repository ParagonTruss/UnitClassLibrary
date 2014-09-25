using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using UnitClassLibrary.Interfaces;


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
    public class Dimension : IComparable<Dimension>, IDistance
    {
        #region private fields and constants
        private DimensionType InternalUnitType;

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
            this._intrinsicValue = passedInput;
            this.InternalUnitType = passedDimensionType;
        }

        /// <summary>
        /// copy constructor - create a new Dimension with the same _intrinsicValue as the passed Dimension
        /// </summary>
        public Dimension(Dimension passedDimension)
        {
            _intrinsicValue = passedDimension._intrinsicValue;
            InternalUnitType = passedDimension.InternalUnitType;
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

        private void storeArchitecturalStringAsInternalUnit(string passedArchitecturalString)
        {
            _intrinsicValue = ConvertArchitectualStringtoInternalUnits(InternalUnitType, passedArchitecturalString);
        }

        private double retrieveAsExternalUnit(DimensionType toDimensionType)
        {
            return ConvertDimension(InternalUnitType, _intrinsicValue, toDimensionType);
        }

        private string retrieveInternalUnitAsArchitecturalString()
        {
            return ConvertDimensionIntoArchitecturalString(this);
        }

        #region Actual Conversion Code

        /// <summary>
        /// Converts any possible type of Architectual String into internal units
        /// <remarks>Throws FormatException on bad input</remarks>
        /// </summary>
        /// <param name="passedArchitecturalString">the input string</param>
        /// <returns>decimal Millimeters</returns>
        private static Double ConvertArchitectualStringtoInternalUnits(DimensionType convertToType, String passedArchitecturalString)
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

            return ConvertDimension(DimensionType.Inch, result, convertToType);
        }

        /// <summary>
        /// Returns a string formatted in a standard AutoCAD format
        /// </summary>
        private static string ConvertToArchitecturalString(DimensionType typeConvertingFrom, double passedValue, int precision = 16)
        {
            //Convert into inches before proceeding
            double workingValue = ConvertDimension(typeConvertingFrom, passedValue, DimensionType.Inch);

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

            switch (typeConvertingFrom)
            {
                case DimensionType.ThirtySecond:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue; // Return passed in thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue / 2; // Convert thirtyseconds to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue / 32; // Convert thirtyseconds to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue / 384; // Convert thirtyseconds to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue / 1152; // Convert thirtyseconds to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue / 2027520; // Convert thirtyseconds to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 0.79375; // Convert thirtyseconds to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 0.079375; // Convert thirtyseconds to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 0.00079375; // Convert thirtyseconds to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 7.9375 * Math.Pow(10, -7); // Convert thirtyseconds to kilometers
                            break;
                    }
                    break;
                case DimensionType.Sixteenth:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 2; // Convert sixteenths to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue; // Return passed in sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue / 16; // Convert sixteenths to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue / 192; // Convert sixteenths to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue / 576; // Convert sixteenths to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue / 1013760; // Convert sixteenths to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 1.5875; // Convert sixteenths to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 0.15875; // Convert sixteenths to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 0.0015875; // Convert sixteenths to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 1.5875 * Math.Pow(10, -6); // Convert sixteenths to kilometers
                            break;
                    }
                    break;
                case DimensionType.Inch:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 32; // Convert inches to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 16; // Convert inches to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue; // Return passed in inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue / 12; // Convert inches to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue / 36; // Convert inches to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue / 63360; // Convert inches to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 25.4; // Convert inches to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 2.54; // Convert inches to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 0.0254; // Convert inches to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 2.54 * Math.Pow(10, -5); // Convert inches to kilometers
                            break;
                    }
                    break;
                case DimensionType.Foot:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 384; // Convert feet to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 192; // Convert feet to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 12; // Convert feet to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue; // Return given feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue / 3; // Convert feet to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue / 5280; // Convert feet to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 304.8; // Convert feet to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 30.48; // Convert feet to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 0.3048; // Convert feet to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 0.0003048; // Convert feet to kilometers
                            break;
                    }
                    break;
                case DimensionType.Yard:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 1152; // Convert yards to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 576; // Convert yards to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 36; // Convert yards to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 3; // Convert yards to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue; // Return given yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue / 1760; // Convert yards to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 914.4; // Convert yards to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 91.44; // Convert yards to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 0.9144; // Convert yards to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 0.0009144; // Convert yards to kilometers
                            break;
                    }
                    break;
                case DimensionType.Mile:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 2027520; // Convert miles to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 1013760; // Convert miles to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 63360; // Convert miles to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 5208; // Convert miles to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue * 1760; // Convert miles to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue; // Return given miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 1609344; // Convert miles to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 160934.4; // Convert miles to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 1609.344; // Convert miles to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue * 1.60934; // Convert miles to kilometers
                            break;
                    }
                    break;
                case DimensionType.Millimeter:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 1.25984576; // Convert millimeters to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 0.62992288; // Convert millimeters to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 0.0393701; // Convert millimeters to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 0.00328084; // Convert millimeters to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue * 0.00109361; // Convert millimeters to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue * 6.2137 * Math.Pow(10, -7); // Convert millimeters to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue; // Return given millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue / 10; // Convert millimeters to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue / 1000; // Convert millimeters to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue / 1000000; // Convert millimeters to kilometers
                            break;
                    }
                    break;
                case DimensionType.Centimeter:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 12.5984576; // Convert centimeters to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 6.2992288; // Convert centimeters to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 0.393701; // Convert centimeters to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 0.00328084; // Convert centimeters to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue * 0.0109361; // Convert centimeters to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue * 6.2137 * Math.Pow(10, -6); // Convert centimeters to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 10; // Convert centimeters to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue; // Return given centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue / 100; // Convert centimeters to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue / 100000; // Convert centimeters to kilometers
                            break;
                    }
                    break;
                case DimensionType.Meter:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 1259.8432; // Convert meters to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 629.9216; // Convert meters to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 39.3701; // Convert meters to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 3.28084; // Convert meters to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue * 1.09361; // Convert meters to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue * 0.000621371; // Convert meters to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 1000; // Convert meters to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 100; // Convert meters to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue; // Return given meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue / 1000; // Convert meters to kilometers
                            break;
                    }
                    break;
                case DimensionType.Kilometer:
                    switch (typeConvertingTo)
                    {
                        case DimensionType.ThirtySecond:
                            returnDouble = passedValue * 1259843.2; // Convert kilometers to thirtyseconds
                            break;
                        case DimensionType.Sixteenth:
                            returnDouble = passedValue * 629921.6; // Convert kilometers to sixteenths
                            break;
                        case DimensionType.Inch:
                            returnDouble = passedValue * 39370.1; // Convert kilometers to inches
                            break;
                        case DimensionType.Foot:
                            returnDouble = passedValue * 3280.84; // Convert kilometers to feet
                            break;
                        case DimensionType.Yard:
                            returnDouble = passedValue * 1093.61; // Convert kilometers to yards
                            break;
                        case DimensionType.Mile:
                            returnDouble = passedValue * 0.621371; // Convert kilometers to miles
                            break;
                        case DimensionType.Millimeter:
                            returnDouble = passedValue * 1000000; // Convert kilometers to millimeters
                            break;
                        case DimensionType.Centimeter:
                            returnDouble = passedValue * 100000; // Convert kilometers to centimeters
                            break;
                        case DimensionType.Meter:
                            returnDouble = passedValue * 1000; // Convert kilometers to meters
                            break;
                        case DimensionType.Kilometer:
                            returnDouble = passedValue / 1000; // Return given kilometers
                            break;
                    }
                    break;
            }

            /*//check to see if a number is within the accepted equaility range
            double roundedValue = Math.Round(internalDecimalMillimeters, (Unit_Class_Library.Properties.Resources.AcceptedDeviationConstant.Length - 2));
            if (Math.Abs(roundedValue - internalDecimalMillimeters) < Double.Parse(Unit_Class_Library.Properties.Resources.AcceptedDeviationConstant))
            {
                internalDecimalMillimeters = roundedValue;
            }*/

            //Now convert the value from Millimeters to the desired output
            /*switch (typeConvertingTo)
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
            }*/

            //this rounds the double due to how C# calls the toString function and gets rid of the double's errors
            //see http://codereview.stackexchange.com/questions/62651/which-method-of-fixing-double-arithmetic-errors-should-i-use
            string returnDoubleAsString = "" + returnDouble;
            return double.Parse(returnDoubleAsString);
        }
            //attempt to fix double arithmetic errors
            /*double errorMargins = returnDouble * Double.Parse(Unit_Class_Library.Properties.Resources.AcceptedDeviationConstant);
            double roundedValue = 0;
            for (int i = 1; i <= returnDoubleAsString.Length; i++)
            {
                roundedValue = RoundToSignificantDigits(returnDouble, i);
                if (Math.Abs(roundedValue - returnDouble) < Double.Parse(Unit_Class_Library.Properties.Resources.AcceptedDeviationConstant))
                {
                    returnDouble = roundedValue;
                    i = returnDoubleAsString.Length;
                }

            }

            return returnDouble;
        }

        //code adapted from http://stackoverflow.com/questions/374316/round-a-double-to-x-significant-figures by P Daddy
        public static double RoundToSignificantDigits(double d, int digits)
        {
            if (d == 0)
                return 0;

            bool isNegative = false;
            if (d < 0)
                isNegative = true;
    
            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
            double returnValue =  scale * Math.Round(d / scale, digits);

            if (isNegative)
                returnValue = -returnValue;

            return returnValue;
        }*/

        /// <summary>
        /// Converts any dimension into an architectural string representation
        /// </summary>
        /// <param name="typeConvertingFrom">desired output unit type</param>
        /// <returns>converted dimension</returns>
        public static string ConvertDimensionIntoArchitecturalString(Dimension d)
        {
            //Now convert the value from millimeters to the desired output
            return ConvertToArchitecturalString(d.InternalUnitType, d._intrinsicValue);
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
            return new Dimension(d1.InternalUnitType, (d1._intrinsicValue + d2.GetValue(d1.InternalUnitType)));
        }

        public static Dimension operator -(Dimension d1, Dimension d2)
        {
            //subtract the two dimensions
            //return a new dimension with the new value
            return new Dimension(d1.InternalUnitType, (d1._intrinsicValue - d2.GetValue(d1.InternalUnitType)));
        }

        public static double operator /(Dimension d1, Dimension d2)
        {
            return d1._intrinsicValue / d2.GetValue(d1.InternalUnitType);
        }

        public static Dimension operator *(Dimension d1, Dimension d2)
        {
            return new Dimension(d1.InternalUnitType, d1._intrinsicValue * d2.GetValue(d1.InternalUnitType));
        }

        public static Dimension operator *(Dimension d1, double multiplier)
        {
            return new Dimension(d1.InternalUnitType, d1._intrinsicValue * multiplier);
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
            return d1._intrinsicValue > d2.GetValue(d1.InternalUnitType);
        }

        public static bool operator <(Dimension d1, Dimension d2)
        {
            return d1._intrinsicValue < d2.GetValue(d1.InternalUnitType);
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
            return Math.Abs(this._intrinsicValue - ((Dimension)(obj)).GetValue(this.InternalUnitType)) < Constants.AcceptedEqualityDeviationConstant;
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

        #region Interface Methods
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
        #endregion
    }
}
