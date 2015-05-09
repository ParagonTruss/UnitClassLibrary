using System.Collections.Generic;

namespace UnitClassLibrary.New_Attempt
{
    public class Area:GenericUnit
    {
        public Area(IAreaType AreaType, double passedDouble):base(new List<KeyValuePair<double, IUnitType>>(){new KeyValuePair<double, IUnitType>(passedDouble,AreaType)}, new List<KeyValuePair<double, IUnitType>>() )
        {
        }

        private Area(GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Area Negate()
        {
            return new Area(base.Negate());
        }
    }
}