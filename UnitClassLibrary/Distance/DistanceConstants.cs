using System;
using System.Collections.Generic;
 
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Distance
    {
        public static Distance Sixteenth
        {
            get { return new Distance(DistanceType.Sixteenth, 1); }
        }

        public static Distance ThirtySecond
        {
            get { return new Distance(DistanceType.ThirtySecond, 1); }
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
