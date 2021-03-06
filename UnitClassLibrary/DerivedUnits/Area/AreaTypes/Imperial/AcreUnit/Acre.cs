﻿/*
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

using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;


namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.AcreUnit
{
    public class Acre : AreaType
    {

        public override UnitDimensions Dimensions => _dimensions;
        private static readonly UnitDimensions _dimensions = new UnitDimensions(43560, new List<FundamentalUnitType>() {new Foot(), new Foot()});

        public override string Abbreviation => "acres";
    }
}