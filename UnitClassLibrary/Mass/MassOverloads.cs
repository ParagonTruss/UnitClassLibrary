using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Mass : IEquatable<Mass>
    {
        // You may notice that we do not overload the increment and decrement operators (++ and --).
        // This would break our abstraction of thinking that all units types are represented by this object 

        /// <summary>
        /// Operator to raise a mass by a power
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static Mass operator ^(Mass m1, double power)
        {
            return new Mass(m1._internalUnitType, Math.Pow(m1._intrinsicValue, power));
        }

        /// <summary>
        /// Operator to add and return the sum of m1 and m2
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Mass operator +(Mass m1, Mass m2)
        {
            //add the two Masss together
            //return a new Mass with the new value
            return new Mass(m1._internalUnitType, m1._intrinsicValue + m2.GetValue(m1._internalUnitType));
        }

        /// <summary>
        /// Operator to subtract and return the difference between m1 and m2
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Mass operator -(Mass m1, Mass m2)
        {
            //subtract the two Masses
            //return a new Mass with the new value
            return new Mass(m1._internalUnitType, m1._intrinsicValue - m2.GetValue(m1._internalUnitType));
        }
        
        /// <summary>
        /// Divide and return the ratio of m1 and m2
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static double operator /(Mass m1, Mass m2)
        {
            return m1.GetValue(m1._internalUnitType) / m2.GetValue(m1._internalUnitType);
        }

        /// <summary>
        /// Multiply and return the product of m1 and a double
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static Mass operator *(Mass m1, double multiplier)
        {
            return new Mass(m1._internalUnitType, m1._intrinsicValue * multiplier);
        }

        /// <summary>
        /// Divide and return the ratio of m1 and a divisor
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static Mass operator /(Mass m1, double divisor)
        {
            return new Mass(m1.InternalUnitType, m1._intrinsicValue / divisor);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Mass m1, Mass m2)
        {
            if ((object)m1 == null)
            {
                if ((object)m2 == null)
                {
                    return true;
                }
                return false;
            }
            return m1.Equals(m2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Mass m1, Mass m2)
        {
            if ((object)m1 == null)
            {
                if ((object)m2 == null)
                {
                    return false;
                }
                return true;
            }
            return !m1.Equals(m2);
        }

        /// <summary>
        /// Operator that returns whether m1 is greater than m2 or not
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator >(Mass m1, Mass m2)
        {
            if (m1 == m2)
            {
                return false;
            }
            return m1._intrinsicValue > m2.GetValue(m1._internalUnitType);
        }
        
        /// <summary>
        /// Operator that returns whether m1 is less than m2 or not
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator <(Mass m1, Mass m2)
        {
            if (m1 == m2)
            {
                return false;
            }
            return m1._intrinsicValue < m2.GetValue(m1._internalUnitType);
        }


        /// <summary>
        /// Tests whether m1 is less than or equal to m2
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator <=(Mass m1, Mass m2)
        {
            return m1.Equals(m2) || m1 < m2;
        }

        /// <summary>
        /// Operator that returns whether m1 is greater than or equal to m2
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator >=(Mass m1, Mass m2)
        {
            return m1.Equals(m2) || m1 > m2;
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
        /// If you want it in a different unit use ToString(MassType)
        /// </summary>
        /// <returns>Should never return anything</returns>
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

            return this.Equals((Mass)obj);
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Mass other)
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
