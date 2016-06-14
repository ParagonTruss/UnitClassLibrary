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

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class DistributedForce : Unit<ForcePerDistanceType>
    {
        public Measurement InPoundsPerInch { get { return ValueIn(new PoundPerInch()); } }

        public DistributedForce(Unit<ForcePerDistanceType> unit)
            : base(unit) { }

        public static DistributedForce Zero { get { return new DistributedForce(Exactly(0, new PoundPerInch())); } }
        #region Arithmetic Operators

        public static DistributedForce operator +(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Add(DistributedForce2));
        }

        public static DistributedForce operator -(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Subtract(DistributedForce2));
        }

        public static DistributedForce operator *(DistributedForce DistributedForce, Measurement scalar)
        {
            return new DistributedForce(DistributedForce._Multiply(scalar));
        }

        public static DistributedForce operator *(Measurement scalar, DistributedForce DistributedForce)
        {
            return DistributedForce * scalar;
        }

        public static DistributedForce operator /(DistributedForce DistributedForce, Measurement divisor)
        {
            return new DistributedForce(DistributedForce._Divide(divisor));
        }
        #endregion
    }
}
