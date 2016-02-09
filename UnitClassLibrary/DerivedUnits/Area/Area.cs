using System;
using System.Collections.Generic;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.SquareInchesUnit;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area : Unit<AreaType>
    {
        public static readonly Area Zero = new Area(new SquareInch(), 0);

        public Area(Unit unit) : this(new SquareInch(), unit)
        {
        }

        public Area(Measurement measurement, AreaType areaType) : base(areaType, measurement)
        {
        }

        public Area(AreaType AreaType, double measurement)
            : base(AreaType, measurement)
        {
        }
        public Area(AreaType unit, Measurement measurement) : base(unit, measurement)
        {
        }
        public Area(AreaType type, Unit unitToConvert) : base(type, unitToConvert)
        {

        }
        public static AreaType SquareInches { get { return new SquareInch(); } }
        public Measurement InSquareInches { get { return MeasurementIn(new SquareInch()); } }

        public Distance SquareRoot()
        {
            var value = this.MeasurementIn(new SquareInch()).SquareRoot();
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