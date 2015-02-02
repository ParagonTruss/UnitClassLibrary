using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial class Broken
    {
        /// <summary>
        /// Generator method that constructs Broken with the assumption that the passed value is in inches
        /// </summary>
        /// <param name="passedValue"></param>
        /// <returns></returns>
        public static Broken MakeBrokenWithInches(double passedValue)
        {
            return new Broken(BrokenType.Inch, passedValue);
        }

        /// <summary>
        /// Generator method that constructs Broken with the assumption that the passed value is in milliimeters
        /// </summary>
        /// <param name="passedValue"></param>
        /// <returns></returns>
        public static Broken MakeBrokenWithMillimeters(double passedValue)
        {
            return new Broken(BrokenType.Millimeter, passedValue);
        }
    }
}