using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AngleUnit
{
    public class Angle : Unit<AngleType>
    {
        public static readonly Angle Zero = new Angle(new Degree(), new Measurement());
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
            throw new NotImplementedException();
        }

        public static Angle ArcSin(Measurement m)
        {
            throw new NotImplementedException();
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
