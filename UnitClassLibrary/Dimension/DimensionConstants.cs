using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Dimension
    {
        public static Dimension Sixteenth
        {
            get { return new Dimension(DimensionType.Sixteenth, 1); }
        }

        public static Dimension ThirtySecond
        {
            get { return new Dimension(DimensionType.ThirtySecond, 1); }
        }

        public static Dimension Inch
        {
            get { return new Dimension(DimensionType.Inch, 1); }
        }

        public static Dimension Foot
        {
            get { return new Dimension(DimensionType.Foot, 1); }
        }

        public static Dimension Yard
        {
            get { return new Dimension(DimensionType.Yard, 1); }
        }

        public static Dimension Mile
        {
            get { return new Dimension(DimensionType.Mile, 1); }
        }

        public static Dimension Millimeter
        {
            get { return new Dimension(DimensionType.Millimeter, 1); }
        }

        public static Dimension Centimeter
        {
            get { return new Dimension(DimensionType.Centimeter, 1); }
        }

        public static Dimension Meter
        {
            get { return new Dimension(DimensionType.Meter, 1); }
        }

        public static Dimension Kilometer
        {
            get { return new Dimension(DimensionType.Kilometer, 1); }
        }

    }
}
