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
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes
{
    public class DistanceType : FundamentalUnitType
    {
        private static Inch _defaultDistanceType = new Inch(); 
        public override double ConversionFactor => _defaultDistanceType.ConversionFactor;

        public override double DefaultErrorMargin => _defaultDistanceType.DefaultErrorMargin;

        public override string Type => nameof(DistanceType);

        public override string Abbreviation => _defaultDistanceType.Abbreviation;

        //public static Distance operator *(Measurement m, DistanceType type)
        //{
        //    return new Distance(m, type);
        //}

        public static Distance operator *(double d, DistanceType type)
        {
            return new Distance(d, type);
        }

        public static Distance operator *(int m, DistanceType type)
        {
            return new Distance(m, type);
        }
    }
}