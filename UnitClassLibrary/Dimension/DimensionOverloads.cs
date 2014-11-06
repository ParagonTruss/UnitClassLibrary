using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Dimension
    {
        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Dimension operator +(Dimension d1, Dimension d2)
        {
            //add the two dimensions together
            //return a new dimension with the new value
            return new Dimension(d1._internalUnitType, d1._intrinsicValue + d2.GetValue(d1._internalUnitType));
        }

        public static Dimension operator -(Dimension d1, Dimension d2)
        {
            //subtract the two dimensions
            //return a new dimension with the new value
            return new Dimension(d1._internalUnitType, d1._intrinsicValue - d2.GetValue(d1._internalUnitType));
        }

        public static double operator /(Dimension d1, Dimension d2)
        {
            return d1.GetValue(d1._internalUnitType) / d2.GetValue(d1._internalUnitType);
        }

        public static Area operator *(Dimension d1, Dimension d2)
        {
            return new Area(d1, d2);
        }

        public static Dimension operator *(Dimension d1, double multiplier)
        {
            return new Dimension(d1._internalUnitType, d1._intrinsicValue * multiplier);
        }

        public static Dimension operator /(Dimension d1, double divisor)
        {
            return new Dimension(d1.InternalUnitType, d1._intrinsicValue / divisor);
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Dimension d1, Dimension d2)
        {
            return !d1.Equals(d2);
        }

        public static bool operator >(Dimension d1, Dimension d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue > d2.GetValue(d1._internalUnitType);
        }

        public static bool operator <(Dimension d1, Dimension d2)
        {
            if (d1 == d2)
            {
                return false;
            }
            return d1._intrinsicValue < d2.GetValue(d1._internalUnitType);
        }

        public static bool operator <=(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2) || d1 < d2;
        }

        public static bool operator >=(Dimension d1, Dimension d2)
        {
            return d1.Equals(d2) || d1 > d2;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return this.GetValue(_internalUnitType).GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Dimension class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call dimension.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Dimension class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call dimension.[unit].ToString() instead");
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in Constants
        /// </summary>
        public override bool Equals(object obj)
        {
            return (Math.Abs(this.GetValue(this._internalUnitType) - ((Dimension)(obj)).GetValue(this._internalUnitType))) <= Math.Abs(this.GetValue(this._internalUnitType) * 0.00001);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Dimension passedAcceptedEqualityDeviationDimension)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Dimension)(obj)).GetValue(this._internalUnitType))
                ))
                < passedAcceptedEqualityDeviationDimension.GetValue(_internalUnitType);
        }

        #endregion

        #region Undecided Functionality

        /// <summary>
        /// Creates a new dimension that is the negative of the current one
        /// </summary>
        /// <returns></returns>
        public Dimension Negate()
        {
            return new Dimension(_internalUnitType, _intrinsicValue * -1);
        }

        public Dimension AbsoluteValue()
        {
            return new Dimension(_internalUnitType, Math.Abs(_intrinsicValue));
        }

        public static Dimension operator ^(Dimension d1, double power)
        {
            return new Dimension(d1._internalUnitType, Math.Pow(d1._intrinsicValue, power));
        }

        public Dimension RaiseToPower(double power)
        {
            return new Dimension(_internalUnitType, Math.Pow(_intrinsicValue, power));
        }

        #endregion
    }
}
