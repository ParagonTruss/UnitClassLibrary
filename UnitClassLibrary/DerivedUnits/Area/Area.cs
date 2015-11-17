using System.Collections.Generic;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area : Unit<AreaType>
    {
        public Area(AreaType AreaType, double passedDouble)
            : base(AreaType,passedDouble)
        {
        }
        public Area(AreaType type, Unit unitToConvert) : base(type, unitToConvert)
        {

        }

        //private Area(GenericUnit toCopy)
        //    : base(toCopy)
        //{
        //}

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