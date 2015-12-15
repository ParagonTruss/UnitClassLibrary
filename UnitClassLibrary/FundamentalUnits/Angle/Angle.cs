using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AngleUnit
{
    public class Angle : Unit<AngleType>
    {

        public Angle ModOutTwoPi { get { return this % new Angle(new Degree(), new Measurement(360, 1)); } }

        public static readonly Angle Zero = new Angle(new Degree(), new Measurement());
        public static readonly Angle RightAngle = new Angle(new Degree(), 90);
        public static readonly Angle StraightAngle = new Angle(new Degree(), 180);

        public Angle(AngleType unit, Measurement measurement) : base(unit, measurement)
        {
            
        }
        public Angle(Unit<AngleType> angle) : base(angle) { }

        public Angle Negate()
        {
            return (Angle)base.Negate();
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
            var errorMargin = m.ErrorMargin * Math.Pow(1 - m.Value * m.Value, -0.5);
            double value;
            if (1.0 < m.Value && m.Value < 1.1)
            {
                value = 0;
            }
            else if (-1.0 > m.Value && m.Value > -1.1)
            {
                value = 0;
            }
            else
            {
                value = Math.Acos(m.Value);
            }
            return new Angle(new Radian(), new Measurement(value, errorMargin));
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

            return new Angle((AngleType)angle1.UnitType, result);
        }

        public Measurement Degrees { get { return ValueInThisUnit(new Degree()); } }
        public Measurement Radians { get { return ValueInThisUnit(new Radian()); } }

        public static Angle Radian { get { return new Angle(new Radian(), 1); } }

        public static Angle Degree { get { return new Angle(new Degree(), 1); } }
    }
}
