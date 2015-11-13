using System;
using System.Collections.Generic;
using System.Linq;
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
        public Measurement Multiply(Measurement m)
        {
            return new Measurement(this.Value * m.Value, this.Value * m.ErrorMargin + m.Value * this.ErrorMargin);
        }
        public Measurement Divide(Measurement m)
        {
            return new Measurement(this.Value / m.Value, this.Value*m.ErrorMargin/(m.Value*m.Value) + this.ErrorMargin/m.Value);
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
        public static Measurement operator *(Measurement m1, Measurement m2)
        {
            return m1.Multiply(m2);
        }
        public static Measurement operator /(Measurement m1, Measurement m2)
        {
            return m1.Divide(m2);
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

    public abstract class GenericUnit
    {

    }

    public class StronglyTypedUnit<T> where T : IUnit
    {
        public IUnit Unit;
        public Measurement Measurement;

        public double IntrinsicValue { get { return Measurement.Value; } }
        public double ErrorMargin { get { return Measurement.ErrorMargin; } }
        public double ConversionFactor
        {
            get
            {
                if (Unit is IFundamentalUnit)
                {
                    return (Unit as IFundamentalUnit).ConversionFactor;
                }
                if (Unit is IDerivedUnit)
                {
                    var unit = (Unit as IDerivedUnit);
                    var n = unit.Numerators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);
                    var d = unit.Denominators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);

                    return n / d;
                }
                throw new Exception();
            }
        }
        protected StronglyTypedUnit() { }

        protected StronglyTypedUnit(IUnit unit, double intrinsicValue, double errorMargin = 0) 
         : this(unit,new Measurement(intrinsicValue, errorMargin))
        {
        }
        protected StronglyTypedUnit(IUnit unit, Measurement measurement)
        {
            this.Measurement = measurement;
        }

        public StronglyTypedUnit(StronglyTypedUnit<T> toCopy)
        {
            this.Unit = toCopy.Unit;
            this.Measurement = toCopy.Measurement;
        }

        public StronglyTypedUnit(IFundamentalUnit unit, Measurement value)
        {
            this.Unit = unit;
            this.Measurement = value;
        }
        public double ConversionFromThisTo(IUnit unit)
        {
            if (unit is IFundamentalUnit)
            {
                return this.ConversionFromThisTo(unit as IFundamentalUnit);
            }
            if (unit is IDerivedUnit)
            {
                return this.ConversionFromThisTo(unit as IDerivedUnit);
            }
            throw new Exception();
        }
        public double ConversionFromThisTo(IFundamentalUnit unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }
        public double ConversionFromThisTo(IDerivedUnit unit)
        {
            throw new NotImplementedException();
        }
        public Measurement InThisUnit(IUnit unit)
        {
            if (unit is IFundamentalUnit)
            {
                return this.InThisUnit(unit as IFundamentalUnit);
            }
            if (unit is IDerivedUnit)
            {
                return this.InThisUnit(unit as IDerivedUnit);
            }
            throw new Exception();
        }
        public Measurement InThisUnit(IFundamentalUnit unit)
        {
            return this.Measurement * ConversionFromThisTo(unit);
        }
        public Measurement InThisUnit(IDerivedUnit unit)
        {
            return this.Measurement * ConversionFromThisTo(unit);
        }
     

        #region Public Methods

        public StronglyTypedUnit<T> Negate()
        {
            return new StronglyTypedUnit<T>(this.Unit, -1.0 * this.IntrinsicValue, this.ErrorMargin);
        }

        public StronglyTypedUnit<T> AbsoluteValue()
        {
            return new StronglyTypedUnit<T>(this.Unit, Math.Abs(this.IntrinsicValue), this.ErrorMargin);
        }

        public override string ToString()
        {
            if (this.IntrinsicValue == 1)
            {
                return String.Format("{0} {1}", this.IntrinsicValue, this.Unit.AsStringSingular);
            }

            int digits = 0;
            double roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);

            while (this.Measurement != new Measurement(roundedIntrinsicValue, 0))
            {
                digits++;
                roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);
            }

            return String.Format("{0} {1}", roundedIntrinsicValue, this.Unit.AsStringPlural);
        }

        public StronglyTypedUnit<T> Add(StronglyTypedUnit<T> unit)
        {
            return new StronglyTypedUnit<T>(this.Unit, this.Measurement.Add(unit.Measurement.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public StronglyTypedUnit<T> Subtract(StronglyTypedUnit<T> unit)
        {
            return new StronglyTypedUnit<T>(this.Unit, this.Measurement.Subtract(unit.Measurement.Multiply(unit.ConversionFromThisTo(this.Unit))));
        }
        public StronglyTypedUnit<T> Multiply(double scalar)
        {
            return new StronglyTypedUnit<T>(this.Unit, this.Measurement.Multiply(scalar));
        }
        public StronglyTypedUnit<T> Divide(double divisor)
        {
            return new StronglyTypedUnit<T>(this.Unit, this.Measurement.Divide(divisor));
        }
        public int CompareTo(StronglyTypedUnit<T> other)
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
        public static StronglyTypedUnit<T> operator +(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Add(unit2);
        }
        public static StronglyTypedUnit<T> operator -(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Subtract(unit2);
        }
        public static StronglyTypedUnit<T> operator *(double scalar, StronglyTypedUnit<T> unit)
        {
            return unit.Multiply(scalar);
        }
        public static StronglyTypedUnit<T> operator *(StronglyTypedUnit<T> unit, double scalar)
        {
            return unit.Multiply(scalar);
        }
        public static StronglyTypedUnit<T> operator /(StronglyTypedUnit<T> unit, double divisor)
        {
            return unit.Divide(divisor);
        }
        public static bool operator <(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement < unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator >(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement > unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator <=(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement <= unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator >=(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement >= unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator ==(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement == unit2.InThisUnit(unit1.Unit);
        }
        public static bool operator !=(StronglyTypedUnit<T> unit1, StronglyTypedUnit<T> unit2)
        {
            return unit1.Measurement != unit2.InThisUnit(unit1.Unit);
        }
        #endregion
    }

    public class FundamentalUnit<T> : StronglyTypedUnit<T> where T : IFundamentalUnit
    {
        public new IFundamentalUnit Unit;
        #region Constructors
        protected FundamentalUnit() { }

        public FundamentalUnit(IFundamentalUnit unit, double value)
            : this(unit, value, unit.DefaultErrorMargin) { } 

        public FundamentalUnit(IFundamentalUnit unit, double value, double errorMargin) : base(unit, value, errorMargin) { }
        public FundamentalUnit(IFundamentalUnit unit, Measurement value) : base(unit, value) { }
        public FundamentalUnit(StronglyTypedUnit<T> toCopy) : base(toCopy) { }
        #endregion
        
        #region Fields & Properties
      
        #endregion

       
    }
}
