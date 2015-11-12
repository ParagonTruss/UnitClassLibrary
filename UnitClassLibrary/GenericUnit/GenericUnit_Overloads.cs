using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public partial class GenericUnit
    {
        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        public static GenericUnit operator ^(GenericUnit d1, int power)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// returns a new GenericUnit with the sum of the two passed distances
        /// </summary>
        public static GenericUnit operator +(GenericUnit d1, GenericUnit d2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// returns a new GenericUnit with the difference of the two passed distances
        /// </summary>
        public static GenericUnit operator -(GenericUnit d1, GenericUnit d2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static GenericUnit operator *(GenericUnit unit, double multiplier)
        {
            return new GenericUnit(unit.Value.Multiply(multiplier), unit._numerators, unit._denominators);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static GenericUnit operator *(double multiplier, GenericUnit d1)
        {
            return d1 * multiplier;
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static GenericUnit operator /(GenericUnit unit, double divisor)
        {
            return new GenericUnit(unit.Value.Divide(divisor), unit._numerators, unit._denominators);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static GenericUnit operator /(double divisor, GenericUnit d1)
        {
            return d1 / divisor;
        }

        /// <summary>
        /// ratio of between distances
        /// </summary>
        public static double operator /(GenericUnit d1, GenericUnit d2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(GenericUnit d1, GenericUnit d2)
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
        public static bool operator !=(GenericUnit d1, GenericUnit d2)
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
        public static bool operator >(GenericUnit d1, GenericUnit d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1.IntrinsicValue > d2.GetValue(d1.ConversionFactor);
        }

        /// <summary>
        /// less than
        /// </summary>
        public static bool operator <(GenericUnit d1, GenericUnit d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1.IntrinsicValue < d2.GetValue(d1.ConversionFactor);
        }

        /// <summary>
        /// Less than or equal to
        /// </summary>
        public static bool operator <=(GenericUnit d1, GenericUnit d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        public static bool operator >=(GenericUnit d1, GenericUnit d2)
        {
            return d1.Equals(d2) || d1 > d2;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        public override int GetHashCode()
        {
            return IntrinsicValue.GetHashCode();
        }

        /// <summary>
        /// This implements the IComparable (Distance) interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="other">Distance being compared to</param>
        /// <returns></returns>
        

        /// <summary>
        /// This implements the IComparable (Distance) interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="obj">object being compared to</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            if (!(obj is GenericUnit))
            {
                throw new ArgumentException("Expected type GenericUnit.", "obj");
            }

            return this.CompareTo((GenericUnit)obj);
        }

        /// <summary>
        /// The value and GenericUnit in terms of what the object was created with. 
        /// If you want it in a different GenericUnit use ToString(DistanceType)
        /// </summary>
        public override string ToString()
        {
            //round the number to an acceptable range given the EqualityStrategy.

            try
            {
                int digits = 0;
                double roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);

                while (this != new GenericUnit(roundedIntrinsicValue,ErrorMargin,_numerators,_denominators))
                {
                    digits++;
                    roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);
                }

                return Math.Round(IntrinsicValue, digits) + "ConversionFactor " + ConversionFactor;
            }
            catch (OverflowException)
            {

                return IntrinsicValue +  "ConversionFactor " + ConversionFactor;
            }
        }

        /// <summary>
        /// Compares using the function specified by strategy
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            GenericUnit other = obj as GenericUnit;
            double e = this.ErrorMargin + other.ErrorMargin;
            double difference = Math.Abs(this.IntrinsicValue - other.IntrinsicValue);
            return difference <= e;
        }
    }
}
