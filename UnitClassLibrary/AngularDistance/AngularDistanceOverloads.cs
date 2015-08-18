using System;
using System.Collections.Generic;

using System.Text;

namespace UnitClassLibrary
{
    public partial class AngularDistance : IEquatable<AngularDistance>
    {
        // You might notice that we do not overload the increment and decrement operators (++ and --).
        // Doing so would break our abstraction about dealing with every unit type 

        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static AngularDistance operator ^(AngularDistance d1, double power)
        {
            return new AngularDistance(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        /// <summary>
        /// returns a new AngularDistance with the sum of the two passed AngularDistances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static AngularDistance operator +(AngularDistance d1, AngularDistance d2)
        {
            //add the two AngularDistances together
            //return a new AngularDistance with the new value
            return new AngularDistance(d1._internalUnitType, d1._intrinsicValue + d2.GetValue(d1._internalUnitType));
        }

        /// <summary>
        /// returns a new AngularDistance with the difference of the two passed AngularDistances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static AngularDistance operator -(AngularDistance d1, AngularDistance d2)
        {
            //subtract the two AngularDistances
            //return a new AngularDistance with the new value
            return new AngularDistance(d1._internalUnitType, d1._intrinsicValue - d2.GetValue(d1._internalUnitType));
        }
        /// <summary>
        /// ratio of AngularDistances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double operator /(AngularDistance d1, AngularDistance d2)
        {
            return d1.GetValue(d1._internalUnitType) / d2.GetValue(d1._internalUnitType);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static AngularDistance operator *(AngularDistance d1, double multiplier)
        {
            return new AngularDistance(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }

        public static AngularDistance operator %(AngularDistance d1, AngularDistance d2)
        {
            var result = d1.GetValue(d1._internalUnitType) % d2.GetValue(d1._internalUnitType);
            return new AngularDistance(d1._internalUnitType, result);
        }



        /// <summary>
        /// scalar division
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static AngularDistance operator /(AngularDistance d1, double divisor)
        {
            return new AngularDistance(d1.InternalUnitType, d1._intrinsicValue / divisor);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(AngularDistance d1, AngularDistance d2)
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
        public static bool operator !=(AngularDistance d1, AngularDistance d2)
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
        public static bool operator >(AngularDistance d1, AngularDistance d2)
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
        public static bool operator <(AngularDistance d1, AngularDistance d2)
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
        public static bool operator <=(AngularDistance d1, AngularDistance d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator >=(AngularDistance d1, AngularDistance d2)
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
        /// If you want it in a different unit use ToString(AngularDistanceType)
        /// </summary>
        public override string ToString()
        {
            //round the number to an acceptable range given the EqualityStrategy.

            try
            {
                int digits = 0;
                double roundedIntrinsicValue = Math.Round(_intrinsicValue, digits);

                while (this != new AngularDistance(this.InternalUnitType, roundedIntrinsicValue))
                {
                    digits++;
                    roundedIntrinsicValue = Math.Round(_intrinsicValue, digits);
                }

                return Math.Round(_intrinsicValue, digits) + " " + this._internalUnitType;
            }
            catch (OverflowException)
            {

                return _intrinsicValue + " " + this._internalUnitType;
            }


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

            return this.Equals((AngularDistance)obj);
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(AngularDistance other)
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
