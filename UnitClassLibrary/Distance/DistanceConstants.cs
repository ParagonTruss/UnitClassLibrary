using System;
using System.Collections.Generic;
 
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Distance
    {
        public static Distance ThirtySecondInch
        {
            get { return new Distance(DistanceType.Inch, 1 / 32); }
        }

        public static Distance SixteenthInch
        {
            get { return new Distance(DistanceType.Inch, 1 / 16); }
        }

        public static Distance EighthInch
        {
            get { return new Distance(DistanceType.Inch, 1 / 8); }
        }

        public static Distance QuarterInch
        {
            get { return new Distance(DistanceType.Inch, 1 / 4); }
        }

        public static Distance HalfInch
        {
            get { return new Distance(DistanceType.Inch, 1 / 2); }
        }

        public static Distance Inch
        {
            get { return new Distance(DistanceType.Inch, 1); }
        }

        public static Distance Foot
        {
            get { return new Distance(DistanceType.Foot, 1); }
        }

        public static Distance Yard
        {
            get { return new Distance(DistanceType.Yard, 1); }
        }

        public static Distance Mile
        {
            get { return new Distance(DistanceType.Mile, 1); }
        }

        public static Distance Millimeter
        {
            get { return new Distance(DistanceType.Millimeter, 1); }
        }

        public static Distance Centimeter
        {
            get { return new Distance(DistanceType.Centimeter, 1); }
        }

        public static Distance Meter
        {
            get { return new Distance(DistanceType.Meter, 1); }
        }

        public static Distance Kilometer
        {
            get { return new Distance(DistanceType.Kilometer, 1); }
        }
    }
}
