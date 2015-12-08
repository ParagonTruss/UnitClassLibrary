using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.GenericUnit
{
    public struct Measurement : IEquatable<Measurement>
    {
        public static implicit operator Measurement(double d)
        {
            return new Measurement(d);
        }

        public readonly double Value;
        public readonly double ErrorMargin;
        public double PercentageError { get { return ErrorMargin / Value; } }

        public Measurement(double intrinsicValue)
        {
            this.Value = intrinsicValue;
            this.ErrorMargin = 0;
        }

        public Measurement(double intrinsicValue, double errorMargin)
        {
            this.Value = intrinsicValue;
            this.ErrorMargin = Math.Abs(errorMargin);
        }

        public Measurement SquareRoot()
        {
            var sqrt = Math.Sqrt(this.Value);
            return new Measurement(sqrt, this.ErrorMargin / (2 * sqrt));
        }

        public Measurement Negate()
        {
            return this.Multiply(-1.0);
        }

        public Measurement AbsoluteValue()
        {
            return new Measurement(Math.Abs(Value), ErrorMargin);
        }

        public Measurement ToThe(Measurement m)
        {
            return new Measurement(Math.Pow(this.Value, m.Value), m.Value * Math.Pow(this.Value, m.Value - 1) * this.ErrorMargin + Math.Log(this.Value) * Math.Pow(this.Value, m.Value) * m.ErrorMargin);
        }

        public Measurement ToThe(int n)
        {
            var result = new Measurement(1, 0);
            for (int i = 0; i < Math.Abs(n); i++)
            {
                result *= this;
            }
            if (n < 0)
            {
                return 1 / result;
            }
            else
            {
                return result;
            }
        }

        public Measurement Add(Measurement value)
        {
            return new Measurement(this.Value + value.Value, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Subtract(Measurement value)
        {
            return new Measurement(this.Value - value.Value, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Multiply(Measurement m)
        {
            return new Measurement(this.Value * m.Value, this.Value * m.ErrorMargin + m.Value * this.ErrorMargin);
        }
        public Measurement Divide(Measurement m)
        {
            return new Measurement(this.Value / m.Value, this.Value * m.ErrorMargin / (m.Value * m.Value) + this.ErrorMargin / m.Value);
        }
        public Measurement Mod(Measurement m)
        {
            return new Measurement(this.Value % m.Value, this.ErrorMargin + m.ErrorMargin * Math.Floor(this.Value / m.Value));
        }
        public bool LessThan(Measurement m)
        {
            return this.Value < m.Value;
        }
        public bool GreaterThan(Measurement m)
        {
            return this.Value > m.Value;
        }
        public bool Equals(Measurement m)
        {
            return Math.Abs(this.Value - m.Value) <= (this.ErrorMargin + m.ErrorMargin);
        }

        #region Operator Overloads
        public static Measurement operator +(Measurement m1, Measurement m2)
        {
            return m1.Add(m2);
        }
        public static Measurement operator -(Measurement m1, Measurement m2)
        {
            return m1.Subtract(m2);
        }
        public static Measurement operator *(Measurement m1, Measurement m2)
        {
            return m1.Multiply(m2);
        }
        public static Measurement operator /(Measurement m1, Measurement m2)
        {
            return m1.Divide(m2);
        }
        public static Measurement operator %(Measurement m1, Measurement m2)
        {
            return m1.Mod(m2);
        }
        public static Measurement operator ^(Measurement m, int n)
        {
            return m.ToThe(n);
        }
        public static Measurement operator ^(Measurement m1, Measurement m2)
        {
            return m1.ToThe(m2);
        }
        public static bool operator <(Measurement m1, Measurement m2)
        {
            return m1.LessThan(m2);
        }
        public static bool operator >(Measurement m1, Measurement m2)
        {
            return m1.GreaterThan(m2);
        }
        public static bool operator ==(Measurement m1, Measurement m2)
        {
            return m1.Equals(m2);
        }
        public static bool operator !=(Measurement m1, Measurement m2)
        {
            return !m1.Equals(m2);
        }
        public static bool operator <=(Measurement m1, Measurement m2)
        {
            return m1 < m2 || m1 == m2;
        }
        public static bool operator >=(Measurement m1, Measurement m2)
        {
            return m1 > m2 || m1 == m2;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            // valus plus/minus error
            return String.Format("{0} {1} {2}", this.Value, "±", this.ErrorMargin);
        }
        #endregion
    }
}
