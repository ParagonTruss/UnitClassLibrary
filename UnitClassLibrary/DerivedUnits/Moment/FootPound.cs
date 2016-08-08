﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitClassLibrary.DerivedUnits
{
    public class FootPound : MomentType
    {
        public override UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { new Pound(), new Foot() });
        }

        public override string AsStringSingular()
        {
            return "Pound-Foot";
        }
        public override string AsStringPlural()
        {
            return "Pound-Feet";
        }
    }
}