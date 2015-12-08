using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : Unit<DistanceType>
    {
        #region Constructors

        public Distance(DistanceType distanceUnit, double value) : base(distanceUnit, value) { }

        public Distance(DistanceType distanceUnit, Measurement measurement)
            : base(distanceUnit, measurement) { }


        public Distance(string architectural)
            : this(new Inch(), _convertArchitectualStringToValueInInches(architectural))
        { }

        public Distance(Unit<DistanceType> unit) : base(unit)
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

        #region Static Properties
        public static readonly Distance Zero = new Distance(new Inch(), new Measurement());

        public static readonly Distance Inch = new Distance(new Inch(), new Measurement(1));
        public static readonly Distance Foot = new Distance(new Foot(), new Measurement(1));
        public static readonly Distance Millimeter = new Distance(new Millimeter(), new Measurement(1));

        public Measurement Inches { get { return ValueInThisUnit(new Inch()); } }
        public Measurement Centimeters { get { return ValueInThisUnit(new Centimeter()); } }

        #endregion
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