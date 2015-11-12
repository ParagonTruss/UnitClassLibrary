using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;

namespace UnitClassLibrary.GenericUnit
{
    public struct Measurement
    {
        public static implicit operator Measurement(double d)
        {
            return new Measurement(d, 0);
        }
        
        public readonly double Value;
        public readonly double ErrorMargin;
        public double PercentageError { get { return ErrorMargin / Value; } }
        public Measurement(double intrinsicValue, double errorMargin)
        {
            this.Value = intrinsicValue;
            this.ErrorMargin = Math.Abs(errorMargin);
        }

        public Measurement Negate()
        {
            return this.Multiply(-1.0);
        }

        public Measurement AbsoluteValue()
        {
            return new Measurement(Math.Abs(Value), ErrorMargin);
        }

        public Measurement Add(Measurement value)
        {
            return new Measurement(this.Value + value.Value, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Subtract(Measurement value)
        {
            return new Measurement(this.Value - value.Value, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Multiply(double scalar)
        {
            return new Measurement(scalar * this.Value, scalar * this.ErrorMargin);
        }
        public Measurement Divide(double divisor)
        {
            return new Measurement(this.Value / divisor, this.ErrorMargin / divisor);
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

        public static Measurement operator +(Measurement m1, Measurement m2)
        {
            return m1.Add(m2);
        }
        public static Measurement operator -(Measurement m1, Measurement m2)
        {
            return m1.Subtract(m2);
        }
        public static Measurement operator *(Measurement m, double scalar)
        {
            return m.Multiply(scalar);
        }
        public static Measurement operator *(double scalar, Measurement m)
        {
            return m.Multiply(scalar);
        }
        public static Measurement operator /(Measurement m, double divisor)
        {
            return m.Divide(divisor);
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
    }
    public class BasicUnit
    {
        public IUnit Unit;
        public Measurement Measurement;

        public double IntrinsicValue { get { return Measurement.Value; } }
        public double ErrorMargin { get { return Measurement.ErrorMargin; } }
        public double ConversionFactor { get { return Unit.ConversionFactor; } }
        protected BasicUnit() { }

        protected BasicUnit(IUnit unit, double intrinsicValue, double errorMargin)
        {
            this.Unit = unit;
            this.Measurement = new Measurement(intrinsicValue, errorMargin);
        }

        public BasicUnit(BasicUnit toCopy)
        {
            this.Unit = toCopy.Unit;
            this.Measurement = toCopy.Measurement;
        }

        public BasicUnit(IUnit unit, Measurement value)
        {
            this.Unit = unit;
            this.Measurement = value;
        }

        public double ConversionFromThisTo(IUnit unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }
        public Measurement InThisUnit(IUnit unit)
        {
            return this.Measurement * ConversionFromThisTo(unit);
        }
    }

    public class BasicUnit<T> : BasicUnit where T : IUnit
    {
        #region Constructors
        protected BasicUnit() { }

        public BasicUnit(IUnit unit, double value) : this(unit, value, _defaultErrorMargin(unit, value)) { }

        private static double _defaultErrorMargin(IUnit unit, double value)
        {
            //Stub for now;
            return 0.03125;
        }

        public BasicUnit(IUnit unit, double value, double errorMargin) : base(unit, value, errorMargin) { }
        public BasicUnit(IUnit unit, Measurement value) : base(unit, value) { }
        public BasicUnit(BasicUnit toCopy) : base(toCopy) { }
        #endregion
        
        #region Fields & Properties
        public double ConversionFactor { get { return Unit.ConversionFactor; } }
        #endregion

        #region Public Methods

        public BasicUnit<T> Negate()
        {
            return new BasicUnit<T>(this.Unit, -1.0 * this.IntrinsicValue, this.ErrorMargin);
        }

        public BasicUnit<T> AbsoluteValue()
        {
            return new BasicUnit<T>(this.Unit, Math.Abs(this.IntrinsicValue), this.ErrorMargin);
        }

        public BasicUnit<T> Add(BasicUnit<T> unit)
        {
            return new BasicUnit<T>(this.Unit, this.Measurement.Add(unit.Measurement.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public BasicUnit<T> Subtract(BasicUnit<T> unit)
        {
            return new BasicUnit<T>(this.Unit, this.Measurement.Subtract(unit.Measurement.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public BasicUnit<T> Multiply(double scalar)
        {
            return new BasicUnit<T>(this.Unit, this.Measurement.Multiply(scalar));
        }
        public BasicUnit<T> Divide(double divisor)
        {
            return new BasicUnit<T>(this.Unit, this.Measurement.Divide(divisor));
        }
        public int CompareTo(BasicUnit<T> other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            else
            {
                return IntrinsicValue.CompareTo(other.InThisUnit(other.Unit).Value);
            }
        }
        #endregion

        #region Operator Overloads
        public static BasicUnit<T> operator +(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Add(unit2);
        }
        public static BasicUnit<T> operator -(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Subtract(unit2);
        }
        public static BasicUnit<T> operator *(double scalar, BasicUnit<T> unit)
        {
            return unit.Multiply(scalar);
        }
        public static BasicUnit<T> operator *(BasicUnit<T> unit, double scalar)
        {
            return unit.Multiply(scalar);
        }
        public static BasicUnit<T> operator /(BasicUnit<T> unit, double divisor)
        {
            return unit.Divide(divisor);
        }
        public static bool operator <(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement < unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator >(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement > unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator <=(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement <= unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator >=(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement >= unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator ==(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement == unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator !=(BasicUnit<T> unit1, BasicUnit<T> unit2)
        {
            return unit1.Measurement != unit2.InThisUnit(unit1.Unit);
        }
        #endregion
    }
}
