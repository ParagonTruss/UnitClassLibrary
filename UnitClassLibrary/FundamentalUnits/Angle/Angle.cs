using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.FundamentalUnits;
using static UnitClassLibrary.FundamentalUnits.AngleTypeFactory;
using static UnitClassLibrary.Measurement;

namespace UnitClassLibrary.AngleUnit
{
    public class Angle : Unit<AngleType>
    {
        public Angle AsLessThanAFullCircle { get { return this % FullCircle; } }

        public static Angle Zero { get { return new Angle(Exactly(0), Degrees); } }
        public static Angle RightAngle { get { return new Angle(Exactly(90), Degrees); } }
        public static Angle StraightAngle { get { return new Angle(Exactly(180), Degrees); } }
        public static Angle FullCircle { get { return new Angle(Exactly(360), Degrees); } }

        public Angle(AngleType type, Measurement measurement)
            : base(type, measurement) { }

        public Angle(Measurement measurement, AngleType type)
         : base(type, measurement) { }

        public Angle(Unit<AngleType> angle) : base(angle) { }

        public new Angle Negate()
        {
            return new Angle(base.Negate());
        }
        public static Measurement Sine(Angle angle)
        {
            var m = angle.ValueInThisUnit(new Radian());

            return new Measurement(Math.Sin(m.Value), Math.Cos(m.Value) * m.ErrorMargin);
        }

        public static Measurement Cosine(Angle angle)
        {
            var m = angle.ValueInThisUnit(new Radian());

            return new Measurement(Math.Cos(m.Value), Math.Sin(m.Value) * m.ErrorMargin);
        }

        public static Measurement Tangent(Angle angle)
        {
            var m = angle.ValueInThisUnit(new Radian());

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

        public Angle Reverse()
        {
            throw new NotImplementedException();
        }

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
            return new Angle(angle.Multiply(scalar));
        }

        public static Angle operator *(Measurement scalar, Angle angle)
        {
            return angle * scalar;
        }

        public static Angle operator /(Angle angle, Measurement divisor)
        {
            return new Angle(angle.Divide(divisor));
        }
        public static Angle operator %(Angle angle1, Angle angle2)
        {
            var value1 = angle1.Measurement;
            var value2 = angle2.ValueInThisUnit(angle1.UnitType).Value;

            var result = value1 % value2;

            if (result < 0)
            {
                result += value2;
            }

            return new Angle((AngleType)angle1.UnitType, result);
        }

        public Measurement InDegrees { get { return ValueInThisUnit(new Degree()); } }
        public Measurement InRadians { get { return ValueInThisUnit(new Radian()); } }

        public static Angle Radian { get { return new Angle(1, Radians); } }

        public static Angle Degree { get { return new Angle(1, Degrees); } }

        public static AngleType Radians { get { return new Radian(); } }
        public static AngleType Degrees { get { return new Degree(); } }
    }
}
