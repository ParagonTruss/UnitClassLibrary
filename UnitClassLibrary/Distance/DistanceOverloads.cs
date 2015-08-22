using System;

namespace UnitClassLibrary
{
    public partial class Distance : IEquatable<Distance>, IAbsoluteValue<Distance>
    {
        // You may notice that we do not overload the increment and decrement operators (++ and --).
        // This would break our abstraction of thinking that all units types are represented by this object 

        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static Distance operator ^(Distance d1, double power)
        {
            return new Distance(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        /// <summary>
        /// returns a new Distance with the sum of the two passed distances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Distance operator +(Distance d1, Distance d2)
        {
            //add the two Distances together
            //return a new Distance with the new value
            return new Distance(d1._internalUnitType, d1._intrinsicValue + d2.GetValue(d1._internalUnitType));
        }

        /// <summary>
        /// returns a new Distance with the difference of the two passed distances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Distance operator -(Distance d1, Distance d2)
        {
            //subtract the two Distances
            //return a new Distance with the new value
            return new Distance(d1._internalUnitType, d1._intrinsicValue - d2.GetValue(d1._internalUnitType));
        }
        /// <summary>
        /// ratio of between distances
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double operator /(Distance d1, Distance d2)
        {
            return d1.GetValue(d1._internalUnitType) / d2.GetValue(d1._internalUnitType);
        }

        /// <summary>
        /// multiplication returned as area
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static Area operator *(Distance d1, Distance d2)
        {
            return new Area(d1, d2);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static Distance operator *(Distance d1, double multiplier)
        {
            return new Distance(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }


        public static Distance operator *(double multiplier, Distance d1)
        {
            return new Distance(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }


        /// <summary>
        /// scalar division
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
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

        /// <summary>
        /// greater than
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator >(Distance d1, Distance d2)
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
        public static bool operator <(Distance d1, Distance d2)
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
        public static bool operator <=(Distance d1, Distance d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
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
            return this.GetValue(DistanceType.Inch).GetHashCode();
        }

        /// <summary>
        /// The value and unit in terms of what the object was created with. 
        /// If you want it in a different unit use ToString(DistanceType)
        /// </summary>
        public override string ToString()
        {
            //round the number to an acceptable range given the EqualityStrategy.

            try
            {
                int digits = 0;
                double roundedIntrinsicValue =Math.Round(_intrinsicValue, digits);

                while (this != new Distance(this.InternalUnitType, roundedIntrinsicValue))
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
        /// calls the Distance only Equals method
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || obj is Distance == false)
            {
                return false;
            }
            try
            {
                Distance otherDistance = (Distance)obj;

                return this.Equals((Distance)obj);
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Distance other)
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
