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
        public readonly double IntrinsicValue;
        public readonly double ErrorMargin;
        public double PercentageError { get { return ErrorMargin / IntrinsicValue; } }
        public Measurement(double intrinsicValue, double errorMargin)
        {
            this.IntrinsicValue = intrinsicValue;
            this.ErrorMargin = Math.Abs(errorMargin);
        }

        public Measurement Negate()
        {
            return this.Multiply(-1.0);
        }

        public Measurement AbsoluteValue()
        {
            return new Measurement(Math.Abs(IntrinsicValue), ErrorMargin);
        }

        public Measurement Add(Measurement value)
        {
            return new Measurement(this.IntrinsicValue + value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Subtract(Measurement value)
        {
            return new Measurement(this.IntrinsicValue - value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Multiply(double scalar)
        {
            return new Measurement(scalar * this.IntrinsicValue, scalar * this.ErrorMargin);
        }
        public Measurement Divide(double divisor)
        {
            return new Measurement(this.IntrinsicValue / divisor, this.ErrorMargin / divisor);
        }

        public static Measurement operator +(Measurement value)
        {
            return new Measurement(this.IntrinsicValue + value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Subtract(Measurement value)
        {
            return new Measurement(this.IntrinsicValue - value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public Measurement Multiply(double scalar)
        {
            return new Measurement(scalar * this.IntrinsicValue, scalar * this.ErrorMargin);
        }
        public Measurement Divide(double divisor)
        {
            return new Measurement(this.IntrinsicValue / divisor, this.ErrorMargin / divisor);
        }
    }
    public class BasicUnit
    {
        public IUnit Unit;
        public Measurement Value;

        public double IntrinsicValue { get { return Value.IntrinsicValue; } }
        public double ErrorMargin { get { return Value.ErrorMargin; } }
        public double ConversionFactor { get { return Unit.ConversionFactor; } }
        protected BasicUnit() { }

        protected BasicUnit(IUnit unit, double intrinsicValue, double errorMargin)
        {
            this.Unit = unit;
            this.Value = new Measurement(intrinsicValue, errorMargin);
        }

        public BasicUnit(BasicUnit toCopy)
        {
            this.Unit = toCopy.Unit;
            this.Value = toCopy.Value;
        }

        public BasicUnit(IUnit unit, Measurement value)
        {
            this.Unit = unit;
            this.Value = value;
        }

        public double ConversionFromThisTo(IUnit unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }
        public Measurement GetValue(IUnit unit)
        {
            return this.Value * ConversionFromThisTo(unit);
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
            return new BasicUnit<T>(this.Unit, this.Value.Add(unit.Value.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public BasicUnit<T> Subtract(BasicUnit<T> unit)
        {
            return new BasicUnit<T>(this.Unit, this.Value.Subtract(unit.Value.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public BasicUnit<T> Multiply(double scalar)
        {
            return new BasicUnit<T>(this.Unit, this.Value.Multiply(scalar));
        }
        public BasicUnit<T> Divide(double divisor)
        {
            return new BasicUnit<T>(this.Unit, this.Value.Divide(divisor));
        }
        public int CompareTo(BasicUnit<T> other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            else
            {
                return IntrinsicValue.CompareTo(other.GetValue(other.Unit));
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
        #endregion
    }
}
