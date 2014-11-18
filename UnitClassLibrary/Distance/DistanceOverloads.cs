using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Distance
    {
        #region Overloaded Operators

        // You may notice that we do not overload the increment and decrement operators (++ and --).
        // This would break our abstraction of thinking that all units types are represented by this object 

        public static Distance operator ^(Distance d1, double power)
        {
            return new Distance(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

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
        /// The value and unit in terms of what the object was created with. 
        /// If you want it in a different unit use ToString(DistanceType)
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
            if (obj == null)
            {
                return false;
            }
            try
            {
                return this._equalityStrategy(this, (Distance)obj);
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
