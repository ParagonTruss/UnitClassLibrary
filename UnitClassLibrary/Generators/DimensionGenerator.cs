using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static class DimensionGenerator
    {
        public static Dimension MakeDimensionWithInches(double passedValue)
        {
            return new Dimension(DimensionType.Inch, passedValue);
        }

        public static Dimension MakeDimensionWithMillimeters(double passedValue)
        {
            return new Dimension(DimensionType.Millimeter, passedValue);
        }
    }
}