using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public partial class DerivedUnit
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
        public DerivedUnit Negate()
        {
            return new DerivedUnit(Value.Negate(), _numerators, _denominators);
        }

        public DerivedUnit AbsoluteValue()
        {
            return new DerivedUnit(Value.AbsoluteValue(), _numerators, _denominators);
        }
    }
}
