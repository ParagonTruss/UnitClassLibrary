using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public class Moment
    {
        ForceUnit _force;
        public ForceUnit Force
        {
            get { return _force; }
            set { _force = value; }
        }

        Dimension _dimension;
        public Dimension Dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }

        private double PoundsMillimeters
        {
            get { return _dimension.Millimeters * _force.Pounds; }
        }

        private double PoundsFeet
        {
            get { return _dimension.Feet * _force.Pounds; }
        }

        private double NewtonMeters
        {
            get { return _dimension.Meters * _force.Newtons; }
        }

        public Moment()
        {
            _force = new ForceUnit();
            _dimension = new Dimension();
        }

        public Moment(ForceUnit passeForce, Dimension passedDimension)
        {
            _force = passeForce;
            _dimension = passedDimension;
        }

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Moment operator +(Moment s1, Moment s2)
        {
            //add the two Momentes together
            //return a new Moment with the new value
            //return new Moment( s1._area + s2._area, s1._force + s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        public static Moment operator -(Moment s1, Moment s2)
        {
            //subtract the two Moments
            //return a new Moment with the new value
            //return new Moment(s1._area - s2._area, s1._force - s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to the Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Moment s1, Moment s2)
        {
            return s1.Equals(s2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Moment s1, Moment s2)
        {
            return !s1.Equals(s2);
        }

        /// <summary>
        /// judges comparison based on force
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator >(Moment s1, Moment s2)
        {
            return s1.PoundsFeet > s2.PoundsFeet;
        }

        public static bool operator <(Moment s1, Moment s2)
        {
            return s1.PoundsFeet < s2.PoundsFeet;
        }

        public static bool operator >=(Moment s1, Moment s2)
        {
            return s1.Equals(s2) || s1.PoundsFeet > s2.PoundsFeet;
        }

        public static bool operator <=(Moment s1, Moment s2)
        {
            return s1.Equals(s2) || s1.PoundsFeet < s2.PoundsFeet;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return this.PoundsFeet.GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Moment class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Moment.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Moment class does not know what type of unit it contains, (Because it should be thought of containing all unit types) Call Moment.[unit].ToString() instead");
        }

        /// <summary>
        /// if the passed in object is a Moment
        /// </summary>
        public override bool Equals(object obj)
        {
            try
            {
                Moment compare = (Moment)obj;

                return compare._dimension == this._dimension && compare._force == this._force;
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// This implements the IComparable interface and allows Moments to be sorted and such
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Moment other)
        {
            // The comparison depends on the comparison of  
            // the underlying Double values.  
            if (this.Equals(other))
                return 0;
            else
                return this.PoundsFeet.CompareTo(other.PoundsFeet);
        }
    }
}
