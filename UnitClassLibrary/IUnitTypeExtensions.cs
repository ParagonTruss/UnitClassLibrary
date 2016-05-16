﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class IUnitTypeExtensions
    {
        public static double ConversionTo<T, U>(this T unitType1, U unitType2)
            where T : IUnitType
            where U : IUnitType
        {
            return unitType1.ConversionFactor/unitType2.ConversionFactor;
        }

        public static Unit<T> AsUnit<T>(this T unitType, Measurement m) 
            where T : IUnitType
        {
            return new Unit<T>(unitType, m);
        }
    }
}
