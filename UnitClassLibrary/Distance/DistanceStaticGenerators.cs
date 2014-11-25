using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial class Distance
    {
        /// <summary>
        /// Generator method that constructs Distance with the assumption that the passed value is in inches
        /// </summary>
        /// <param name="passedValue"></param>
        /// <returns></returns>
        public static Distance MakeDistanceWithInches(double passedValue)
        {
            return new Distance(DistanceType.Inch, passedValue);
        }

        /// <summary>
        /// Generator method that constructs Distance with the assumption that the passed value is in milliimeters
        /// </summary>
        /// <param name="passedValue"></param>
        /// <returns></returns>
        public static Distance MakeDistanceWithMillimeters(double passedValue)
        {
            return new Distance(DistanceType.Millimeter, passedValue);
        }
    }
}