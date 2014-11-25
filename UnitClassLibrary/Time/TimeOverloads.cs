using System;
using System.Collections.Generic;
 
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial struct Time
    {

        #region Overloaded Operators

        /// <summary>
        ///  The sum of t1 and t2
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1._internalUnitType, (t1._intrinsicValue + t2.GetValue(t1._internalUnitType)));
        }

        /// <summary>
        ///  The difference of t1 and t2
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1._internalUnitType, (t1._intrinsicValue - t2.GetValue(t1._internalUnitType)));
        }

        /// <summary>
        /// The ratio of t1 to t2
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static double operator /(Time t1, Time t2)
        {
            return t1.GetValue(t1._internalUnitType) / t2.GetValue(t1._internalUnitType);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static Time operator /(Time t1, double divisor)
        {
            return new Time(t1._internalUnitType, t1._intrinsicValue / divisor);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static Time operator *(Time t1, double multiplier)
        {
            return new Time(t1._internalUnitType, t1._intrinsicValue * multiplier);
        }

        /// <summary>
        /// Not a perfect equality operator, it's only accurate up to DeviationConstants.AcceptedEqualityDeviationTime 
        /// </summary>
        public static bool operator ==(Time t1, Time t2)
        {
            if ((object)t1 == null)
            {
                if ((object)t2 == null)
                {
                    return true;
                }
                return false;
            }
            return t1.Equals(t2);
        }

        /// <summary>
        /// Not a perfect inequality operator, it's only accurate up to DeviationConstants.AcceptedEqualityDeviationTime 
        /// </summary>
        public static bool operator !=(Time t1, Time t2)
        {
            if ((object)t1 == null)
            {
                if ((object)t2 == null)
                {
                    return false;
                }
                return true;
            }
            return !t1.Equals(t2);
        }

        public static bool operator >(Time t1, Time t2)
        {
            if (t1 == t2)
            {
                return false;
            }

            return t1._intrinsicValue > t2.GetValue(t1._internalUnitType);
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1 == t2)
            {
                return false;
            }

            return t1._intrinsicValue < t2.GetValue(t1._internalUnitType);
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1.Equals(t2) || t1 > t2;
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1.Equals(t2) || t1 < t2;
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
        /// The value and unit in terms of what the object was created with. 
        /// If you want it in a different unit use ToString(TimeType)
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            return this._intrinsicValue + " " + this._internalUnitType;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in Constants
        /// </summary>
        public override bool Equals(object obj)
        {
            return (Math.Abs(this.GetValue(this._internalUnitType) - ((Time)(obj)).GetValue(this._internalUnitType))) <= Math.Abs(this.GetValue(this._internalUnitType) * 0.0001);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Time passedAcceptedEqualityDeviationTime)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Time)(obj)).GetValue(this._internalUnitType))
                ))
                < passedAcceptedEqualityDeviationTime.GetValue(_internalUnitType);
        }

        #endregion

        #region Undecided Functionality

        /// <summary>
        /// Creates a new time that is the negative of the current one
        /// </summary>
        /// <returns></returns>
        public Time Negate()
        {
            return new Time(_internalUnitType, _intrinsicValue * -1);
        }

        #endregion
    }
}
