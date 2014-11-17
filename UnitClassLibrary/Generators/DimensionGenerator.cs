using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class DistanceGenerator
    {
        public static Distance MakeDistanceWithInches(double passedValue)
        {
            return new Distance(DistanceType.Inch, passedValue);
        }

        public static Distance MakeDistanceWithMillimeters(double passedValue)
        {
            return new Distance(DistanceType.Millimeter, passedValue);
        }
    }
}