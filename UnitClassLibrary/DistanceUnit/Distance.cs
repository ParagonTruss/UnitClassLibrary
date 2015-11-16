using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : Unit<IDistanceType>
    {
        public static readonly Distance Zero = new Distance(new Inch(), new Measurement());

        #region Constructors

        public Distance(IDistanceType distanceUnit, double value) : base(distanceUnit, value) { }

        public Distance(IDistanceType distanceUnit, Measurement measurement)
            : base(distanceUnit, measurement) { }


        public Distance(string architectural)
            : this(new Inch(), _convertArchitectualStringToValueInInches(architectural))
        { }

        public Distance(Unit<IDistanceType> unit) : base(unit.UnitType, unit.Measurement)
        {

        }
        #endregion

        new public Distance Negate()
        {
            return new Distance(base.Negate());
        }

        new public Distance AbsoluteValue()
        {
            return new Distance(base.Negate());
        }

        

        #region Operator Overloads

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance((distance1.Add(distance2)));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Subtract(distance2));
        }

        public static Distance operator *(Distance distance, Measurement scalar)
        {
            return new Distance(distance.Multiply(scalar));
        }

        public static Distance operator *(Measurement scalar, Distance distance)
        {
            return distance * scalar;
        }

        public static Distance operator /(Distance distance, Measurement divisor)
        {
            return new Distance(distance.Divide(divisor));
        }
        #endregion
    }
}