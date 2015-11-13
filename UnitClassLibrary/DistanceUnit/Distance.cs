using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : FundamentalUnit<IDistanceUnit>
    {
        public static readonly Distance Zero = new Distance(new Inch(), 0, 0);

        #region Constructors

        public Distance() : this(new Inch(), 0) { }

        public Distance(IDistanceUnit distanceUnit, double value) : base(distanceUnit, value) { }

        public Distance(IDistanceUnit distanceUnit, double value, double errorMargin)
            : base(distanceUnit, value, errorMargin)
        { }

        public Distance(string architectural)
            : this(new Inch(), _convertArchitectualStringToValueInInches(architectural), 0.03125)
        { }

        public Distance(FundamentalUnit<IDistanceUnit> toCopy) : base(toCopy) { }
        #endregion

        new public Distance Negate()
        {
            return new Distance(base.Negate());
        }

        new public Distance AbsoluteValue()
        {
            return new Distance(base.AbsoluteValue());
        }

        //public override string ToString()
        //{
        //    if (this.IntrinsicValue == 1.0)
        //    {
        //        return "";
        //    }
        //    return "";
        //}

        #region Operator Overloads
        //public static Distance operator ^(Distance distance, double power)
        //{
        //    return new Distance((();
        //}

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Add(distance2));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Subtract(distance2));
        }

        public static Distance operator *(Distance distance, double factor)
        {
            return new Distance(distance.Multiply(factor));
        }

        public static Distance operator *(double factor, Distance distance)
        {
            return distance * factor;
        }
        #endregion
    }
}