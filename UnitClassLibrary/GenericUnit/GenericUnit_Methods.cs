using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public partial class GenericUnit<T>
    {
        public static double ConvertUnit(IUnitType convertFromType, double value, IUnitType convertToType)
        {
            return ConvertUnit(convertFromType.ConversionFactor, value, convertToType.ConversionFactor);
        }

        public static double ConvertUnit(double fromConversionFactor, double value, double toConversionFactor)
        {
            return value * (fromConversionFactor / toConversionFactor);
        }

        public double GetValue(double toConversionFactor)
        {
            return ConvertUnit(this.ConversionFactor, _IntrinsicValue, toConversionFactor);
        }



        public double GetValue(T typeConvertingTo)
        {
            return GetValue(typeConvertingTo.ConversionFactor);
        }

        /// <summary>
        /// Creates a new GenericUnit<T> that is the negative of this one
        /// </summary>
        public GenericUnit<T> Negate()
        {
            var newNumerators = new List<BasicUnit>((_numerators));

            //we just negate the first numerator
            newNumerators[0] = (new BasicUnit(newNumerators[0].IntrinsicValue * -1, newNumerators[0].ConversionFactor));

            return new GenericUnit<T>(newNumerators, _denomenators);
        }

        public GenericUnit<T> AbsoluteValue()
        {
            //while slightly unnecessary, we make everything positive. not just a single value

            var newNumerators = new List<BasicUnit>((_numerators));
            var newDenomenators = new List<BasicUnit>((_denomenators));

            for (int i = 0; i < newNumerators.Count; i++)
            {
                if (newNumerators[i].IntrinsicValue < 0)
                {
                    newNumerators[i] = (new BasicUnit(newNumerators[i].IntrinsicValue * -1, newNumerators[i].ConversionFactor));
                }
            }

            for (int i = 0; i < newDenomenators.Count; i++)
            {
                if (newDenomenators[i].IntrinsicValue < 0)
                {
                    newDenomenators[i] = (new BasicUnit(newDenomenators[i].IntrinsicValue * -1, newDenomenators[i].ConversionFactor));
                }
            }


            return new GenericUnit<T>(newNumerators, newDenomenators);
        }
    }
}
