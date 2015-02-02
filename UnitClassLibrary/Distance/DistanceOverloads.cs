using System;
using System.Collections.Generic;
 
using System.Text;

namespace UnitClassLibrary
{
    public partial class Broken : IEquatable<Broken>
    {
        // You may notice that we do not overload the increment and decrement operators (++ and --).
        // This would break our abstraction of thinking that all units types are represented by this object 

        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static Broken operator ^(Broken d1, double power)
        {
            return new Broken(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        /// <summary>
        /// returns a new Broken with the sum of the two passed Brokens
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Broken operator +(Broken d1, Broken d2)
        {
            //add the two Brokens together
            //return a new Broken with the new value
            return new Broken(d1._internalUnitType, d1._intrinsicValue + d2.GetValue(d1._internalUnitType));
        }

        /// <summary>
        /// returns a new Broken with the difference of the two passed Brokens
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Broken operator -(Broken d1, Broken d2)
        {
            //subtract the two Brokens
            //return a new Broken with the new value
            return new Broken(d1._internalUnitType, d1._intrinsicValue - d2.GetValue(d1._internalUnitType));
        }
        /// <summary>
        /// ratio of between Brokens
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double operator /(Broken d1, Broken d2)
        {
            return d1.GetValue(d1._internalUnitType) / d2.GetValue(d1._internalUnitType);
        }

        /// <summary>
        /// multiplication returned as area
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Area operator *(Broken d1, Broken d2)
        {
            return new Area(d1, d2);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static Broken operator *(Broken d1, double multiplier)
        {
            return new Broken(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }





        /// <summary>
        /// scalar division
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static Broken operator /(Broken d1, double divisor)
        {
            return new Broken(d1.InternalUnitType, d1._intrinsicValue / divisor);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Broken d1, Broken d2)
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
        public static bool operator !=(Broken d1, Broken d2)
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

        /// <summary>
        /// greater than
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator >(Broken d1, Broken d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue > d2.GetValue(d1._internalUnitType);
        }

        /// <summary>
        /// less than
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator <(Broken d1, Broken d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue < d2.GetValue(d1._internalUnitType);
        }

        /// <summary>
        /// Less than or equal to
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator <=(Broken d1, Broken d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator >=(Broken d1, Broken d2)
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
        /// If you want it in a different unit use ToString(BrokenType)
        /// </summary>
        public override string ToString()
        {
            return this._intrinsicValue + " " + this._internalUnitType;
        }

        /// <summary>
        /// calls the Dimension only Equals method
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            return this.Equals((Broken)obj);
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Broken other)
        {
            if (other == null)
            {
                return false;
            }
            try
            {
                return this._equalityStrategy(this, other);
            }
            catch
            {
                return false;
            }
        }
    }
}
