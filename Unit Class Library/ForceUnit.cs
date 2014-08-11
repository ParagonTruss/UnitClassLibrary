using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// Class that represents force
    /// </summary>
    [DebuggerDisplay("{Pounds}lbs")]
    public class ForceUnit : IComparable<ForceUnit>
    {
        #region _internalVariables
        private const ForceType InternalUnitType = ForceType.Pounds;
        private double _intrinsicValue = 0.0;
        #endregion

        #region Getters
        /// <summary>
        /// returns force as pounds
        /// </summary>
        public double Pounds
        {
            get { return retrieveAsExternalUnit(ForceType.Pounds); }
        }

        /// <summary>
        /// returns force as newtons
        /// </summary>
        public double Newtons
        {
            get { return retrieveAsExternalUnit(ForceType.Newtons); }
        }

        /// <summary>
        /// returns force as kips
        /// </summary>
        public double Kips
        {
            get { return retrieveAsExternalUnit(ForceType.Kips); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// constructor that creates a zero instance of force
        /// </summary>
        public ForceUnit()
        {
            _intrinsicValue = 0.0;
        }

        /// <summary>
        /// constructor that creates a new force
        /// </summary>
        /// <param name="forceType">unit of force to use</param>
        /// <param name="passedValue">amount of force in unit passed</param>
        public ForceUnit(ForceType forceType, double passedValue)
        {
            storeAsInternalUnit(forceType, passedValue);
        }
        #endregion

        #region helper methods
        /// <summary>
        /// retrieves the force as the unit specified
        /// </summary>
        /// <param name="forceType">unit of force</param>
        /// <returns></returns>
        private double retrieveAsExternalUnit(ForceType forceType)
        {
            return ConvertTo(InternalUnitType, _intrinsicValue, forceType);
        }

        /// <summary>
        /// stores force
        /// </summary>
        /// <param name="forceType">unit to store force as</param>
        /// <param name="passedValue">value of force</param>
        private void storeAsInternalUnit(ForceType forceType, double passedValue)
        {
            _intrinsicValue = ConvertTo(forceType, passedValue, InternalUnitType);
        }

        /// <summary>
        /// converts to and from different force types
        /// </summary>
        /// <param name="fromForceType">force type to convert from</param>
        /// <param name="passedMagnitude">amount of force</param>
        /// <param name="toForceType">force type to convert to</param>
        /// <returns>value of force in the toForceType unit</returns>
        public static double ConvertTo(ForceType fromForceType, double passedMagnitude, ForceType toForceType)
        {
            double poundMagnitude = 0;
            double returnMagnitude = 0;

            switch (fromForceType)
            {
                case ForceType.Pounds:
                    poundMagnitude = passedMagnitude;
                    break;
                case ForceType.Newtons:
                    poundMagnitude = passedMagnitude / 4.44822162;
                    break;
                case ForceType.Kips:
                    poundMagnitude = passedMagnitude * 1000;
                    break;
                default:
                    //code should never run
                    throw new NotSupportedException("Unit not supported!");
            }

            switch (toForceType)
            {
                case ForceType.Pounds:
                    returnMagnitude = poundMagnitude;
                    break;
                case ForceType.Newtons:
                    returnMagnitude = poundMagnitude * 4.44822162;
                    break;
                case ForceType.Kips:
                    returnMagnitude = poundMagnitude / 1000;
                    break;
            }

            return returnMagnitude;

        }
        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        /// <summary>
        /// adds two forces
        /// </summary>
        /// <param name="f1">force one</param>
        /// <param name="f2">force two</param>
        /// <returns>the sum of the two forces</returns>
        public static ForceUnit operator +(ForceUnit f1, ForceUnit f2)
        {
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue + f2._intrinsicValue));
        }

        /// <summary>
        /// subtracts one force from the other
        /// </summary>
        /// <param name="f1">force to subtract from</param>
        /// <param name="f2">force to subtract</param>
        /// <returns>force 1 minus force 2</returns>
        public static ForceUnit operator -(ForceUnit f1, ForceUnit f2)
        {
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue - f2._intrinsicValue));
        }

        /// <summary>
        /// multiplies a force by a scalar value
        /// </summary>
        /// <param name="f1">the force to multiply</param>
        /// <param name="multiplier">double of a scalar multiplier</param>
        /// <returns>force increased by a factor of "multiplier"</returns>
        public static ForceUnit operator *(ForceUnit f1, double multiplier)
        {
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue * multiplier));
        }

        /// <summary>
        /// checks if two forces are equal
        /// </summary>
        /// <param name="f1">force 1</param>
        /// <param name="f2">force 2</param>
        /// <returns>true if force 1 equals force 2</returns>
        public static bool operator ==(ForceUnit f1, ForceUnit f2)
        {
            return f1.Equals(f2);
        }

        /// <summary>
        /// checks to see if two forces aren't equal
        /// </summary>
        /// <param name="f1">force 1</param>
        /// <param name="f2">force 2</param>
        /// <returns>true if force 1 does not equal force 2</returns>
        public static bool operator !=(ForceUnit f1, ForceUnit f2)
        {
            return !f1.Equals(f2);
        }

        /// <summary>
        /// checks if force one is greater than the other
        /// </summary>
        /// <param name="f1">supposed larger force</param>
        /// <param name="f2">supposed smaller force</param>
        /// <returns>true if f1 is greater than f2</returns>
        public static bool operator >(ForceUnit f1, ForceUnit f2)
        {
            return f1._intrinsicValue > f2._intrinsicValue;
        }

        /// <summary>
        /// checks if force one is less than the other
        /// </summary>
        /// <param name="f1">supposed smaller force</param>
        /// <param name="f2">supposed greater force</param>
        /// <returns>true if f1 is less than f2</returns>
        public static bool operator <(ForceUnit f1, ForceUnit f2)
        {
            return f1._intrinsicValue < f2._intrinsicValue;
        }

        /// <summary>
        /// checks if force one is greater than or equal to the other
        /// </summary>
        /// <param name="f1">supposed larger force</param>
        /// <param name="f2">supposed smaller force</param>
        /// <returns>true if f1 is greater than or equal to f2</returns>
        public static bool operator >=(ForceUnit f1, ForceUnit f2)
        {
            return f1.Equals(f2) || f1._intrinsicValue > f2._intrinsicValue;
        }

        /// <summary>
        /// checks if force one is less than or equal to the other
        /// </summary>
        /// <param name="f1">supposed smaller force</param>
        /// <param name="f2">supposed greater force</param>
        /// <returns>true if f1 is less than or equal to f2</returns>
        public static bool operator <=(ForceUnit f1, ForceUnit f2)
        {
            return f1.Equals(f2) || f1._intrinsicValue < f2._intrinsicValue;
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
        /// The Force class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Force.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Force class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call Force.[unit].ToString() instead");
        }

        /// <summary>
        /// returns a string representation of the force
        /// </summary>
        /// <param name="passedForce">unit you want the string in</param>
        /// <returns>string representation of force</returns>
        public string ToString(ForceType passedForce)
        {
            switch (passedForce)
            {
                case ForceType.Pounds:
                    return _intrinsicValue + " pounds";
                case ForceType.Newtons:
                    return ConvertTo(InternalUnitType, _intrinsicValue, ForceType.Newtons) + " newtons";
                case ForceType.Kips:
                    return ConvertTo(InternalUnitType, _intrinsicValue, ForceType.Kips) + " kips";
                default:
                    // should never be returned
                    return "Could not determine the unit type";
            }
        }

        /// <summary>
        /// checks to see if this is equal to the passed object
        /// </summary>
        /// <param name="obj">passed obj</param>
        /// <returns>whether the passed object is equal to this within the equality deviation constant</returns>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._intrinsicValue - ((ForceUnit)(obj))._intrinsicValue) < Constants.AcceptedEqualityDeviationConstant;
        }
        #endregion

        #region Interface Methods
        /// <summary>
        /// IComparable interface method
        /// </summary>
        /// <param name="other">forceunit to compare to</param>
        /// <returns>0 if equal; 1 if this is greater than other; -1 if this is less than other</returns>
        public int CompareTo(ForceUnit other)
        {
            if (this.Equals(other))
                return 0;
            else
                return this._intrinsicValue.CompareTo(other._intrinsicValue);
        }
        #endregion
    }
}
