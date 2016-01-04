using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AngleUnit;

namespace UnitClassLibrary.AngleUnit
{
    public static class AngleTypeFactory
    {
        public static AngleType Radians { get { return new Radian(); } }
        public static AngleType Degrees { get { return new Degree(); } }
    }
}
