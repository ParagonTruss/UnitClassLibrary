using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public abstract class Unit
    {
        abstract public IUnitType UnitType { get; }
        abstract public Measurement Measurement { get; }

        public double ConversionFactor { get { return UnitType.ConversionFactor; } }
        public UnitDimensions Dimensions { get { return UnitType.Dimensions(); } }

        public double ConversionFromThisTo(IUnitType unit)
        {
            return this.ConversionFactor / unit.ConversionFactor;
        }

        public Measurement ValueIn(IUnitType unit)
        {
            var result = this.Measurement * ConversionFromThisTo(unit);
            return result;
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
        public static bool operator ==(Unit unit1, Unit unit2)
        {
            return _HaveTheSameDimensions(unit1, unit2) && _ValuesAreEqual(unit1, unit2);
        }
        public static bool operator !=(Unit unit1, Unit unit2)
        {
            return !(unit1 == unit2);
        }

        protected static bool _HaveTheSameDimensions(Unit unit1, Unit unit2)
        {
            return UnitDimensions.HaveSameDimensions(unit1.UnitType.Dimensions(), unit2.UnitType.Dimensions());
        }
        protected static bool _ValuesAreEqual(Unit unit1, Unit unit2)
        {
            return unit1.Measurement == unit2.ValueIn(unit1.UnitType);
        }
    }
}
