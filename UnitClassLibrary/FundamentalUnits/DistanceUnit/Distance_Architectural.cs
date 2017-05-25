﻿/*
    This file is part of Unit Class Library.
    Copyright (C) 2017 Paragon Component Systems, LLC.

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;


namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance
    {

        public string Architectural => ConvertToArchitecturalString(this);

        /// <summary>
        /// Converts any possible type of Architectual String into internal units
        /// </summary>
        private static double _convertArchitectualStringToValueInInches(string architecturalString)
        {
            // for details on where this solution came from, check here: http://stackoverflow.com/questions/22794466/parsing-all-possible-types-of-varying-architectural-Distance-input
            // answer by Trygve Flathen: http://stackoverflow.com/users/2795177/trygve-flathen

            //trim the input
            architecturalString = architecturalString.Trim();

            //define the regular expression (witchcraft)
            String expression = "^\\s*(?<minus>-)?\\s*(((?<feet>\\d+)(?<inch>\\d{2})(?<sixt>\\d{2}))|((?<feet>[\\d.]+)')?[\\s-]*((?<inch>\\d+)?[\\s-]*((?<numer>\\d+)/(?<denom>\\d+))?\")?)\\s*$";

            //find out what strings match 
            Match match = new Regex(expression).Match(architecturalString);

            //test for failure cases
            if (!match.Success || architecturalString == "" || architecturalString == "\"")
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

            return result;
        }



        /// <summary>
        /// Returns a string formatted in a standard AutoCAD format
        /// </summary>
        private static string ConvertToArchitecturalString(Distance distance, int precision = 16)
        {
            //Convert into inches before proceeding
            double workingValue = distance.MeasurementIn(new Inch()).Value;

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
    }
}
