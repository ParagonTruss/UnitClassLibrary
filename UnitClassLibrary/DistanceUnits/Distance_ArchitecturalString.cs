using System;
using System.Text.RegularExpressions;
using UnitClassLibrary.BaseUnit;
using UnitClassLibrary.DistanceUnits.DistanceTypes;
using UnitClassLibrary.DistanceUnits.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnits
{
    public partial class Distance
    {
        /// <summary>
        /// Returns the Distance as a string in an architectural notation with a given fractional precision
        /// </summary>
        public string AsArchitecturalString(int precision = 16)
        {
            return _convertToArchitecturalString(this, precision);
        }

        /// <summary>
        /// Returns a string formatted in a standard AutoCAD format
        /// </summary>
        private static string _convertToArchitecturalString(Distance distance, int precision = 16)
        {
            //Convert into inches before proceeding
            var workingValue = distance.GetValue(new Inch());

            //detect the need for sign
            var sign = "";
            if (workingValue < 0)
            {
                sign = "-";

                //if it is negative, then make it positive for the rest of the calculations
                workingValue = workingValue * -1;
            }

            //get number of whole feet contained in inches by rounding down after calculation
            var feet = Math.Floor(workingValue / 12);

            //remove whole feet from inches
            workingValue = workingValue - (feet * 12);

            //save whole inches now that they are the largest unit
            var inches = Math.Floor(workingValue);

            //remove whole inches from working value, leaving only a fraction
            workingValue = workingValue - inches;

            var numerator = Math.Round(workingValue * precision);

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
            var fractionString = (numerator == 0) ? "" : numerator + "/" + precision;

            //if the value is less than a foot then make the feetString empty
            var feetString = (feet == 0) ? "" : feet.ToString();

            //if the value is less than a inches then make the inchesString empty
            var inchesString = (inches == 0) ? "" : inches.ToString();

            //if all valuse are present, insert both symbols
            var inchesSymbol = "\"";
            var feetSymbol = "'";

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
        /// Converts any possible type of Architectual String into internal units
        /// </summary>
        private static double _convertArchitectualStringtoUnit(IDistanceType convertToType, String passedArchitecturalString)
        {
            // for details on where this solution came from, check here: http://stackoverflow.com/questions/22794466/parsing-all-possible-types-of-varying-architectural-Distance-input
            // answer by Trygve Flathen: http://stackoverflow.com/users/2795177/trygve-flathen

            //trim the input
            passedArchitecturalString = passedArchitecturalString.Trim();

            //define the regular expression (witchcraft)
            const string expression = "^\\s*(?<minus>-)?\\s*(((?<feet>\\d+)(?<inch>\\d{2})(?<sixt>\\d{2}))|((?<feet>[\\d.]+)')?[\\s-]*((?<inch>\\d+)?[\\s-]*((?<numer>\\d+)/(?<denom>\\d+))?\")?)\\s*$";

            //find out what strings match 
            var match = new Regex(expression).Match(passedArchitecturalString);

            //test for failure cases
            if (!match.Success || passedArchitecturalString == "" || passedArchitecturalString == "\"")
            {
                throw new FormatException("Input was not a valid architectural string");
            }

            //parse the results
            var sign = match.Groups["minus"].Success ? -1 : 1;
            var feet = match.Groups["feet"].Success ? Convert.ToDouble(match.Groups["feet"].Value) : 0;
            var inch = match.Groups["inch"].Success ? Convert.ToInt32(match.Groups["inch"].Value) : 0;
            var sixt = match.Groups["sixt"].Success ? Convert.ToInt32(match.Groups["sixt"].Value) : 0;
            var numer = match.Groups["numer"].Success ? Convert.ToInt32(match.Groups["numer"].Value) : 0;
            var denom = match.Groups["denom"].Success ? Convert.ToInt32(match.Groups["denom"].Value) : 1;

            //combine the results
            var result = sign * (feet * 12 + inch + sixt / 16.0 + numer / Convert.ToDouble(denom));

            return SimpleUnit._ConvertUnit(new Inch(), result, convertToType);
        }
    }
}