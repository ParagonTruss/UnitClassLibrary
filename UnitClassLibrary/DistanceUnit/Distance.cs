using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : GenericUnit.GenericUnit, IComparable<Distance>
    {
        public Distance():this(new Inch(), 0){}

        public Distance(IDistanceType distanceType, double passedDouble):base(new List<KeyValuePair<double, IUnitType>>(){new KeyValuePair<double, IUnitType>(passedDouble,distanceType)}, new List<KeyValuePair<double, IUnitType>>() )
        {
            
        }

        public Distance(string architectural):this(new Inch(), ConvertArchitectualStringtoUnit(new Inch(), architectural))
        {
            
        }

        private Distance(GenericUnit.GenericUnit toCopy)
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
            return new Distance( ((GenericUnit.GenericUnit) distance) ^ power);
        }

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance((((GenericUnit.GenericUnit)distance1) + ((GenericUnit.GenericUnit)distance2)));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance((((GenericUnit.GenericUnit)distance1) - ((GenericUnit.GenericUnit)distance2)));
        }

        public static Distance operator *(Distance distance, double factor)
        {
            return new Distance(((GenericUnit.GenericUnit)distance) * factor);
        }

        public static Distance operator *(double power, Distance distance)
        {
            return distance * power;
        }


        public void ToString(Inch inch)
        {
            throw new NotImplementedException();
        }

        //public int CompareTo(Distance other)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        ///// </summary>
        //public static bool operator ==(Distance d1, Distance d2)
        //{
        //    if ((object)d1 == null)
        //    {
        //        if ((object)d2 == null)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    return d1.Equals(d2);
        //}

        ///// <summary>
        ///// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        ///// </summary>
        //public static bool operator !=(Distance d1, Distance d2)
        //{
        //    if ((object)d1 == null)
        //    {
        //        if ((object)d2 == null)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //    return !d1.Equals(d2);
        //}

        ///// <summary>
        ///// greater than
        ///// </summary>
        ///// <param name="d1"></param>
        ///// <param name="d2"></param>
        ///// <returns></returns>
        //public static bool operator >(Distance d1, Distance d2)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// less than
        ///// </summary>
        ///// <param name="d1"></param>
        ///// <param name="d2"></param>
        ///// <returns></returns>
        //public static bool operator <(Distance d1, Distance d2)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Less than or equal to
        ///// </summary>
        ///// <param name="d1"></param>
        ///// <param name="d2"></param>
        ///// <returns></returns>
        //public static bool operator <=(Distance d1, Distance d2)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Greater than or equal to
        ///// </summary>
        ///// <param name="d1"></param>
        ///// <param name="d2"></param>
        ///// <returns></returns>
        //public static bool operator >=(Distance d1, Distance d2)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// This override determines how this object is inserted into hashtables.
        ///// </summary>
        ///// <returns>same hashcode as any double would</returns>
        //public override int GetHashCode()
        //{
        //    throw new NotImplementedException();
        //}


        ///// <summary>
        ///// calls the Dimension only Equals method
        ///// </summary>
        //public override bool Equals(object obj)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Compares using the function specified by strategy
        ///// </summary>
        ///// <param name="other"></param>
        ///// <returns></returns>
        //public bool Equals(Distance other)
        //{
        //    throw new NotImplementedException();
        //}
        public int CompareTo(Distance other)
        {
            throw new NotImplementedException();
        }
    }
}