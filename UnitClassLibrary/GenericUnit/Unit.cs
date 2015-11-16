using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.GenericUnit
{
    public abstract class Unit
    {
        public abstract IUnitType UnitType { get; }
        public abstract Measurement Measurement { get; }
        public UnitDimensions Dimensions { get; }
    }
    // This is the class the does the heavy lifting.
    /// <summary>
    /// A generic implementation of all your favorite units.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Unit<T> where T : IUnitType
    {
        public IUnitType UnitType { get; protected set; }
        public Measurement Measurement { get; private set; }

        public double IntrinsicValue { get { return Measurement.Value; } }
        public double ErrorMargin { get { return Measurement.ErrorMargin; } }
        public double ConversionFactor { get { return UnitType.ConversionFactor; } }

        protected Unit() { }
        public Unit(IUnitType unitType, double value)
        {
            this.UnitType = unitType;
            this.Measurement = new Measurement(value, unitType.DefaultErrorMargin(value));
        }
        public Unit(IUnitType unit, Measurement measurement)
        {
            this.UnitType = unit;
            this.Measurement = measurement;
        }

        public Unit(Unit<IUnitType> toCopy)
        {
            this.UnitType = toCopy.UnitType;
            this.Measurement = toCopy.Measurement;
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
            return new Unit<T>(UnitType, Measurement.Negate());
        }

        public Unit<T> AbsoluteValue()
        {
            return new Unit<T>(UnitType, Measurement.AbsoluteValue());
        }

        public Unit<DerivedUnitType> Multiply(Unit<IUnitType> unit)
        {
            var type = DerivedUnitType.Multiply(this.UnitType, unit.UnitType);

            return new Unit<DerivedUnitType>(type, this.Measurement*unit.Measurement);
        }

        public Unit<DerivedUnitType> Divide(Unit<IUnitType> unit)
        {
            var type = DerivedUnitType.Divide(this.UnitType, unit.UnitType);

            return new Unit<DerivedUnitType>(type, this.Measurement / unit.Measurement);
        }

        public Unit<DerivedUnitType> ToThe(int power)
        {
            var type = DerivedUnitType.Power(this.UnitType, power);
            return new Unit<DerivedUnitType>(type, this.Measurement ^ power);
            //var numerators = new List<FundamentalUnitType>();
            //var denominators = new List<FundamentalUnitType>();
            //if (power > 0)
            //{
            //    for (int i = 0; i < power; i++)
            //    {
            //        numerators.AddRange(this.UnitType.Numerators);
            //        denominators.AddRange(this.UnitType.Denominators);
            //    }
            //}
            //else if (power < 0)
            //{
            //    for (int i = 0; i < -1*power; i++)
            //    {
            //        numerators.AddRange(this.UnitType.Denominators);
            //        denominators.AddRange(this.UnitType.Numerators);
            //    }
            //}

            //IUnitType type = new DerivedUnitType(numerators, denominators);

            //return new Unit<DerivedUnitType>(type, this.Measurement ^ power);
        }

        public Unit<T> Add(Unit<T> unit)
        {
            return new Unit<T>(this.UnitType, this.Measurement + unit.ValueInThisUnit(this.UnitType));
        }
        public Unit<T> Subtract(Unit<T> unit)
        {
            return new Unit<T>(this.UnitType, this.Measurement - unit.ValueInThisUnit(this.UnitType));
        }
        public Unit<T> Multiply(Measurement scalar)
        {
            return new Unit<T>(this.UnitType, this.Measurement * scalar);
        }
        public Unit<T> Divide(Measurement divisor)
        {
            return new Unit<T>(this.UnitType, this.Measurement / divisor);
        }

        
        #endregion

        #region Overrides
        public override string ToString()
        {
            if (this.Measurement == 1)
            {
                return String.Format("{0} {1}", 1, this.UnitType.AsStringSingular);
            }

            int digits = 0;
            double roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);

            while (this.Measurement != new Measurement(roundedIntrinsicValue, 0))
            {
                digits++;
                roundedIntrinsicValue = Math.Round(IntrinsicValue, digits);
            }

            return String.Format("{0} {1}", roundedIntrinsicValue, this.UnitType.AsStringPlural);
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
                return Unit<T>._areEqual(this, unit);
            }
            catch
            {
                Unit unit = (Unit)other;

                return false;
            }
        }

        private static bool _areEqual(Unit<T> unit1, Unit<T> unit2)
        {
            return unit1.Measurement == unit2.ValueInThisUnit(unit1.UnitType);
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
        public static Unit<T> operator -(Unit<T> unit1, Unit<T> unit2)
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
        public static Unit<T> operator /(Unit<T> unit, Measurement divisor)
        {
            return unit.Divide(divisor);
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
        #endregion
    }

   
}
