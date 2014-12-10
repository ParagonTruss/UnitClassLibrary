using System;
using System.Collections.Generic;
 
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    /// <summary>
    /// defines force in a direction
    /// </summary>
    public class Moment
    {
        #region _internalVariables
        /// <summary>
        /// Force that is applied in a direction
        /// </summary>
        private ForceUnit _force;

        /// <summary>
        /// The distance upon which the force acts
        /// </summary>
        private Distance _Distance;
        #endregion

        #region Properties
        public double PoundsMillimeters
        {
            get { return _Distance.Millimeters * _force.Pounds; }
        }

        public double PoundsFeet
        {
            get { return _Distance.Feet * _force.Pounds; }
        }


        public double NewtonMeters
        {
            get { return _Distance.Meters * _force.Newtons; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// zero constructor for moment
        /// </summary>
        public Moment()
        {
            _force = new ForceUnit();
            _Distance = new Distance();
        }

        /// <summary>
        /// constructor that creates moment based on the distance passed and force
        /// </summary>
        /// <param name="passeForce">amount of force applied</param>
        /// <param name="passedDistance">direction of force applied</param>
        public Moment(ForceUnit passeForce, Distance passedDistance)
        {
            _force = passeForce;
            _Distance = passedDistance;
        }

        /// <summary>
        /// constructor that creates moment with composite unit that expresses a moment and value
        /// </summary>
        /// <param name="passedMomentType"></param>
        /// <param name="passedValue"></param>
        public Moment(MomentType passedMomentType, double passedValue)
        {
            switch (passedMomentType)
            {
                case MomentType.PoundsMillimeters:
                    _force = new ForceUnit(ForceType.Pounds, passedValue);
                    _Distance = new Distance(DistanceType.Millimeter, 1);
                    break;
                case MomentType.NewtonMeters:
                    _force = new ForceUnit(ForceType.Newtons, passedValue);
                    _Distance = new Distance(DistanceType.Meter, 1);
                    break;
                case MomentType.PoundsFeet:
                    _force = new ForceUnit(ForceType.Pounds, passedValue);
                    _Distance = new Distance(DistanceType.Foot, 1);
                    break;
                default:
                    // Should never reach; cases should cover all members of enumerated set
                    break;
            }
        }
        #endregion

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
            if ((object)s1 == null)
            {
                if ((object)s2 == null)
                {
                    return true;
                }
                return false;
            }
            return s1.Equals(s2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Moment s1, Moment s2)
        {
            if ((object)s1 == null)
            {
                if ((object)s2 == null)
                {
                    return false;
                }
                return true;
            }
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


        public override string ToString()
        {
            return this._force + "  " + this._Distance; 
        }

        /// <summary>
        /// if the passed in object is a Moment
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                Moment compare = (Moment)obj;
                return compare._Distance.Equals(this._Distance) && compare._force.Equals(this._force);
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        #endregion

        #region Interface Methods
        /// <summary>
        /// This implements the IComparable interface and allows Moments to be sorted and such
        /// </summary>
        /// <param name="other">other moment to compare</param>
        /// <returns>0 if equal; 1 if this greater than other; -1 if this less than other</returns>
        public int CompareTo(Moment other)
        {
            // The comparison depends on the comparison of  
            // the underlying Double values.  
            if (this.Equals(other))
                return 0;
            else
                return this.PoundsFeet.CompareTo(other.PoundsFeet);
        }
        #endregion
    }
}
