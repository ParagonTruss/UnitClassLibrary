using System;
using System.Collections.Generic;
 
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Extension methods for Lists of type Angle
    /// </summary>
    public static class AngleListExtensionMethods
    {


        /// <summary>
        /// Adds all of the angles in the list and returns the sum.
        /// </summary>
        /// <param name="passedAngleList">this</param>
        /// <returns>Total of all Angles in the list</returns>
        public static Angle SumTotal(this List<Angle> passedAngleList)
        {
            Angle sumAngle = new Angle();

            foreach (var angle in passedAngleList)
            {
                sumAngle += angle;
            }

            return sumAngle;
        }
    }
}
