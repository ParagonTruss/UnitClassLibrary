using System;
using System.Collections.Generic;
 
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
    public class Angle : AngularBroken
    {
        #region Constructors

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Angle(): base() { }

        /// <summary>
        /// Create an angle object from an angle value.
        /// </summary>
        /// <param name="angleType">angle unit type</param>
        /// <param name="passedValue">angle value</param>
        public Angle(AngleType angleType, double passedValue)
        {
            switch (angleType)
            {
                case AngleType.Radian:

                    while (passedValue >= Math.PI *2)
                    {
                        passedValue -= Math.PI * 2;
                    }

                    if (passedValue < 0)
                    {
                        passedValue = (Math.PI * 2) - Math.Abs(passedValue);
                    }

                    _intrinsicValue = passedValue;

                    _internalUnitType = AngleType.Radian;

                    break;
                case AngleType.Degree:

                    while (passedValue >= 360)
                    {
                        passedValue = passedValue - 360;
                    }

                    if (passedValue < 0)
                    {
                        passedValue = 360 - Math.Abs(passedValue);
                    }

                    _intrinsicValue = passedValue;

                    _internalUnitType = AngleType.Degree; 

                    break;
            }
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="passedAngle">angle to copy</param>
        public Angle(Angle passedAngle): base(passedAngle){ }

        /// <summary>
        /// castes an angle string to angle degrees
        /// </summary>
        /// <param name="passedAngleString">angle string to parse</param>
        public Angle(string passedAngleString): base(passedAngleString){}
        
        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        /// <summary>
        /// adds the two angles together
        /// </summary>
        /// <param name="a1">first angle</param>
        /// <param name="a2">second angle</param>
        /// <returns>the sum of the two angles</returns>
        public static Angle operator +(Angle a1, Angle a2)
        {
            //add the two Angles together
            double degreesSummed = a1.Degrees + a2.Degrees;

            while (degreesSummed >= 360)
            {
                degreesSummed -= 360;
            }

            //return a new Angle with the new value
            return new Angle(AngleType.Radian, degreesSummed);
        }

        /// <summary>
        /// subtracts one angle from the other
        /// </summary>
        /// <param name="a1">the angle to be subtracted from</param>
        /// <param name="a2">the angle to subtract</param>
        /// <returns>the result of the first angle minus the second</returns>
        public static Angle operator -(Angle a1, Angle a2)
        {
            //add the two Angles together
            double degreesDifferenced = a1.Degrees - a2.Degrees;

            while (degreesDifferenced >= 360)
            {
                degreesDifferenced -= 360;
            }

            if (degreesDifferenced < 0)
            {
                degreesDifferenced = 360 - Math.Abs(degreesDifferenced);
            }

            //subtract the two Angles
            //return a new Angle with the new value
            return new Angle(AngleType.Degree, degreesDifferenced);
        }


        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            //cannot use InternalUnitType because this would give a different hash depending on how the object was crr
            return this.GetValue(AngleType.Degree).GetHashCode();
        }

        /// <summary>
        /// The value and unit in terms of what the object was created with. 
        /// If you want it in a different unit use ToString(AngleType)
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            return this._intrinsicValue + " " + this._internalUnitType;
        }

        /// <summary>
        /// Retuns an Angle object that is 180 degrees from this one
        /// </summary>
        /// <returns></returns>
        public Angle Reverse()
        {
            return this - new Angle(AngleType.Degree, 180);
        }

        /// <summary>
        /// Returns an Angle object that is negated
        /// </summary>
        /// <returns></returns>
        public new Angle Negate()
        {
            return new Angle(AngleType.Degree, this.Degrees - this.Degrees *2);
        }

        #endregion
    }
}
