using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DerivedUnits.Volume.VolumeTypes
{
    public class CubicFoot : VolumeType
    {
        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Foot(), new Foot(), new Foot() });
            }
        }

        public override string AsStringSingular()
        {
            return "Cubic Foot";
        }
        public override string AsStringPlural()
        {
            return "Cubic Feet";
        }
    }
}
