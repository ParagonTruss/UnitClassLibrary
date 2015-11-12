using System.Collections.Generic;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area : BasicUnit<IAreaUnit>
    {
        public Area(IAreaUnit AreaType, double passedDouble) : base(new List<BasicUnit>(){new BasicUnit(passedDouble,AreaType.ConversionFactor)}, new List<BasicUnit>() )
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