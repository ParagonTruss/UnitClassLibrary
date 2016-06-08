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
using UnitClassLibrary.AngleUnit;
using static UnitClassLibrary.Measurement;

namespace UnitClassLibrary.AngleUnit
{
    public sealed class Angle : Unit<AngleType>
    {
        public Angle ProperAngle { get { return this % FullCircle; } }

        public static Angle ZeroAngle { get { return Exactly(0, Degrees); } }
        public static Angle RightAngle { get { return Exactly(90, Degrees); } }
        public static Angle StraightAngle { get { return Exactly(180, Degrees); } }
        public static Angle FullCircle { get { return Exactly(360, Degrees); } }

        public Angle(AngleType type, Measurement measurement)
            : base(type, measurement) { }

        public Angle(Measurement measurement, AngleType type)
         : base(type, measurement) { }

        public Angle(Unit<AngleType> angle) : base(angle) { }

        public static Angle AngleWithExactError(double value, double errorMargin, AngleType type)
        {
            return new Angle(ExactUnit(type, value, errorMargin));
        }

        public static Angle Exactly(double value, AngleType type)
        {
            return AngleWithExactError(value, 0.0, type);
        }

        public Angle Supplement()
        {
            return (Angle.StraightAngle - this.ProperAngle);
        }
        public Angle Complement()
        {
            return (Angle.RightAngle - this.ProperAngle);
        }

        public new Angle AbsoluteValue()
        {
            return new Angle(base.AbsoluteValue());
        }
        public new Angle Negate()
        {
            return new Angle(base.Negate());
        }
        public static Measurement Sine(Angle angle)
        {
            var m = angle.MeasurementIn(new Radian());

            return new Measurement(Math.Sin(m.Value), Math.Cos(m.Value) * m.ErrorMargin);
        }

        public static Measurement Cosine(Angle angle)
        {
            var m = angle.MeasurementIn(new Radian());

            return new Measurement(Math.Cos(m.Value), Math.Sin(m.Value) * m.ErrorMargin);
        }

        public static Measurement Tangent(Angle angle)
        {
            var m = angle.MeasurementIn(Radians);

            return new Measurement(Math.Tan(m.Value), m.ErrorMargin / Math.Pow(Math.Cos(m.Value), 2));
        }

        public static Angle ArcCos(Measurement m)
        {
            double value;
            if (1.0 < m.Value && m.Value < 1.1)
            {
                value = 0;
            }
            else if (-1.0 > m.Value && m.Value > -1.1)
            {
                value = Math.PI;
            }
            else
            {
                value = Math.Acos(m.Value);
            }
            double error;
            var d1 = Math.Acos(m.Value + m.ErrorMargin);
            var d2 = Math.Acos(m.Value - m.ErrorMargin);
            if (Double.IsNaN(d1))
            {
                error = d2 - value;
            }
            else if (Double.IsNaN(d2))
            {
                error = value - d1;
            }
            else
            {
                error = Math.Max(d2 - value, value - d1);
            }
            return new Angle(new Measurement(value, error), Radians);
        }

        public static Angle ArcSin(Measurement m)
        {
            var errorMargin = m.ErrorMargin * Math.Pow(1 - m.Value * m.Value, -0.5);
            double value;
            if (1.0 < m.Value && m.Value < 1.1)
            {
                value = 90;
            }
            else if (-1.0 > m.Value && m.Value > -1.1)
            {
                value = -90;
            }
            else
            {
                value = Math.Asin(m.Value);
            }
            return new Angle(new Degree(),new Measurement(value, errorMargin));
        }

        //public Angle Reverse()
        //{
        //    throw new NotImplementedException();
        //}

        public static Angle operator +(Angle angle1, Angle angle2)
        {
            return new Angle((angle1.Add(angle2)));
        }

        public static Angle operator -(Angle angle1, Angle angle2)
        {
            return new Angle(angle1.Subtract(angle2));
        }

        public static Angle operator *(Angle angle, Measurement scalar)
        {
            return new Angle(angle._Multiply(scalar));
        }

        public static Angle operator *(Measurement scalar, Angle angle)
        {
            return angle * scalar;
        }

        public static Angle operator /(Angle angle, Measurement divisor)
        {
            return new Angle(angle._Divide(divisor));
        }
        public static Angle operator %(Angle angle1, Angle angle2)
        {
            return new Angle(angle1.Mod(angle2));
        }

        public Measurement InDegrees { get { return MeasurementIn(new Degree()); } }
        public Measurement InRadians { get { return MeasurementIn(new Radian()); } }

        // Only marginally usefull.
        // Names are too similar to the methods below, and we want people to use those ones.
        //public static Angle Radian { get { return new Angle(1, Radians); } }
        //public static Angle Degree { get { return new Angle(1, Degrees); } }

        public static AngleType Radians { get { return new Radian(); } }
        public static AngleType Degrees { get { return new Degree(); } }
    }
}
