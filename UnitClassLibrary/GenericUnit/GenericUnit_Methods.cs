using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public partial class GenericUnit
    {
        public static double ConvertUnit(IUnit convertFromType, double value, IUnit convertToType)
        {
            return ConvertUnit(convertFromType.ConversionFactor, value, convertToType.ConversionFactor);
        }

        public static double ConvertUnit(double fromConversionFactor, double value, double toConversionFactor)
        {
            return value * (fromConversionFactor / toConversionFactor);
        }

        public double GetValue(double toConversionFactor)
        {
            return ConvertUnit(this.ConversionFactor, IntrinsicValue, toConversionFactor);
        }



        //public double GetValue(IUnit typeConvertingTo)
        //{
        //    return GetValue(typeConvertingTo.ConversionFactor);
        //}

        /// <summary>
        /// Creates a new GenericUnit that is the negative of this one
        /// </summary>
        public GenericUnit Negate()
        {
            return new GenericUnit(Value.Negate(), _numerators, _denominators);
        }

        public GenericUnit AbsoluteValue()
        {
            return new GenericUnit(Value.AbsoluteValue(), _numerators, _denominators);
        }
    }
}
