using System.Collections.Generic;
using UnitClassLibrary.AreaUnit.AreaTypes;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AreaUnit
{
    public class Area:GenericUnit.GenericUnit
    {
        public Area(IAreaType AreaType, double passedDouble):base(new List<KeyValuePair<double, IUnitType>>(){new KeyValuePair<double, IUnitType>(passedDouble,AreaType)}, new List<KeyValuePair<double, IUnitType>>() )
        {
        }

        private Area(GenericUnit.GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Area Negate()
        {
            return new Area(base.Negate());
        }
    }
}