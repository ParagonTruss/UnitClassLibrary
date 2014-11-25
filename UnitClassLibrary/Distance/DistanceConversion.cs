using System;
using System.Text.RegularExpressions;

namespace UnitClassLibrary
{
    public partial class Distance
    {
        /// <summary>
        /// Converts any Unit of distance into another
        /// </summary>
        /// <param name="typeConvertingTo">input unit type</param>
        /// <param name="passedValue"></param>
        /// <param name="typeConvertingFrom">desired output unit type</param>
        /// <returns>passedValue in desired units</returns>
        public static double ConvertDistance(DistanceType typeConvertingFrom, double passedValue, DistanceType typeConvertingTo)
        {

            double returnDouble = 0.0;

            switch (typeConvertingFrom)
            {
                case DistanceType.ThirtySecond:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue; // Return passed in thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue / 2; // Convert thirtyseconds to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue / 32; // Convert thirtyseconds to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue / (32*12); // Convert thirtyseconds to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue / (32*12*3); // Convert thirtyseconds to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue / (32*12*5280); // Convert thirtyseconds to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * ((2.54/32)*10); // Convert thirtyseconds to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * (2.54/32); // Convert thirtyseconds to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * ((2.54/32)/100); // Convert thirtyseconds to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * (((2.54/32)/100)/1000); // Convert thirtyseconds to kilometers
                            break;
                    }
                    break;
                case DistanceType.Sixteenth:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * 2; // Convert sixteenths to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue; // Return passed in sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue / 16; // Convert sixteenths to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue / (16*12); // Convert sixteenths to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue / (16*12*3); // Convert sixteenths to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue / (16*12*5280); // Convert sixteenths to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * ((2.54/16)*10); // Convert sixteenths to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * (2.54/16); // Convert sixteenths to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * ((2.54/16)/100); // Convert sixteenths to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * (((2.54/16)/100)/1000); // Convert sixteenths to kilometers
                            break;
                    }
                    break;
                case DistanceType.Inch:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * 32; // Convert inches to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * 16; // Convert inches to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue; // Return passed in inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue / 12; // Convert inches to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue / (12*3); // Convert inches to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue / (12*5280); // Convert inches to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * (2.54*10); // Convert inches to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * 2.54; // Convert inches to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * (2.54/100); // Convert inches to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * ((2.54/100)/1000); // Convert inches to kilometers
                            break;
                    }
                    break;
                case DistanceType.Foot:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * (12*32); // Convert feet to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * (12*16); // Convert feet to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * 12; // Convert feet to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue; // Return given feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue / 3; // Convert feet to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue / 5280; // Convert feet to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * ((2.54*12)*10); // Convert feet to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * (2.54*12); // Convert feet to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * ((2.54*12)/100); // Convert feet to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * (((2.54*12)/100)/1000); // Convert feet to kilometers
                            break;
                    }
                    break;
                case DistanceType.Yard:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * ((12*32)*3); // Convert yards to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * ((12*16)*3); // Convert yards to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * (3*12); // Convert yards to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * 3; // Convert yards to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue; // Return given yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue / (5280/3); // Convert yards to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * (((2.54*12)*3)*10); // Convert yards to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * ((2.54*12)*3); // Convert yards to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * (((2.54*12)*3)/100); // Convert yards to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * ((((2.54*12)*3)/100)/1000); // Convert yards to kilometers
                            break;
                    }
                    break;
                case DistanceType.Mile:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * ((12*32)*5280); // Convert miles to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * ((12*16)*5280); // Convert miles to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * (12*5280); // Convert miles to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * 5280; // Convert miles to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue * (5280/3); // Convert miles to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue; // Return given miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * (((2.54*12)*5280)*10); // Convert miles to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * ((2.54*12)*5280); // Convert miles to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * (((2.54*12)*5280)/100); // Convert miles to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue * ((((2.54*12)*5280)/100)/1000); // Convert miles to kilometers
                            break;
                    }
                    break;
                case DistanceType.Millimeter:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * (((1/2.54)/10)*32); // Convert millimeters to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * (((1/2.54)/10)*16); // Convert millimeters to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * ((1/2.54)/10); // Convert millimeters to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * (((1/2.54)/12)/10); // Convert millimeters to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue * ((((1/2.54)/12)/3)/10); // Convert millimeters to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue * ((((1/2.54)/12)/5280)/10); // Convert millimeters to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue; // Return given millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue / 10; // Convert millimeters to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue / 1000; // Convert millimeters to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue / 1000000; // Convert millimeters to kilometers
                            break;
                    }
                    break;
                case DistanceType.Centimeter:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * ((1/2.54)*32); // Convert centimeters to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * ((1/2.54)*16); // Convert centimeters to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * (1/2.54); // Convert centimeters to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * ((1/2.54)/12); // Convert centimeters to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue * (((1/2.54)/12)/3); // Convert centimeters to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue * (((1/2.54)/12)/5280); // Convert centimeters to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * 10; // Convert centimeters to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue; // Return given centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue / 100; // Convert centimeters to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue / 100000; // Convert centimeters to kilometers
                            break;
                    }
                    break;
                case DistanceType.Meter:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * (((1/2.54)*32)*100); // Convert meters to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * (((1/2.54)*16)*100); // Convert meters to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * ((1/2.54)*100); // Convert meters to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * (((1/2.54)/12)*100); // Convert meters to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue * ((((1/2.54)/12)/3)*100); // Convert meters to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue * ((((1/2.54)/12)/5280)*100); // Convert meters to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * 1000; // Convert meters to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * 100; // Convert meters to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue; // Return given meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue / 1000; // Convert meters to kilometers
                            break;
                    }
                    break;
                case DistanceType.Kilometer:
                    switch (typeConvertingTo)
                    {
                        case DistanceType.ThirtySecond:
                            returnDouble = passedValue * ((((1/2.54)*32)*100)*1000); // Convert kilometers to thirtyseconds
                            break;
                        case DistanceType.Sixteenth:
                            returnDouble = passedValue * ((((1/2.54)*16)*100)*1000); // Convert kilometers to sixteenths
                            break;
                        case DistanceType.Inch:
                            returnDouble = passedValue * (((1/2.54)*100)*1000); // Convert kilometers to inches
                            break;
                        case DistanceType.Foot:
                            returnDouble = passedValue * ((((1/2.54)/12)*100)*1000); // Convert kilometers to feet
                            break;
                        case DistanceType.Yard:
                            returnDouble = passedValue * (((((1/2.54)/12)/3)*100)*1000); // Convert kilometers to yards
                            break;
                        case DistanceType.Mile:
                            returnDouble = passedValue * (((((1/2.54)/12)/5280)*100)*1000); // Convert kilometers to miles
                            break;
                        case DistanceType.Millimeter:
                            returnDouble = passedValue * 1000000; // Convert kilometers to millimeters
                            break;
                        case DistanceType.Centimeter:
                            returnDouble = passedValue * 100000; // Convert kilometers to centimeters
                            break;
                        case DistanceType.Meter:
                            returnDouble = passedValue * 1000; // Convert kilometers to meters
                            break;
                        case DistanceType.Kilometer:
                            returnDouble = passedValue / 1000; // Return given kilometers
                            break;
                    }
                    break;
            }

            return returnDouble;
        }

        /// <summary>
        /// Converts any possible type of Architectual String into internal units
        /// </summary>
        /// <param name="convertToType"></param>
        /// <param name="passedArchitecturalString"></param>
        /// <returns></returns>
        private static double ConvertArchitectualStringtoUnit(DistanceType convertToType, String passedArchitecturalString)
        {
            // for details on where this solution came from, check here: http://stackoverflow.com/questions/22794466/parsing-all-possible-types-of-varying-architectural-Distance-input
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

            return ConvertDistance(DistanceType.Inch, result, convertToType);
        }

        /// <summary>
        /// Returns a string formatted in a standard AutoCAD format
        /// </summary>
        private static string ConvertToArchitecturalString(DistanceType typeConvertingFrom, double passedValue, int precision = 16)
        {
            //Convert into inches before proceeding
            double workingValue = ConvertDistance(typeConvertingFrom, passedValue, DistanceType.Inch);

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
        /// Converts any Distance into an architectural string representation
        /// </summary>
        /// <returns>converted Distance</returns>
        public static string ConvertDistanceIntoArchitecturalString(Distance passedDistance)
        {
            //Now convert the value from millimeters to the desired output
            return ConvertToArchitecturalString(passedDistance._internalUnitType, passedDistance._intrinsicValue);
        }
    }
}