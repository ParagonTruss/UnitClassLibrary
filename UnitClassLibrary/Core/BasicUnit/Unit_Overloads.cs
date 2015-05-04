using System;

namespace UnitClassLibrary.BaseUnit
{
    public partial class Unit
    {
        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        public static Unit operator ^(Unit d1, double power)
        {
            return new Unit(d1.InternalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        /// <summary>
        /// returns a new Unit with the sum of the two passed distances
        /// </summary>
        public static Unit operator +(Unit d1, Unit d2)
        {
            //add the two Distances together
            //return a new Unit with the new value
            return new Unit(d1.InternalUnitType, d1._intrinsicValue + d2.GetValue(d1.InternalUnitType));
        }

        /// <summary>
        /// returns a new Unit with the difference of the two passed distances
        /// </summary>
        public static Unit operator -(Unit d1, Unit d2)
        {
            //subtract the two Distances
            //return a new Unit with the new value
            return new Unit(d1.InternalUnitType, d1._intrinsicValue - d2.GetValue(d1.InternalUnitType));
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Unit operator *(Unit d1, double multiplier)
        {
            return new Unit(d1.InternalUnitType, d1._intrinsicValue * multiplier);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static Unit operator *(double multiplier, Unit d1)
        {
            return d1 * multiplier;
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Unit operator /(Unit d1, double divisor)
        {
            return new Unit(d1.InternalUnitType, d1._intrinsicValue / divisor);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static Unit operator /(double divisor, Unit d1)
        {
            return d1 / divisor;
        }

        /// <summary>
        /// ratio of between distances
        /// </summary>
        public static double operator /(Unit d1, Unit d2)
        {
            return d1.GetValue(d1.InternalUnitType) / d2.GetValue(d1.InternalUnitType);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Unit d1, Unit d2)
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
        public static bool operator !=(Unit d1, Unit d2)
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
        public static bool operator >(Unit d1, Unit d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue > d2.GetValue(d1.InternalUnitType);
        }

        /// <summary>
        /// less than
        /// </summary>
        public static bool operator <(Unit d1, Unit d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue < d2.GetValue(d1.InternalUnitType);
        }

        /// <summary>
        /// Less than or equal to
        /// </summary>
        public static bool operator <=(Unit d1, Unit d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        public static bool operator >=(Unit d1, Unit d2)
        {
            return d1.Equals(d2) || d1 > d2;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        public override int GetHashCode()
        {
            return _intrinsicValue.GetHashCode();
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
                double roundedIntrinsicValue = Math.Round(_intrinsicValue, digits);

                while (this != new Unit(this.InternalUnitType, roundedIntrinsicValue))
                {
                    digits++;
                    roundedIntrinsicValue = Math.Round(_intrinsicValue, digits);
                }

                return Math.Round(_intrinsicValue, digits) + " " + InternalUnitType;
            }
            catch (OverflowException)
            {

                return _intrinsicValue + " " + InternalUnitType;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return this.Equals((Unit)obj);
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        public bool Equals(Unit other)
        {
            if (other == null)
            {
                return false;
            }
            try
            {
                return _equalityStrategy(this, other);
            }
            catch
            {
                return false;
            }
        }
    }
}