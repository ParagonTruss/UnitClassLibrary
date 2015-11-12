using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public partial class GenericUnit<T>
    {  
        /// <summary>
        /// The "raise to power" operator
        /// </summary>
        public static GenericUnit<T> operator ^(GenericUnit<T> d1, double power)
        {
            var newNumerators =new List<BasicUnit>((d1._numerators));

            //multiply the first value by itself

            newNumerators[0] = new BasicUnit(newNumerators[0].IntrinsicValue * newNumerators[0].IntrinsicValue, newNumerators[0].ConversionFactor);
            return new GenericUnit<T>(newNumerators, d1._denomenators);
        }

            

            /// <summary>
            /// returns a new GenericUnit with the sum of the two passed distances
            /// </summary>
        public static GenericUnit<T> operator +(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            var sum = d1._IntrinsicValue + d2._IntrinsicValue;

            var newNumerators = new List<BasicUnit>((d1._numerators));
            var newDenomenators = new List<BasicUnit>((d2._denomenators));

            newNumerators[0] = (new BasicUnit(sum, newNumerators[0].ConversionFactor));

            for (int i = 1; i < newNumerators.Count; i++)
            {
                if (newNumerators[i].IntrinsicValue < 0)
                {
                    newNumerators[i] = (new BasicUnit(1, newNumerators[i].ConversionFactor));
                }
            }

            for (int i = 0; i < newDenomenators.Count; i++)
            {

                    newDenomenators[i] = (new BasicUnit(1, newDenomenators[i].ConversionFactor));
                    newDenomenators[i] = (new BasicUnit(1, newDenomenators[i].ConversionFactor));
            }

            return new GenericUnit<T>(newNumerators, newDenomenators);
        }

        /// <summary>
        /// returns a new GenericUnit with the difference of the two passed distances
        /// </summary>
        public static GenericUnit<T> operator -(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            var sum = d1._IntrinsicValue - d2._IntrinsicValue;

            var newNumerators = new List<BasicUnit>((d1._numerators));
            var newDenomenators = new List<BasicUnit>((d1._denomenators));

            newNumerators[0] = (new BasicUnit(sum, newNumerators[0].ConversionFactor));

            for (int i = 1; i < newNumerators.Count; i++)
            {
                if (newNumerators[i].IntrinsicValue < 0)
                {
                    newNumerators[i] = (new BasicUnit(1, newNumerators[i].ConversionFactor));
                }
            }

            for (int i = 0; i < newDenomenators.Count; i++)
            {

                newDenomenators[i] = (new BasicUnit(1, newDenomenators[i].ConversionFactor));
            }

            return new GenericUnit<T>(newNumerators, newDenomenators);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static GenericUnit<T> operator *(GenericUnit<T> d1, double multiplier)
        {
            var newNumerators = new List<BasicUnit>((d1._numerators));

            newNumerators[0] = new BasicUnit(newNumerators[0].IntrinsicValue * multiplier, newNumerators[0].ConversionFactor);

            return new GenericUnit<T>(newNumerators, d1._denomenators);
        }

        /// <summary>
        /// scalar multiplication
        /// </summary>
        public static GenericUnit<T> operator *(double multiplier, GenericUnit<T> d1)
        {
            return d1 * multiplier;
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static GenericUnit<T> operator /(GenericUnit<T> d1, double divisor)
        {
            var newNumerators = new List<BasicUnit>((d1._numerators));

            newNumerators[0] = new BasicUnit(newNumerators[0].IntrinsicValue / divisor, newNumerators[0].ConversionFactor);

            return new GenericUnit<T>(newNumerators, d1._denomenators);
        }

        /// <summary>
        /// scalar division
        /// </summary>
        public static GenericUnit<T> operator /(double divisor, GenericUnit<T> d1)
        {
            return d1 / divisor;
        }

        /// <summary>
        /// ratio of between distances
        /// </summary>
        public static double operator /(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(GenericUnit<T> d1, GenericUnit<T> d2)
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
        public static bool operator !=(GenericUnit<T> d1, GenericUnit<T> d2)
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
        public static bool operator >(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._IntrinsicValue > d2.GetValue(d1.ConversionFactor);
        }

        /// <summary>
        /// less than
        /// </summary>
        public static bool operator <(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._IntrinsicValue < d2.GetValue(d1.ConversionFactor);
        }

        /// <summary>
        /// Less than or equal to
        /// </summary>
        public static bool operator <=(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        public static bool operator >=(GenericUnit<T> d1, GenericUnit<T> d2)
        {
            return d1.Equals(d2) || d1 > d2;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        public override int GetHashCode()
        {
            return _IntrinsicValue.GetHashCode();
        }

        /// <summary>
        /// This implements the IComparable (Distance) interface and allows Distances to be sorted and such
        /// </summary>
        /// <param name="other">Distance being compared to</param>
        /// <returns></returns>
        public int CompareTo(GenericUnit<T> other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            else
            {
                return _IntrinsicValue.CompareTo(other.GetValue(ConversionFactor));
            }
        }

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

            if (!(obj is GenericUnit<T>))
            {
                throw new ArgumentException("Expected type GenericUnit.", "obj");
            }

            return this.CompareTo((GenericUnit<T>)obj);
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
                double roundedIntrinsicValue = Math.Round(_IntrinsicValue, digits);

                while (this != new GenericUnit<T>(
                    new List<BasicUnit>(){new BasicUnit(roundedIntrinsicValue, this.ConversionFactor)},
                    new List<BasicUnit>()))
                {
                    digits++;
                    roundedIntrinsicValue = Math.Round(_IntrinsicValue, digits);
                }

                return Math.Round(_IntrinsicValue, digits) + "ConversionFactor " + ConversionFactor;
            }
            catch (OverflowException)
            {

                return _IntrinsicValue +  "ConversionFactor " + ConversionFactor;
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

            GenericUnit<T> other = obj as GenericUnit<T>;
            double e = this.ErrorMargin + other.ErrorMargin;
            double difference = Math.Abs(this._IntrinsicValue - other._IntrinsicValue);
            return difference <= e;
        }
    }
}
