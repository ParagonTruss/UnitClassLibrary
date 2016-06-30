/*
    This file is part of Unit Class Library.
    Copyright (C) 2016 Paragon Component Systems, LLC.

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit;
using Newtonsoft.Json;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.KilometerUnit;

namespace UnitClassLibrary.DistanceUnit
{
    public sealed partial class Distance : Unit<DistanceType>
    {
        
        #region Constructors
        
        public Distance(DistanceType distanceUnit, double value) : base(distanceUnit, value) { }

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
            return new Distance(base.AbsoluteValue());
        }

        #region Static Properties
        private static readonly Distance _zeroDistance = new Distance(Exactly(0, Inches));
        public static Distance ZeroDistance => _zeroDistance;

        public static DistanceType Inches => new Inch();
        public static DistanceType Feet => new Foot();
        public static DistanceType Millimeters => new Millimeter();
        public static DistanceType Centimeters => new Centimeter();
        public static DistanceType Kilometers => new Kilometer();

        [Obsolete("Please use Value in Inches instead.")]
        public Measurement InInches => MeasurementIn(Inches);
        [Obsolete("Please use Value in Feet instead.")]
        public Measurement InFeet => MeasurementIn(Feet);
        [Obsolete("Please use Value in Millimeters instead.")]
        public Measurement InMillimeters => MeasurementIn(Millimeters);
        [Obsolete("Please use Value in Centimeters instead.")]
        public Measurement InCentimeters => MeasurementIn(Centimeters);

        public double ValueInInches => ValueIn(Inches);
        public double ValueInFeet => ValueIn(Feet);
        public double ValueInMillimeters => ValueIn(Millimeters);
        public double ValueInCentimeters => ValueIn(Centimeters);

        public static Distance QuarterInch => new Distance(Exactly(0.25, Inches));
        public static Distance SixteenthInch => new Distance(Exactly(0.0375, Inches));

        #endregion
        #region Operator Overloads

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Add(distance2));
        }

        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Subtract(distance2));
        }

        public static Distance operator *(Distance distance, Measurement scalar)
        {
            return new Distance(distance._Multiply(scalar));
        }

        public static Distance operator *(Measurement scalar, Distance distance)
        {
            return distance * scalar;
        }

        public static Distance operator /(Distance distance, Measurement divisor)
        {
            return new Distance(distance._Divide(divisor));
        }
        #endregion
    }
}