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

namespace UnitClassLibrary.DerivedUnits.StressUnit
{
    public class Stress : Unit<StressType>
    {
        public static Stress ZeroStress => new Stress(Exactly(0, PSI));

        #region Constructors
        public Stress(double value, StressType type) : base(type, value)
        {

        }
        public Stress(StressType type, double value) :  base(type, value)
        {
                
        }

        public Stress(Unit<StressType> stress) : base(stress)
        {
        }
        #endregion

        public Measurement InPSI => MeasurementIn(new PoundPerSquareInch());

        public static StressType PSI => new PoundPerSquareInch();

        #region Operator Overloads

        public static Stress operator +(Stress stress1, Stress stress2)
        {
            return new Stress(stress1.Add(stress2));
        }

        public static Stress operator -(Stress stress1, Stress stress2)
        {
            return new Stress(stress1.Subtract(stress2));
        }

        public static Stress operator *(Stress stress, double scalar)
        {
            return new Stress(stress._Multiply(scalar));
        }

        public static Stress operator *(double scalar, Stress stress)
        {
            return stress * scalar;
        }

        public static Stress operator /(Stress stress, double divisor)
        {
            return new Stress(stress._Divide(divisor));
        }
        #endregion
    }
}
