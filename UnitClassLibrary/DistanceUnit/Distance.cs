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

        public Distance(IDistanceType distanceType, double passedDouble):base(new List<Unit>(){new Unit(passedDouble,distanceType)}, new List<Unit>() )
        {
            _deviationConstant = new Unit(1.0/32.0, new Inch());
        }

        public Distance(string architectural):this(new Inch(), ConvertArchitectualStringtoUnit(new Inch(), architectural))
        {
            _deviationConstant = new Unit(1.0 / 32.0, new Inch());
        }

        private Distance(GenericUnit<IDistanceType> toCopy)
            : base(toCopy)
        {
            _deviationConstant = new Unit(1.0 / 32.0, new Inch());
        }

        public Distance(Distance toCopy)
            : base(toCopy)
        {
            _deviationConstant = new Unit(1.0 / 32.0, new Inch());
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


        public void ToString(Inch inch)
        {
            throw new NotImplementedException();
        }

        

    }
}