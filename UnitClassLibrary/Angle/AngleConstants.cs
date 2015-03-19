using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Angle
    {
        public static Angle ZeroDegrees
        {
            get { return new Angle(AngleType.Degree, 0); }
        }

        public static Angle FortyFiveDegrees
        {
            get { return new Angle(AngleType.Degree, 45); }
        }

        public static Angle NinetyDegrees
        {
            get { return new Angle(AngleType.Degree, 90); }
        }

        public static Angle OneHundredThirtyFiveDegrees
        {
            get { return new Angle(AngleType.Degree, 135); }
        }

        public static Angle OneHundredEightyDegrees
        {
            get { return new Angle(AngleType.Degree, 180); }
        }

        public static Angle TwoHundredTwentyFiveDegrees
        {
            get { return new Angle(AngleType.Degree, 225); }
        }

        public static Angle TwoHundredSeventyDegrees
        {
            get { return new Angle(AngleType.Degree, 270); }
        }

        public static Angle ThreeHundredFifteenDegrees
        {
            get { return new Angle(AngleType.Degree, 315); }
        }

        public static Angle ThreeHundredSixtyDegrees
        {
            get { return new Angle(AngleType.Degree, 360); }
        }

        public static Angle ZeroRadians
        {
            get { return new Angle(AngleType.Radian, 0); }
        }

        public static Angle QuarterPiRadians
        {
            get { return new Angle(AngleType.Radian, Math.PI / 4); }
        }

        public static Angle HalfPiRadians
        {
            get { return new Angle(AngleType.Radian, Math.PI / 2); }
        }

        public static Angle ThreeQuarterPiRadians
        {
            get { return new Angle(AngleType.Radian, 3 * Math.PI / 4); }
        }

        public static Angle PiRadians
        {
            get { return new Angle(AngleType.Radian, Math.PI); }
        }

        public static Angle FiveQuarterPiRadians
        {
            get { return new Angle(AngleType.Radian, 5 * Math.PI / 4); }
        }

        public static Angle ThreeHalfPiRadians
        {
            get { return new Angle(AngleType.Radian, 3 * Math.PI / 2); }
        }

        public static Angle SevenQuarterPiRadians
        {
            get { return new Angle(AngleType.Radian, 7 * Math.PI / 4); }
        }

        public static Angle TwoPiRadians
        {
            get { return new Angle(AngleType.Radian, 2 * Math.PI); }
        }

        public static Angle North
        {
            get { return new Angle(AngleType.Degree, 0); }
        }

        public static Angle NorthNorthEast
        {
            get { return new Angle(AngleType.Degree, 22.5); }
        }

        public static Angle NorthEast
        {
            get { return new Angle(AngleType.Degree, 45); }
        }

        public static Angle EastNorthEast
        {
            get { return new Angle(AngleType.Degree, 67.5); }
        }

        public static Angle East
        {
            get { return new Angle(AngleType.Degree, 90); }
        }

        public static Angle EastSouthEast
        {
            get { return new Angle(AngleType.Degree, 112.5); }
        }

        public static Angle SouthEast
        {
            get { return new Angle(AngleType.Degree, 135); }
        }

        public static Angle SouthSouthEast
        {
            get { return new Angle(AngleType.Degree, 157.5); }
        }

        public static Angle South
        {
            get { return new Angle(AngleType.Degree, 180); }
        }

        public static Angle SouthSouthWest
        {
            get { return new Angle(AngleType.Degree, 202.5); }
        }

        public static Angle SouthWest
        {
            get { return new Angle(AngleType.Degree, 225); }
        }

        public static Angle WestSouthWest
        {
            get { return new Angle(AngleType.Degree, 247.5); }
        }

        public static Angle West
        {
            get { return new Angle(AngleType.Degree, 270); }
        }

        public static Angle WestNorthWest
        {
            get { return new Angle(AngleType.Degree, 292.5); }
        }

        public static Angle NorthWest
        {
            get { return new Angle(AngleType.Degree, 315); }
        }

        public static Angle NorthNorthWest
        {
            get { return new Angle(AngleType.Degree, 337.5); }
        }
    }
}
