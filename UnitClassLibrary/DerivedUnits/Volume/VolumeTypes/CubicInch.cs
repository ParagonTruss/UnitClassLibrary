using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;


namespace UnitClassLibrary
{
    public class CubicInch : VolumeType
    {
        public override UnitDimensions Dimensions()
        {         
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Inch(), new Inch(), new Inch() });
        }

        public override string AsStringSingular()
        {
            return "Cubic Inch";
        }

        public override string AsStringPlural()
        {
            return "Cubic Inches";
        }
    }
}
