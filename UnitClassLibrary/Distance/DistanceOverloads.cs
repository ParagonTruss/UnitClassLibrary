using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Distance
    {
        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Distance operator +(Distance d1, Distance d2)
        {
            //add the two Distances together
            //return a new Distance with the new value
            return new Distance(d1._internalUnitType, d1._intrinsicValue + d2.GetValue(d1._internalUnitType));
        }

        public static Distance operator -(Distance d1, Distance d2)
        {
            //subtract the two Distances
            //return a new Distance with the new value
            return new Distance(d1._internalUnitType, d1._intrinsicValue - d2.GetValue(d1._internalUnitType));
        }

        public static double operator /(Distance d1, Distance d2)
        {
            return d1.GetValue(d1._internalUnitType) / d2.GetValue(d1._internalUnitType);
        }

        public static Area operator *(Distance d1, Distance d2)
        {
            return new Area(d1, d2);
        }

        public static Distance operator *(Distance d1, double multiplier)
        {
            return new Distance(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }

        public static Distance operator /(Distance d1, double divisor)
        {
            return new Distance(d1.InternalUnitType, d1._intrinsicValue / divisor);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Distance d1, Distance d2)
        {
            if ((object)d1 == null)
            {
                if ((object)d2 == null)
                {
                    return true;
                }
                return false;
            }
            return d1.Equals(d2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Distance d1, Distance d2)
        {
            if ((object)d1 == null)
            {
                if ((object)d2 == null)
                {
                    return false;
                }
                return true;
            }
            return !d1.Equals(d2);
        }

        public static bool operator >(Distance d1, Distance d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue > d2.GetValue(d1._internalUnitType);
        }

        public static bool operator <(Distance d1, Distance d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue < d2.GetValue(d1._internalUnitType);
        }

        public static bool operator <=(Distance d1, Distance d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        public static bool operator >=(Distance d1, Distance d2)
        {
            return d1.Equals(d2) || d1 > d2;
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
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Distance class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Distance.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Distance class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call Distance.[unit].ToString() instead");
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in Constants
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                return this._DistanceEqualityStrategy(this, (Distance)obj);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Distance passedAcceptedEqualityDeviationDistance)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Distance)(obj)).GetValue(this._internalUnitType))
                ))
                < passedAcceptedEqualityDeviationDistance.GetValue(_internalUnitType);
        }

        #endregion

        #region Undecided Functionality

        /// <summary>
        /// Creates a new Distance that is the negative of the current one
        /// </summary>
        /// <returns></returns>
        public Distance Negate()
        {
            return new Distance(_internalUnitType, _intrinsicValue * -1);
        }

        public Distance AbsoluteValue()
        {
            return new Distance(_internalUnitType, Math.Abs(_intrinsicValue));
        }

        public static Distance operator ^(Distance d1, double power)
        {
            return new Distance(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        public Distance RaiseToPower(double power)
        {
            return new Distance(_internalUnitType, Math.Pow(_intrinsicValue, power));
        }

        #endregion
    }
}
