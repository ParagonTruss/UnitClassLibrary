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
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;


namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.SquareInchesUnit
{
    public class SquareInch : AreaType
    {
        
        public override string AsStringPlural(){ return "Square Inches"; } 
        public override string AsStringSingular() { return "Square Inch"; }

        public override UnitDimensions Dimensions => _dimensions;
        private static readonly UnitDimensions _dimensions = new UnitDimensions(1, new List<FundamentalUnitType>() {new Inch(), new Inch()});
    }
}