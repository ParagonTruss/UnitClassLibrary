using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : GenericUnit<IDistanceType>
    {
        #region Constructors

        public Distance() : this(new Inch(), 0) { }

        public Distance(IDistanceType distanceType, double passedDouble)
            : base(new List<BasicUnit>() { new BasicUnit(passedDouble, distanceType.ConversionFactor) }, new List<BasicUnit>())
        {

                //_DeviationConstant = new Distance(new Inch(), 1);
        }

        public Distance(IDistanceType distanceType, double passedDouble, GenericUnit<IDistanceType> acceptedDeviationAsConstant)
            : base(new List<BasicUnit>() { new BasicUnit(passedDouble, distanceType.ConversionFactor) }, new List<BasicUnit>())
        {
                //_DeviationConstant = acceptedDeviationAsConstant;

        }

        public Distance(string architectural) : this(new Inch(), ConvertArchitectualStringtoUnit(new Inch(), architectural))
        {
        }

        private Distance(GenericUnit<IDistanceType> toCopy)
            : base(toCopy)
        {
        }

        public Distance(Distance toCopy)
            : base(toCopy)
        {
        }
        #endregion

        new public Distance Negate()
        {
            return new Distance(base.Negate()); 
        }

        new public Distance AbsoluteValue()
        {
            return new Distance(base.AbsoluteValue());
        }

        public override string ToString()
        {
            if (this._IntrinsicValue == 1.0)
            {
                return "";
            }
            return "";
        }

        #region Operator Overloads
        public static Distance operator ^(Distance distance, double power)
        {
            return new Distance( ((GenericUnit<IDistanceType>) distance) ^ power);
        }

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance((((GenericUnit<IDistanceType>)distance1) + ((GenericUnit<IDistanceType>)distance2)));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance((((GenericUnit<IDistanceType>)distance1) - ((GenericUnit<IDistanceType>)distance2)));
        }

        public static Distance operator *(Distance distance, double factor)
        {
            return new Distance(((GenericUnit<IDistanceType>)distance) * factor);
        }

        public static Distance operator *(double factor, Distance distance)
        {
            return distance * factor;
        }
        #endregion
    }
}