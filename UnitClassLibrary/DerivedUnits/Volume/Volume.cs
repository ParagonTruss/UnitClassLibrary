﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary
{
    public class Volume : Unit<VolumeType>
    {
        public static readonly Volume Zero = new Volume(new CubicInch(), new Measurement());

        public Volume(VolumeType unitType, double value) : base(unitType, value)
        {
        }

        public Volume(VolumeType unitType, Measurement value) : base(unitType, value)
        { }
    }
}