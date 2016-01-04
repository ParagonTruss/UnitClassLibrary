using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit;
using Newtonsoft.Json;

namespace UnitClassLibrary.DistanceUnit
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Distance : Unit<DistanceType>
    {
        #region Constructors
        
        public Distance(DistanceType distanceUnit, double value) : base(distanceUnit, value) { }

        [JsonConstructor]
        public Distance(DistanceType distanceUnit, Measurement measurement)
            : base(distanceUnit, measurement) { }

        public Distance(Measurement measurement, DistanceType distanceType)
            : base(distanceType, measurement) { }

        public Distance(string architectural)
            : this(new Inch(), _convertArchitectualStringToValueInInches(architectural)) { }

        public Distance(Unit<DistanceType> unit)
            : base(unit) { }

        public Distance(Unit unit, DistanceType type)
            : base(type, unit) { }
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
        public static Distance ZeroDistance { get { return new Distance(Exactly(0, Inches)); } }

        // Only marginally usefull.
        // Names are too similar to the methods below, and we want people to use those ones.
        //public static readonly Distance Inch = new Distance(new Inch(), new Measurement(1));
        //public static readonly Distance Foot = new Distance(new Foot(), new Measurement(1));
        //public static readonly Distance Millimeter = new Distance(new Millimeter(), new Measurement(1));

        public static DistanceType Inches { get { return new Inch(); } }
        public static DistanceType Feet { get { return new Foot(); } }
        public static DistanceType Millimeters { get { return new Millimeter(); } }
        public static DistanceType Centimeters { get { return new Centimeter(); } }

        public Measurement InInches { get { return ValueIn(Inches); } }
        public Measurement InFeet { get { return ValueIn(Feet); } }
        public Measurement InMillimeters { get { return ValueIn(Millimeters); } }
        public Measurement InCentimeters { get { return ValueIn(Centimeters); } }

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