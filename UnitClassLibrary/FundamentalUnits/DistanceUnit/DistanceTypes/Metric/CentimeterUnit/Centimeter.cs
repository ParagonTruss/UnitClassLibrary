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

namespace UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit
{
    public class Centimeter : DistanceType
    {
        public override string AsStringSingular()
        {
            return "Centimeter";
        }

        public override double ConversionFactor => 0.393700787401575D;

        public override double DefaultErrorMargin => new Inch().DefaultErrorMargin / ConversionFactor;
    }

    public static class CentimeterExtensions
    {
        public static Distance FromCentimetersToDistance(this double passedDouble)
        {
            return new Distance(new Centimeter(), passedDouble);
        }

        public static Distance FromCentimetersToDistance(this int passedint)
        {
            return new Distance(new Centimeter(), passedint);
        }

        public static double AsCentimeters(this Distance passedDistance)
        {
            return passedDistance.ConversionFromThisTo(new Centimeter());
        }
    }
}
