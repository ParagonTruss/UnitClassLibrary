using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    [DebuggerDisplay("PoundsPerSquareInch = {PoundsPerSquareInch}")]
    public class StressUnit :IComparable<StressUnit>
    {
        #region private fields and constants

        private ForceUnit _force;
        private Area _area;

        #endregion

        #region Constructors

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public StressUnit()
        {
            _area = new Area();
            _force = new ForceUnit();
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        /// <param name="passedArea"></param>
        /// <param name="passedForce"></param>
        public StressUnit(ForceUnit passedForce, Area passedArea)
        {
            _area = passedArea;
            _force = passedForce;
        }

        #endregion

        #region Properties

        public double PoundsPerSquareInch
        {
            get { return _force.Pounds / _area.InchesSquared; }
        }

        public double PoundsPerSquareMillimeter
        {
            get { return _force.Pounds / _area.MillimetersSquared; }
        }

        public double NewtonsPerSquareMeter
        {
            get { return _force.Newtons / _area.MetersSquared; }
        }

        public double NewtonsPerSquareMillimeter
        {
            get { return _force.Newtons / _area.MillimetersSquared; }

        }

        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static StressUnit operator +(StressUnit s1, StressUnit s2)
        {
            //add the two Stresses together
            //return a new Stress with the new value
            //return new Stress( s1._area + s2._area, s1._force + s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        public static StressUnit operator -(StressUnit s1, StressUnit s2)
        {
            //subtract the two Stresss
            //return a new Stress with the new value
            //return new Stress(s1._area - s2._area, s1._force - s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to the Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(StressUnit s1, StressUnit s2)
        {
            return s1.Equals(s2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(StressUnit s1, StressUnit s2)
        {
            return !s1.Equals(s2);
        }

        public static bool operator >(StressUnit s1, StressUnit s2)
        {
            return (s1.PoundsPerSquareMillimeter > s2.PoundsPerSquareMillimeter);
        }

        public static bool operator <(StressUnit s1, StressUnit s2)
        {
            return (s1.PoundsPerSquareMillimeter < s2.PoundsPerSquareMillimeter);
        }

        public static bool operator >=(StressUnit s1, StressUnit s2)
        {
            return s1.Equals(s2) || s1.PoundsPerSquareMillimeter > s2.PoundsPerSquareMillimeter;
        }

        public static bool operator <=(StressUnit s1, StressUnit s2)
        {
            return s1.Equals(s2) || s1.PoundsPerSquareMillimeter < s2.PoundsPerSquareMillimeter;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return PoundsPerSquareMillimeter.GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Stress class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Stress.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Stress class does not know what type of unit it contains, (Because it should be thought of containing all unit types) Call Stress.[unit].ToString() instead");
        }

        /// <summary>
        /// does the same thing as == if the passed in object is a Stress
        /// </summary>
        public override bool Equals(object obj)
        {
            try
            {
                StressUnit newStress = (StressUnit)obj;

                return Math.Abs(newStress.PoundsPerSquareMillimeter - this.PoundsPerSquareMillimeter) < Constants.AcceptedEqualityDeviationConstant;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// This implements the IComparable interface and allows Stresss to be sorted and such
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(StressUnit other)
        {
            // The comparison depends on the comparison of  
            // the underlying Double values
            if (this.Equals(other))
                return 0;
            else
                return PoundsPerSquareMillimeter.CompareTo(other.PoundsPerSquareMillimeter);
        }
    }
}
