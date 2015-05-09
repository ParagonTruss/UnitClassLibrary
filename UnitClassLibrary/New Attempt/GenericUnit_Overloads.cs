using System;
using System.Collections.Generic;

namespace UnitClassLibrary.New_Attempt
{


    public partial class GenericUnit
    {
        private class UnitType : IUnitType
        {
            private List<IUnitType> types = new List<IUnitType>();

            public UnitType(List<IUnitType> types)
            {
                this.types = types;
            }

            public double GetConversionFactor()
            {
                double sum = 1.0;

                foreach (var unitType in types)
                {
                    sum *= unitType.GetConversionFactor();
                }

                return sum;
            }
        }
            /// <summary>
            /// The "raise to power" operator
            /// </summary>
            public static GenericUnit operator ^(GenericUnit d1, double power)
            {
                var newNumerators =new List<KeyValuePair<double, IUnitType>>((d1.numerators));

                //multiply the first value by itself

                newNumerators[0] = new KeyValuePair<double, IUnitType>(newNumerators[0].Key * newNumerators[0].Key, newNumerators[0].Value);
                return new GenericUnit(newNumerators, d1.denomenators);
            }

            private static List<IUnitType> _getUnitTypes(List<KeyValuePair<double, IUnitType>> list)
            {
                var returnList = new List<IUnitType>();

                foreach (var pair in list)
                {
                    returnList.Add(pair.Value);    
                }

                return returnList;
            }

            /// <summary>
            /// returns a new GenericUnit with the sum of the two passed distances
            /// </summary>
            public static GenericUnit operator +(GenericUnit d1, GenericUnit d2)
            {
                var sum = d1._IntrinsicValue + d2._IntrinsicValue;

                var newNumerators = new List<KeyValuePair<double, IUnitType>>((d1.numerators));
                var newDenomenators = new List<KeyValuePair<double, IUnitType>>((d2.denomenators));

                newNumerators[0] = (new KeyValuePair<double, IUnitType>(sum, newNumerators[0].Value));

                for (int i = 1; i < newNumerators.Count; i++)
                {
                    if (newNumerators[i].Key < 0)
                    {
                        newNumerators[i] = (new KeyValuePair<double, IUnitType>(1, newNumerators[i].Value));
                    }
                }

                for (int i = 0; i < newDenomenators.Count; i++)
                {

                        newDenomenators[i] = (new KeyValuePair<double, IUnitType>(1, newDenomenators[i].Value));
                }

                return new GenericUnit(newNumerators, newDenomenators);
            }

            /// <summary>
            /// returns a new GenericUnit with the difference of the two passed distances
            /// </summary>
            public static GenericUnit operator -(GenericUnit d1, GenericUnit d2)
            {
                var sum = d1._IntrinsicValue - d2._IntrinsicValue;

                var newNumerators = new List<KeyValuePair<double, IUnitType>>((d1.numerators));
                var newDenomenators = new List<KeyValuePair<double, IUnitType>>((d1.denomenators));

                newNumerators[0] = (new KeyValuePair<double, IUnitType>(sum, newNumerators[0].Value));

                for (int i = 1; i < newNumerators.Count; i++)
                {
                    if (newNumerators[i].Key < 0)
                    {
                        newNumerators[i] = (new KeyValuePair<double, IUnitType>(1, newNumerators[i].Value));
                    }
                }

                for (int i = 0; i < newDenomenators.Count; i++)
                {

                    newDenomenators[i] = (new KeyValuePair<double, IUnitType>(1, newDenomenators[i].Value));
                }

                return new GenericUnit(newNumerators, newDenomenators);
            }

            /// <summary>
            /// scalar multiplication
            /// </summary>
            public static GenericUnit operator *(GenericUnit d1, double multiplier)
            {
                var newNumerators = new List<KeyValuePair<double, IUnitType>>((d1.numerators));

                newNumerators[0] = new KeyValuePair<double, IUnitType>(newNumerators[0].Key * multiplier, newNumerators[0].Value);

                return new GenericUnit(newNumerators,d1.denomenators);
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
            public static GenericUnit operator /(GenericUnit d1, double divisor)
            {
                var newNumerators = new List<KeyValuePair<double, IUnitType>>((d1.numerators));

                newNumerators[0] = new KeyValuePair<double, IUnitType>(newNumerators[0].Key / divisor, newNumerators[0].Value);

                return new GenericUnit(newNumerators, d1.denomenators);
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
                return d1._IntrinsicValue > d2.GetValue(d1.InternalGenericUnitType);
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
                return d1._IntrinsicValue < d2.GetValue(d1.InternalGenericUnitType);
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
                return _IntrinsicValue.GetHashCode();
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

                    while (this != new GenericUnit(this.InternalGenericUnitType, roundedIntrinsicValue))
                    {
                        digits++;
                        roundedIntrinsicValue = Math.Round(_IntrinsicValue, digits);
                    }

                    return Math.Round(_IntrinsicValue, digits) + " " + InternalGenericUnitType;
                }
                catch (OverflowException)
                {

                    return _IntrinsicValue + " " + InternalGenericUnitType;
                }
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                return this.Equals((GenericUnit)obj);
            }

            /// <summary>
            /// Compares using the function specified by strategy
            /// </summary>
            public bool Equals(GenericUnit other)
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
