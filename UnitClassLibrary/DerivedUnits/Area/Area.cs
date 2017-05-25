/*
    This file is part of Unit Class Library.
    Copyright (C) 2017 Paragon Component Systems, LLC.

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
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.SquareInchesUnit;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area : Unit<AreaType>
    {
        public static readonly Area Zero = new Area(new SquareInch(), 0);

        public Area(Unit unit) : this(new SquareInch(), unit)
        {
        }

        public Area(Measurement measurement, AreaType areaType) : base(areaType, measurement)
        {
        }

        public Area(AreaType AreaType, double measurement)
            : base(AreaType, measurement)
        {
        }
        public Area(AreaType unit, Measurement measurement) : base(unit, measurement)
        {
        }
        public Area(AreaType type, Unit unitToConvert) : base(type, unitToConvert)
        {

        }
        public static AreaType SquareInches => new SquareInch();
        public Measurement InSquareInches => MeasurementIn(new SquareInch());

        public Distance SquareRoot()
        {
            var value = this.ValueIn(new SquareInch()).SquareRoot();
            return new Distance(new Inch(), value);
        }
    }
}