using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.TimeUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.SpeedUnit
{
    public class Speed : Unit<SpeedType>
    {
        public Speed(SpeedType speedType) : base(speedType)
        {

        }
        public Speed(SpeedType speedType, Measurement measurement)
            : base(speedType, measurement) { }

        public Speed(Unit<SpeedType> copy) : base(copy.UnitType, copy.Measurement) { }
        //public Speed(DerivedUnitType type, Measurement measurement)
        //{
        //    var nums = type.Dimensions.Numerators;
        //    var denoms = type.Dimensions.Denominators;
        //    if (nums.Count == 1 && (nums.First() is DistanceType) &&
        //        denoms.Count == 1 && (denoms.First() is ITimeType))
        //    {
        //        this.UnitType 
        //    }
        //}

        new public Speed Negate()
        {
            return new Speed(base.Negate());
        }
    }
}
