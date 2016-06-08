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


namespace UnitClassLibrary.ForceUnit
{
    public class ForceType : FundamentalUnitType
    {
        private static Pound _defaultForceType = new Pound();
        public override double ConversionFactor
        {
            get
            {
                return _defaultForceType.ConversionFactor;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return _defaultForceType.DefaultErrorMargin;
            }
        }

        public override string AsStringSingular()
        {
            return _defaultForceType.AsStringSingular();
        }

        public override string Type
        {
           get { return nameof(ForceType); }
        }

        

        public static Force operator *(Measurement m, ForceType type)
        {
            return new Force(m, type);
        }

        public static Force operator *(double d, ForceType type)
        {
            return new Force(d, type);
        }

        public static Force operator *(int m, ForceType type)
        {
            return new Force(m, type);
        }
    }
}
