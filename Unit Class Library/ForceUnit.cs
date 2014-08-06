using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    [DebuggerDisplay("{Pounds}lbs")]
    public class ForceUnit : IComparable<ForceUnit>
    {
        private const ForceType InternalUnitType = ForceType.Pounds;
        private double _intrinsicValue = 0.0;
        public double Pounds
        {
            get { return retrieveAsExternalUnit(ForceType.Pounds); }
        }

        public double Newtons
        {
            get { return retrieveAsExternalUnit(ForceType.Newtons); }
        }

        public double Kips
        {
            get { return retrieveAsExternalUnit(ForceType.Kips); }
        }


        #region Constructors

        public ForceUnit()
        {
            _intrinsicValue = 0.0;
        }

        public ForceUnit(ForceType forceType, double passedValue)
        {
            storeAsInternalUnit(forceType, passedValue);
        }


        #endregion

        #region helper methods
        private double retrieveAsExternalUnit(ForceType forceType)
        {
            return ConvertTo(InternalUnitType, _intrinsicValue, forceType);
        }

        private void storeAsInternalUnit(ForceType forceType, double passedValue)
        {
            _intrinsicValue = ConvertTo(forceType, passedValue, InternalUnitType);
        }


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

        public static ForceUnit operator +(ForceUnit f1, ForceUnit f2)
        {
            //add the two Forces together
            //return a new Force with the new value
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue + f2._intrinsicValue));
        }

        public static ForceUnit operator -(ForceUnit f1, ForceUnit f2)
        {
            //subtract the two Forces
            //return a new Force with the new value
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue - f2._intrinsicValue));
        }

        public static ForceUnit operator *(ForceUnit f1, double f2)
        {
            //multiply a force by a scalar
            //return a new Force with the new value
            return new ForceUnit(InternalUnitType, (f1._intrinsicValue * f2));
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(ForceUnit f1, ForceUnit f2)
        {
            return f1.Equals(f2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(ForceUnit f1, ForceUnit f2)
        {
            return !f1.Equals(f2);
        }

        public static bool operator >(ForceUnit f1, ForceUnit f2)
        {
            return f1._intrinsicValue > f2._intrinsicValue;
        }

        public static bool operator <(ForceUnit f1, ForceUnit f2)
        {
            return f1._intrinsicValue < f2._intrinsicValue;
        }

        public static bool operator >=(ForceUnit f1, ForceUnit f2)
        {
            return f1.Equals(f2) || f1._intrinsicValue > f2._intrinsicValue;
        }

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

        public string toString(ForceType passedForce)
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
        /// does the same thing as == if the passed in object is a d
        /// </summary>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._intrinsicValue - ((ForceUnit)(obj))._intrinsicValue) < Constants.AcceptedEqualityDeviationConstant;
        }
        #endregion

        public int CompareTo(ForceUnit other)
        {
            if (this.Equals(other))
                return 0;
            else
                return this._intrinsicValue.CompareTo(other._intrinsicValue);
        }
    }
}
