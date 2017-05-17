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
    public class Moment : Unit<MomentType>
    {

        public Moment(double number, MomentType type) : base(type, number)
        {
                
        }

        public Moment(Unit<MomentType> moment) : base(moment)
        {
        }

        public Moment(MomentType unit, Measurement measurement) : base(unit, measurement)
        {
        }

        public static Moment ZeroMoment => new Moment(Exactly(0, new PoundInch()));

        // naming is a little off. should be InchPounds.
        public Measurement InPoundInches => MeasurementIn(new PoundInch());
        public static MomentType PoundInches => new PoundInch();

        public Measurement InFootPounds => MeasurementIn(new FootPound());
        public static MomentType FootPounds => new FootPound();

        #region Operator Overloads

        public static Moment operator +(Moment moment1, Moment moment2)
        {
            return new Moment(moment1.Add(moment2));
        }

        public static Moment operator -(Moment moment1, Moment moment2)
        {
            return new Moment(moment1.Subtract(moment2));
        }

        public static Moment operator *(Moment moment, double scalar)
        {
            return new Moment(moment._Multiply(scalar));
        }

        public static Moment operator *(double scalar, Moment moment)
        {
            return moment * scalar;
        }

        public static Moment operator /(Moment moment, double divisor)
        {
            return new Moment(moment._Divide(divisor));
        }
        #endregion
    }
}
