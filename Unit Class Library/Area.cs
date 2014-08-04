using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public class Area
    {
        #region private fields and constants

        private double _intrinsicValue;
        private const AreaType InternalUnitType = AreaType.InchesSquared;

        #endregion

        #region Constructors

        public Area()
        {   
            _intrinsicValue = 0.0;
        }

        public Area(AreaType areaType, double passedValue)
        {
            storeAsInternalUnit(areaType, passedValue);
        }
        #endregion

        #region getters
        /// <summary>
        /// uses millimeters squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double MillimetersSquared
        {
            get { return retrieveAsExternalUnit(AreaType.MillimetersSquared); }
        }

        /// <summary>
        /// uses centimeters squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double CentimetersSquared
        {
            get { return retrieveAsExternalUnit(AreaType.CentimetersSquared); }
        }

        /// <summary>
        /// uses inches squared as a property and retrieves it as an external unit when necessary
        /// </summary>
        public double InchesSquared
        {
            get { return retrieveAsExternalUnit(AreaType.InchesSquared); }
        }
        
        /// <summary>
        /// uses feet squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double FeetSquared
        {
            get { return retrieveAsExternalUnit(AreaType.FeetSquared); }
        }

        /// <summary>
        /// uses yards squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double YardsSquared
        {
            get { return retrieveAsExternalUnit(AreaType.YardsSquared); }
        }

        /// <summary>
        /// uses meters squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double MetersSquared
        {
            get { return retrieveAsExternalUnit(AreaType.MetersSquared); }
        }

        /// <summary>
        /// uses kilometers squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double KilometersSquared
        {
            get { return retrieveAsExternalUnit(AreaType.KilometersSquared); }
        }

        /// <summary>
        /// uses miles squared as a property and retrieves as an external unit when necessary
        /// </summary>
        public double MilesSquared
        {
            get { return retrieveAsExternalUnit(AreaType.MilesSquared); }
        }
#endregion

        #region helper functions
        /// <summary>
        /// Uses AreaConverter to convert to the area requested from intrinsic inches
        /// </summary>
        /// <param name="areaType"></param>
        /// <returns></returns>
        private double retrieveAsExternalUnit(AreaType areaType)
        {
            return ConvertArea(AreaType.InchesSquared, _intrinsicValue, areaType);
        }

        /// <summary>
        /// Stores as internal inches from the type and value passed in
        /// </summary>
        /// <param name="passedType"></param>
        /// <param name="passedValue"></param>
        private void storeAsInternalUnit(AreaType passedType, double passedValue)
        {
            _intrinsicValue = ConvertArea(passedType, passedValue, AreaType.InchesSquared);
        }
        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Area operator +(Area a1, Area a2)
        {
            //add the two Areas together
            //return a new Area with the new value
            return new Area(InternalUnitType, (a1._intrinsicValue + a2._intrinsicValue));
        }

        public static Area operator -(Area d1, Area d2)
        {
            //subtract the two Areas
            //return a new Area with the new value
            return new Area(InternalUnitType, (d1._intrinsicValue - d2._intrinsicValue));
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Area d1, Area d2)
        {
            return d1.Equals(d2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Area d1, Area d2)
        {
            return !d1.Equals(d2);
        }

        public static bool operator >(Area d1, Area d2)
        {
            return d1._intrinsicValue > d2._intrinsicValue;
        }

        public static bool operator <(Area d1, Area d2)
        {
            return d1._intrinsicValue < d2._intrinsicValue;
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
        /// The Area class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Area.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Area class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call Area.[unit].ToString() instead");
        }

        /// <summary>
        /// does the same thing as == if the passed in object is a d
        /// </summary>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._intrinsicValue - ((Area)(obj))._intrinsicValue) < Constants.AcceptedEqualityDeviationConstant;
        }

        #endregion

        /// <summary>
        /// This implements the IComparable interface and allows Areas to be sorted and such
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Area other)
        {
            // We use the equals to avoid having to rehash the equality deviation
            // and then we check using the intrinsic value
            if (this.Equals(other))
                return 0;
            else
                return _intrinsicValue.CompareTo(other._intrinsicValue);
        }

        public static double ConvertArea(AreaType fromType, double passedValue, AreaType toType)
        {
            double returnDouble = 0;
            double internalInches = 0;

            switch (fromType)
            {
                case AreaType.MillimetersSquared:
                    internalInches = passedValue / 645.16;
                    break;
                case AreaType.CentimetersSquared:
                    internalInches = passedValue / 6.4516;
                    break;
                case AreaType.InchesSquared:
                    internalInches = passedValue;
                    break;
                case AreaType.FeetSquared:
                    internalInches = passedValue * 144.0;
                    break;
                case AreaType.YardsSquared:
                    internalInches = passedValue * 1296.0;
                    break;
                case AreaType.MetersSquared:
                    internalInches = passedValue * 1550.0031;
                    break;
                case AreaType.KilometersSquared:
                    internalInches = passedValue * 1550003100.0;
                    break;
                case AreaType.MilesSquared:
                    internalInches = passedValue * 4014489599.9;
                    break;
            }

            switch (toType)
            {
                case AreaType.MillimetersSquared:
                    returnDouble = internalInches * 645.16;
                    break;
                case AreaType.CentimetersSquared:
                    returnDouble = internalInches * 6.4516;
                    break;
                case AreaType.InchesSquared:
                    returnDouble = internalInches;
                    break;
                case AreaType.FeetSquared:
                    returnDouble = internalInches / 144.0;
                    break;
                case AreaType.YardsSquared:
                    returnDouble = internalInches / 1296.0;
                    break;
                case AreaType.MetersSquared:
                    returnDouble = internalInches / 1550.0031;
                    break;
                case AreaType.KilometersSquared:
                    returnDouble = internalInches / 1550003100.0;
                    break;
                case AreaType.MilesSquared:
                    returnDouble = internalInches / 4014489599.9;
                    break;
            }

            return returnDouble;
        }
    }
}
