using System;
using System.Collections.Generic;
 
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Broken
    {
        public static Broken Sixteenth
        {
            get { return new Broken(BrokenType.Sixteenth, 1); }
        }

        public static Broken ThirtySecond
        {
            get { return new Broken(BrokenType.ThirtySecond, 1); }
        }

        public static Broken Inch
        {
            get { return new Broken(BrokenType.Inch, 1); }
        }

        public static Broken Foot
        {
            get { return new Broken(BrokenType.Foot, 1); }
        }

        public static Broken Yard
        {
            get { return new Broken(BrokenType.Yard, 1); }
        }

        public static Broken Mile
        {
            get { return new Broken(BrokenType.Mile, 1); }
        }

        public static Broken Millimeter
        {
            get { return new Broken(BrokenType.Millimeter, 1); }
        }

        public static Broken Centimeter
        {
            get { return new Broken(BrokenType.Centimeter, 1); }
        }

        public static Broken Meter
        {
            get { return new Broken(BrokenType.Meter, 1); }
        }

        public static Broken Kilometer
        {
            get { return new Broken(BrokenType.Kilometer, 1); }
        }
    }
}
