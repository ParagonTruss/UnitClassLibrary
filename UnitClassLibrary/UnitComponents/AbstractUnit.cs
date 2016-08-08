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
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public abstract class Unit
    {
        public abstract IUnitType UnitType { get; }
        public abstract Measurement Measurement { get; }

        public double ConversionFactor => UnitType.ConversionFactor;
        public UnitDimensions Dimensions => UnitType.Dimensions;

        public double ConversionFromThisTo(IUnitType unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }

        public bool IsPositive()
        {
            return Measurement.Value > 0;
        }

        public bool IsNegative()
        {
            return Measurement.Value < 0;
        }

        public Measurement MeasurementIn(IUnitType unitType)
        {
            var result = this.Measurement * ConversionFromThisTo(unitType);
            return result;
        }

        public double ValueIn(IUnitType unitType)
        {
            return this.Measurement.Value*ConversionFromThisTo(unitType);
        }

        //public abstract Unit Invert();
        //public abstract Unit Multiply(Unit unit);
        //abstract public Unit<T> Multiply<T>(double scalar) where T : IUnitType;
        //abstract public Unit<T> Divide<T>(double divisor) where T : IUnitType;

        public abstract Unit Multiply(double scalar);
        public abstract Unit Divide(double divisor);


        //public Unit Divide(Unit unit)
        //{
        //    return this.Multiply(unit.Invert());
        //}


        //public static Unit operator *(Unit unit1, Unit unit2)
        //{
        //    return unit1.Multiply(unit2);
        //}
        public static Unit operator *(Unit unit, double number)
        {
            return unit.Multiply(number);
        }
        public static Unit operator *(double number, Unit unit)
        {
            return unit*number;
        }
        //public static Unit operator /(Unit unit1, Unit unit2)
        //{
        //    return unit1.Divide(unit2);
        //}
        public static Unit operator /(Unit unit, double divisor)
        {
            return unit.Divide(divisor);
        }
        public static bool operator ==(Unit unit1, Unit unit2)
        {
            return _HaveTheSameDimensions(unit1, unit2) && _ValuesAreEqual(unit1, unit2);
        }
        public static bool operator !=(Unit unit1, Unit unit2)
        {
            return !(unit1 == unit2);
        }

        protected static bool _HaveTheSameDimensions(Unit unit1, Unit unit2)
        {
            return UnitDimensions.HaveSameDimensions(unit1.UnitType.Dimensions, unit2.UnitType.Dimensions);
        }
        protected static bool _ValuesAreEqual(Unit unit1, Unit unit2)
        {
            return unit1.Measurement == unit2.MeasurementIn(unit1.UnitType);
        }
    }
}
