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
    public sealed partial class Force : Unit<ForceType>
    {
        public Force(ForceType type, Measurement value) : base(type,value)
        {
            
        }
        public Force(Measurement value, ForceType type) : base(type, value)
        {

        }

        public Force(Unit<ForceType> unit) : base(unit)
        {
                
        }
        #region Static Properties
        public static readonly Force ZeroForce = new Force(new Pound(), new Measurement());

        public static ForceType Pounds => new Pound();
        public Measurement InPounds => this.MeasurementIn(Pounds);

        #endregion
        #region Public Methods
#endregion
        #region Arithmetic Operators

        public static Force operator +(Force force1, Force force2)
        {
            return new Force(force1.Add(force2));
        }

        public static Force operator -(Force force1, Force force2)
        {
            return new Force(force1.Subtract(force2));
        }

        public static Force operator *(Force force, Measurement scalar)
        {
            return new Force(force._Multiply(scalar));
        }

        public static Force operator *(Measurement scalar, Force force)
        {
            return force * scalar;
        }

        public static Force operator /(Force force, Measurement divisor)
        {
            return new Force(force._Divide(divisor));
        }
        #endregion
    }
}
