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


namespace UnitClassLibrary.DerivedUnits
{
    public class MomentType : AbstractDerivedUnitType
    {
        private static PoundInch _defaultMomentType = new PoundInch();
        public override string AsStringSingular()
        {
            return _defaultMomentType.AsStringSingular();
        }
        public override string AsStringPlural()
        {
            return _defaultMomentType.AsStringPlural();
        }

        public override UnitDimensions Dimensions => _defaultMomentType.Dimensions;

        public override double DefaultErrorMargin => 0.01;

        //public static Moment operator *(Measurement m, MomentType type)
        //{
        //    return new Moment(m, type);
        //}

        public static Moment operator *(double d, MomentType type)
        {
            return new Moment(d, type);
        }

        public static Moment operator *(int m, MomentType type)
        {
            return new Moment(m, type);
        }
    }
}
