using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// Class used for storing Angles that may need to be accessed in a different measurement system
    /// Accepts anything as input
    /// 
    /// For an explanation of why this class is immutatble: http://codebetter.com/patricksmacchia/2008/01/13/immutable-types-understand-them-and-use-them/
    /// 
    /// <example>
    /// radians into degrees then returned as string
    /// 
    /// double radians = 10.5;
    /// Angle a = new Angle(AngleType.Radian, radians);
    /// 
    /// a.Degrees.ToString()         //for decimal degrees
    /// a.ToString(AngleType.Degree) //for formated string
    /// </example>
    /// 
    /// </summary>
    public class Angle : IComparable<Angle>
    {
        #region private fields and constants

        //Internally we are currently using radians
        private double _intrinsicValue;
        private static AngleType InternalUnitType = AngleType.Radian;

        #endregion

        #region Properties

        public double Radians
        {
            get { return retrieveAsExternalUnit(AngleType.Radian); }
        }

        public double Degrees
        {
            get { return retrieveAsExternalUnit(AngleType.Degree); }
        }

        #endregion

        #region helper methods


        private static string ConvertDecimalRadiansToDegreesString(double radians)
        {
            //convert out of radians
            double degreesCumulative = radians / (Math.PI / 180);

            //save off the whole degrees
            double degrees = Math.Floor(degreesCumulative);

            //only left with minutes and seconds as a remainder of degrees
            degreesCumulative -= degrees;

            //convert to minutes
            degreesCumulative *= 60;

            //save off the whole minutes
            double minutes = Math.Floor(degreesCumulative);

            //only left with seconds as a remainder of minutes
            degreesCumulative -= degrees;

            //convert to seconds
            degreesCumulative *= 60;

            //round off to whole seconds
            double seconds = Math.Round(degreesCumulative);

            //now convert numbers to strings
            string degreeString = degrees.ToString();
            string minutesString = minutes.ToString();
            string secondsString = seconds.ToString();

            //format symbols
            return string.Format("{0}°{1}'{2}\"", degreeString, minutesString, secondsString);
        }

        private double retrieveAsExternalUnit(AngleType angleType)
        {
            switch (angleType)
            {
                case AngleType.Radian:
                    return _intrinsicValue;
                case AngleType.Degree:
                    return _intrinsicValue / (Math.PI / 180);
                default:
                    //code should never be run
                    return 0;
            }
        }

        private void storeAsInternalUnit(AngleType fromAngleType, double passedValue)
        {
            switch (fromAngleType)
            {
                case AngleType.Radian:
                    _intrinsicValue = passedValue;
                    break;
                case AngleType.Degree:
                    _intrinsicValue = passedValue * (Math.PI / 180);
                    break;
            }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Angle()
        {
            _intrinsicValue = 0;
        }

        /// <summary>
        /// Create an angle object from an angle value.
        /// </summary>
        /// <param name="angleType"></param>
        /// <param name="passedValue"></param>
        public Angle(AngleType angleType, double passedValue)
        {
            switch (angleType)
            {
                case AngleType.Radian:
                    _intrinsicValue = passedValue;
                    break;
                case AngleType.Degree:
                    _intrinsicValue = passedValue * (Math.PI / 180);
                    break;
            }

        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="passedAngle"></param>
        public Angle(Angle passedAngle)
        {
            this._intrinsicValue = passedAngle._intrinsicValue;
        }

        public Angle( string passedAngleString)
        {
            string[] seperatedStrings = passedAngleString.Split(new char[] { '°', '\'' });
            int degrees;
            int minutes;
            int seconds;

            try
            {
                degrees = int.Parse(seperatedStrings[0]);
                minutes = int.Parse(seperatedStrings[1]);
                seconds = int.Parse(seperatedStrings[2]);
            }
            catch (Exception)
            {
                throw new Exception();
            }

            _intrinsicValue = degrees + (minutes / 60f) + (seconds / 3600f);
        }

        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Angle operator +(Angle d1, Angle d2)
        {
            //add the two Angles together
            //return a new Angle with the new value
            return new Angle(InternalUnitType, (d1._intrinsicValue + d2._intrinsicValue));
        }

        public static Angle operator -(Angle d1, Angle d2)
        {
            //subtract the two Angles
            //return a new Angle with the new value
            return new Angle(InternalUnitType, (d1._intrinsicValue - d2._intrinsicValue));
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Angle d1, Angle d2)
        {
            return d1.Equals(d2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Angle d1, Angle d2)
        {
            return !d1.Equals(d2);
        }

        public static bool operator >(Angle d1, Angle d2)
        {
            return d1._intrinsicValue > d2._intrinsicValue;
        }

        public static bool operator <(Angle d1, Angle d2)
        {
            return d1._intrinsicValue < d2._intrinsicValue;
        }

        public static bool operator >=(Angle d1, Angle d2)
        {
            return d1.Equals(d2) || d1._intrinsicValue > d2._intrinsicValue;
        }

        public static bool operator <=(Angle d1, Angle d2)
        {
            return d1.Equals(d2) || d1._intrinsicValue < d2._intrinsicValue;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return _intrinsicValue.GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Angle class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Angle.Tostring(AngleType) instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Angle class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call Angle.[unit].ToString() instead");
        }

        /// <summary>
        /// does the same thing as == if the passed in object is a d
        /// </summary>
        public override bool Equals(object obj)
        {
            return Math.Abs(_intrinsicValue - ((Angle)(obj))._intrinsicValue) < Constants.AcceptedEqualityDeviationConstant;
        }

        /// <summary>
        /// Returns the a string converted to a desired unitType
        /// </summary>
        /// <param name="angleType"></param>
        /// <returns></returns>
        public string ToString(AngleType angleType)
        {
            switch (angleType)
            {
                case AngleType.Radian:
                    return _intrinsicValue.ToString() + " rad";
                case AngleType.Degree:
                    return ConvertDecimalRadiansToDegreesString(_intrinsicValue) + "°";
                default:
                    //code should never be run
                    return "We were unable to identify your desired Unit Type";
            }
        }

        #endregion

        #region Interface Implementations

        /// <summary>
        /// This implements the IComparable interface and allows Angles to be sorted and such
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Angle other)
        {
            // The comparison depends on the comparison of  
            // the underlying Double values.  
            if (this.Equals(other))
                return 0;
            else
                return (this._intrinsicValue.CompareTo(other._intrinsicValue));
        }
        #endregion

        /// <summary>
        /// creates a negative instance of this angle
        /// </summary>
        /// <returns>a negative instance of this angle</returns>
        public Angle Negate()
        {
            return new Angle(AngleType.Radian, this.Radians);
        }
    }
}
