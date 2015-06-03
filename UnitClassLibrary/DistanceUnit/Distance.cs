using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : GenericUnit<IDistanceType>
    {
        public Distance():this(new Inch(), 0){}

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

        public Distance(string architectural):this(new Inch(), ConvertArchitectualStringtoUnit(new Inch(), architectural))
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

        new public Distance Negate()
        {
            return new Distance(base.Negate()); 
        }

        new public Distance AbsoluteValue()
        {
            return new Distance(base.AbsoluteValue());
        }

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

        public static Distance operator *(double power, Distance distance)
        {
            return distance * power;
        }
    }
}