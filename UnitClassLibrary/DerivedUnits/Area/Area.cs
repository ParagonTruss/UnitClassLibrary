using System;
using System.Collections.Generic;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.InchesSquaredUnit;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area : Unit<AreaType>
    {
        public static readonly Area Zero = new Area(new SquareInch(),new Measurement());

        public Area(Unit unit) : this (new SquareInch(),unit)
        {
        }

        public Area(AreaType AreaType, Measurement measurement)
            : base(AreaType,measurement)
        {
        }
        public Area(AreaType type, Unit unitToConvert) : base(type, unitToConvert)
        {

        }

        public Distance SquareRoot()
        {
            var value = this.ValueInThisUnit(new SquareInch()).SquareRoot();
            return new Distance(new Inch(), value);
        }

        //new public Area Negate()
        //{
        //    return new Area(base.Negate());
        //}

        //new public Area AbsoluteValue()
        //{
        //    return new Area(base.AbsoluteValue());
        //}
    }
}