using System.Collections.Generic;
using System.ServiceModel;

namespace UnitClassLibrary.New_Attempt
{
    public class Distance:GenericUnit, ISimpleUnit
    {
        public Distance(IDistanceType distanceType, double passedDouble):base(new List<KeyValuePair<double, IUnitType>>(){new KeyValuePair<double, IUnitType>(passedDouble,distanceType)}, new List<KeyValuePair<double, IUnitType>>() )
        {
        }

        private Distance(GenericUnit toCopy)
            : base(toCopy)
        {
        }

        new public Distance Negate()
        {
            return new Distance(base.Negate()); 
        }

        public IUnitType GetInternalUnitType()
        {
            return base.numerators[0].Value;
        }
    }
}