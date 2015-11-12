using System;
using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit.DistanceTypes;

namespace UnitClassLibrary.GenericUnit
{
    public struct DoubleWithErrorMargin
    {
        public readonly double IntrinsicValue;
        public readonly double ErrorMargin;
        public double PercentageError { get { return ErrorMargin / IntrinsicValue; } }
        public DoubleWithErrorMargin(double intrinsicValue, double errorMargin)
        {
            this.IntrinsicValue = intrinsicValue;
            this.ErrorMargin = errorMargin;
        }
        public DoubleWithErrorMargin Add(DoubleWithErrorMargin value)
        {
            return new DoubleWithErrorMargin(this.IntrinsicValue + value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public DoubleWithErrorMargin Subtract(DoubleWithErrorMargin value)
        {
            return new DoubleWithErrorMargin(this.IntrinsicValue - value.IntrinsicValue, this.ErrorMargin + value.ErrorMargin);
        }
        public DoubleWithErrorMargin Multiply(double scalar)
        {
            return new DoubleWithErrorMargin(scalar * this.IntrinsicValue, scalar * this.ErrorMargin);
        }
        public DoubleWithErrorMargin Divide(double divisor)
        {
            return new DoubleWithErrorMargin(this.IntrinsicValue / divisor, this.ErrorMargin / divisor);
        }
    }
    public class BasicUnit
    {
        public IUnit Unit;
        public DoubleWithErrorMargin Value;

        public double IntrinsicValue { get { return Value.IntrinsicValue; } }
        public double ErrorMargin { get { return Value.ErrorMargin; } }

        protected BasicUnit() { }

        protected BasicUnit(IUnit unit, double intrinsicValue, double errorMargin)
        {
            this.Unit = unit;
            this.Value = new DoubleWithErrorMargin(intrinsicValue, errorMargin);
        }

        public BasicUnit(BasicUnit toCopy)
        {
            this.Unit = toCopy.Unit;
            this.Value = toCopy.Value;
        }

        public BasicUnit(IUnit unit, DoubleWithErrorMargin value)
        {
            this.Unit = unit;
            this.Value = value;
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
        public BasicUnit(IUnit unit, DoubleWithErrorMargin value) : base(unit, value) { }
        public BasicUnit(BasicUnit toCopy) : base(toCopy) { }
        #endregion
        
        #region Fields & Properties
        public double ConversionFactor { get { return Unit.ConversionFactor; } }
        #endregion

        #region Public Methods

        public double GetValue(IUnit unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }

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
            return new BasicUnit<T>(this.Unit, this.IntrinsicValue + unit.GetValue(this.Unit), this.ErrorMargin + unit.GetValue(this.Unit));
        }
        public BasicUnit<T> Subtract(BasicUnit<T> unit)
        {
            return new BasicUnit<T>(this.Unit, this.IntrinsicValue - unit.GetValue(this.Unit), this.ErrorMargin + unit.GetValue(this.Unit));
        }
        public BasicUnit<T> Multiply(double scalar)
        {
            return new BasicUnit<T>(this.Unit, scalar * this.IntrinsicValue, scalar * this.ErrorMargin);
        }
        public BasicUnit<T> Divide(double divisor)
        {
            return new BasicUnit<T>(this.Unit, this.IntrinsicValue / divisor, this.ErrorMargin / divisor);
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
