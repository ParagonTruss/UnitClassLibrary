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

namespace UnitClassLibrary.AngleUnit
{
    public class Radian : AngleType
    {
        public static readonly Radian s = new Radian();

        override public string AsStringPlural()
        {
            return "Radians";
        }

        override public string AsStringSingular()
        {
            return "Radian";
        }

        override public double ConversionFactor
        {
            get
            {
                // 180 / pi. Degrees are the standard unit.
                return 57.2957795131D;
            }
        }

        override public double DefaultErrorMargin
        {
            get
            {
                return new Degree().DefaultErrorMargin / this.ConversionFactor;
            }
        }
    }
}
