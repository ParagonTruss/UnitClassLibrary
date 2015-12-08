using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.AngleUnit;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.GenericUnit
{
    public abstract class Unit
    {
        abstract public IUnitType UnitType { get; }
        abstract public Measurement Measurement { get; }

        public double ConversionFactor { get { return UnitType.ConversionFactor; } }
        public UnitDimensions Dimensions { get { return UnitType.Dimensions; } }

        public Measurement ValueInThisUnit(IUnitType type)
        {
            return this.Measurement * this.UnitType.ConversionFactor / type.ConversionFactor;
        }

        abstract public Unit Invert();
        abstract public Unit Multiply(Unit unit);
        public Unit Divide(Unit unit)
        {
            return this.Multiply(unit.Invert());
        }

        public static Unit operator *(Unit unit1, Unit unit2)
        {
            return unit1.Multiply(unit2);
        }
        public static Unit operator /(Unit unit1, Unit unit2)
        {
            return unit1.Divide(unit2);
        }
        protected static bool _AreEqual(Unit unit1, Unit unit2)
        {
            return unit1.Measurement == unit2.ValueInThisUnit(unit1.UnitType);
        }
        public static bool operator ==(Unit unit1, Unit unit2)
        {
            return UnitDimensions.HaveSameDimensions(unit1.UnitType.Dimensions, unit2.UnitType.Dimensions) && _AreEqual(unit1, unit2);
        }
        public static bool operator !=(Unit unit1, Unit unit2)
        {
            return !(unit1 == unit2);
        }
    }
    // This is the class the does the heavy lifting.
    /// <summary>
    /// A generic implementation of all your favorite units.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Unit<T> : Unit where T : IUnitType
    {
        private readonly T _unitType;
        private readonly Measurement _measurement;
        override public IUnitType UnitType { get { return _unitType; } }
        override public Measurement Measurement { get{ return _measurement; } }

        public double IntrinsicValue { get { return Measurement.Value; } }
        public double ErrorMargin { get { return Measurement.ErrorMargin; } }

        protected Unit() { }
        public Unit(T unitType, double value = 1.0)
        {
            this._unitType = unitType;
            this._measurement = new Measurement(value, unitType.DefaultErrorMargin(value));
        }
        public Unit(T unit, Measurement measurement)
        {
            this._unitType = unit;
            this._measurement = measurement;
        }
        public Unit(T type, Unit unitToConvert)
        {
            if (!UnitDimensions.HaveSameDimensions(type.Dimensions, unitToConvert.Dimensions))
            {
                throw new Exception("Units do not have the same Dimensions");
            }
            this._unitType = type;
            this._measurement = unitToConvert.ValueInThisUnit(type);
        }

        public Unit(Unit<T> toCopy)
        {
            this._unitType = (T)toCopy.UnitType;
            this._measurement = toCopy.Measurement;
        }
      

        #region Public Methods

        public double ConversionFromThisTo(IUnitType unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }

        public Measurement ValueInThisUnit(IUnitType unit)
        {
            return this.Measurement * ConversionFromThisTo(unit);
        }

        public Unit<T> Negate()
        {
            return new Unit<T>((T)UnitType, Measurement.Negate());
        }

        public Unit<T> AbsoluteValue()
        {
            return new Unit<T>((T)UnitType, Measurement.AbsoluteValue());
        }

        override public Unit Multiply(Unit unit)
        {
            var type = DerivedUnitType.Multiply(this.UnitType, unit.UnitType);

            return new Unit<DerivedUnitType>(type, this.Measurement*unit.Measurement);
        }

        override public Unit Invert()
        {
            return new Unit<DerivedUnitType>(new DerivedUnitType(Dimensions.Invert()), 1.0 / Measurement);
        }

        public Unit<DerivedUnitType> ToThe(int power)
        {
            var type = DerivedUnitType.Power(this.UnitType, power);
            return new Unit<DerivedUnitType>(type, this.Measurement ^ power);
        }

        public Unit<T> Add(Unit<T> unit)
        {
            return new Unit<T>((T)this.UnitType, this.Measurement + unit.ValueInThisUnit(this.UnitType));
        }
        public Unit<T> Add(Unit unit)
        {
            Unit<T> conversion = new Unit<T>((T)this.UnitType, unit);
            return new Unit<T>((T)this.UnitType, this.Measurement + conversion.Measurement);
        }
        public Unit<T> Subtract(Unit<T> unit)
        {
            return new Unit<T>((T)this.UnitType, this.Measurement - unit.ValueInThisUnit(this.UnitType));
        }
        public Unit<T> Subtract(Unit unit)
        {
            Unit<T> conversion = new Unit<T>((T)this.UnitType, unit);
            return new Unit<T>((T)this.UnitType, this.Measurement - conversion.Measurement);
        }
        public Unit<T> Multiply(Measurement scalar)
        {
            return new Unit<T>((T)this.UnitType, this.Measurement * scalar);
        }
        public Measurement Divide(Unit<T> divisor)
        {
            return this.Measurement / (divisor.ValueInThisUnit(this.UnitType));
        }
        public Unit<T> Divide(Measurement divisor)
        {
            return new Unit<T>((T)this.UnitType, this.Measurement / divisor);
        }
        public Unit<T> Mod(Unit<T> unit)
        {
            return new Unit<T>((T)this.UnitType, this.Measurement.Mod(unit.ValueInThisUnit(this.UnitType)));
        }

        
        #endregion

        #region Overrides
        public override string ToString()
        {
            if (UnitType is DerivedUnitType)
            {
                return IntrinsicValue * Dimensions.Scale + " " + Dimensions.JustTheUnitAsString() + "s";
            }
            if (this.Measurement == 1)
            {
                return String.Format("{0} {1}", 1, this.UnitType.AsStringSingular());
            }

            int digits = 0;
            double roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);

            while (this.Measurement != new Measurement(roundedIntrinsicValue, 0))
            {
                digits++;
                roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);
            }

            return String.Format("{0} {1}", roundedIntrinsicValue, this.UnitType.AsStringPlural());
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            try
            {
                Unit<T> unit = (Unit<T>)other;
                return Unit<T>._AreEqual(this, unit);
            }
            catch
            {
                Unit unit = (Unit)other;

                return false;
            }
        }

        public int CompareTo(Unit<T> other)
        {
            if (this == other)
            {
                return 0;
            }
            else if (this < other)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override int GetHashCode()
        {
            return IntrinsicValue.GetHashCode();
        }
        #endregion

        #region Operator Overloads
        public static Unit<T> operator +(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Add(unit2);
        }
        public static Unit<T> operator +(Unit unit1, Unit<T> unit2)
        {
            return unit2.Add(unit1);
        }
        public static Unit<T> operator +(Unit<T> unit1, Unit unit2)
        {
            return unit1.Add(unit2);
        }
        public static Unit<T> operator -(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Subtract(unit2);
        }
        public static Unit<T> operator -(Unit unit1, Unit<T> unit2)
        {
            return unit2.Negate().Add(unit1);
        }
        public static Unit<T> operator -(Unit<T> unit1, Unit unit2)
        {
            return unit1.Subtract(unit2);
        }
        public static Unit<T> operator *(Measurement scalar, Unit<T> unit)
        {
            return unit.Multiply(scalar);
        }
        public static Unit<T> operator *(Unit<T> unit, Measurement scalar)
        {
            return unit.Multiply(scalar);
        }
        public static Measurement operator /(Unit<T> unit, Unit<T> divisor)
        {
            return unit.Divide(divisor);
        }
        public static Unit<T> operator /(Unit<T> unit, Measurement divisor)
        {
            return unit.Divide(divisor);
        }
        public static Unit<T> operator %(Unit<T> unit, Unit<T> modulus)
        {
            return unit.Mod(modulus);
        }
        public static bool operator <(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Measurement < unit2.ValueInThisUnit(unit1.UnitType);
        }
        public static bool operator >(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Measurement > unit2.ValueInThisUnit(unit1.UnitType);
        }
        public static bool operator <=(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Measurement <= unit2.ValueInThisUnit(unit1.UnitType);
        }
        public static bool operator >=(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Measurement >= unit2.ValueInThisUnit(unit1.UnitType);
        }
        public static bool operator ==(Unit<T> unit1, Unit<T> unit2)
        {
            if ((object)unit1 != null)
            {
                return unit1.Equals(unit2);
            }
            if ((object)unit2 == null)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Unit<T> unit1, Unit<T> unit2)
        {
            return !(unit1 == unit2);
        }

        public Angle ModOutTwoPi()
        {
            var measurement  = ValueInThisUnit(new Degree());
            var value = measurement.Value % 360;
            if (value < 0)
            {
                value *= -1;
            }
            return new Angle(new Degree(), new Measurement(value, measurement.ErrorMargin));
        }

        #endregion
    }

   
}
