using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public class Distance:GenericUnit.GenericUnit, IComparable<Distance>
    {
        public Distance():this(new Inch(), 0){}

        public Distance(IDistanceType distanceType, double passedDouble):base(new List<KeyValuePair<double, IUnitType>>(){new KeyValuePair<double, IUnitType>(passedDouble,distanceType)}, new List<KeyValuePair<double, IUnitType>>() )
        {
        }

        public Distance(string architectural):base(new List<KeyValuePair<double, IUnitType>>(), new List<KeyValuePair<double, IUnitType>>())
        {
                throw new NotImplementedException();
        }

        public Distance(GenericUnit.GenericUnit toCopy)
            : base(toCopy)
        {
        }

        public string Architectural
        {
            get
            {
                throw new NotImplementedException();
            }
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
            return (Distance) ((GenericUnit.GenericUnit) distance) ^ power;
        }

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return (Distance)(((GenericUnit.GenericUnit)distance1) + ((GenericUnit.GenericUnit)distance2));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return (Distance)(((GenericUnit.GenericUnit)distance1) - ((GenericUnit.GenericUnit)distance2));
        }

        public static Distance operator *(Distance distance, double factor)
        {
            return (Distance)((GenericUnit.GenericUnit)distance) * factor;
        }

        public static Distance operator *(double power, Distance distance)
        {
            return distance * power;
        }


        public void ToString(Inch inch)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Distance other)
        {
            throw new NotImplementedException();
        }
    }
}