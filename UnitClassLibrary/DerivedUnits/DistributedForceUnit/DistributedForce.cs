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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.DistributedForceUnit
{
    public class DistributedForce : Unit<DistributedForceType>
    {
        public DistributedForce(double value, DistributedForceType type)
            : base(type, value) { }

        public DistributedForce(Unit<DistributedForceType> unit)
            : base(unit) { }

        public DistributedForce(Unit unit)
            : base(PoundsPerInch, unit) { }

        public static DistributedForce Zero => new DistributedForce(Exactly(0, new PoundPerInch()));

        #region Arithmetic Operators

        public static DistributedForce operator +(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Add(DistributedForce2));
        }

        public static DistributedForce operator -(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Subtract(DistributedForce2));
        }

        public static DistributedForce operator *(DistributedForce DistributedForce, double scalar)
        {
            return new DistributedForce(DistributedForce._Multiply(scalar));
        }

        public static DistributedForce operator *(double scalar, DistributedForce DistributedForce)
        {
            return DistributedForce * scalar;
        }

        public static DistributedForce operator /(DistributedForce DistributedForce, double divisor)
        {
            return new DistributedForce(DistributedForce._Divide(divisor));
        }
        #endregion

        public Measurement InPoundsPerInch => ValueIn(new PoundPerInch());
        public static DistributedForceType PoundsPerInch => new PoundPerInch();

        public Measurement InPoundsPerFoot => ValueIn(new PoundPerFoot());
        public static DistributedForceType PoundsPerFoot => new PoundPerFoot();

        public Measurement InNewtonsPerMeter => ValueIn(new NewtonPerMeter());
        public static DistributedForceType NewtonsPerMeter => new NewtonPerMeter();

        public Measurement InKilonewtonsPerMeter => ValueIn(new KilonewtonPerMeter());
        public static DistributedForceType KilonewtonsPerMeter => new KilonewtonPerMeter();
    }
}
