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
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class MeasurementExtensions
    {
        public static Unit<T> ToUnit<T>(this Measurement m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }

        public static Unit<T> ToUnit<T>(this double m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }

        public static Unit<T> ToUnit<T>(this int m, T unitType)
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }

        public static double Value(this double number)
        {
            return number;
        }

        public static double SquareRoot(this double number)
        {
            return Math.Sqrt(number);
        }

        public static double ToThe(this double number, double power)
        {
            return Math.Pow(number, power);
        }

    }
}
