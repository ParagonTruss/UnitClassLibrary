using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.UnitComponents
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
            if (Measurement.ErrorPropagationEnabled)
            {
                return unit1.Measurement == unit2.ValueInThisUnit(unit1.UnitType);
            }
            else
            {
                throw new NotImplementedException();
            }
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
}
