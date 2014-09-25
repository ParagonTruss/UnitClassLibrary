using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public class Area : IComparable<Area>, IArea
    {
        #region private fields and constants

        private double _intrinsicValue;
        private AreaType InternalUnitType;

        #endregion

        #region Constructors
        /// <summary>
        /// sets the area to 0
        /// </summary>
        public Area()
        {   
            _intrinsicValue = 0.0;
        }

        /// <summary>
        /// sets the area to the passed double with the passed unit type
        /// </summary>
        /// <param name="areaType">passed unit type</param>
        /// <param name="passedValue">area of unit type</param>
        public Area(AreaType areaType, double passedValue)
        {
            _intrinsicValue = passedValue;
            InternalUnitType = areaType;
        }
        #endregion

        #region Getters
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

        public double GetValue(AreaType Units)
        {
            switch (Units)
            {
                case AreaType.MillimetersSquared:
                    return MillimetersSquared;
                case AreaType.CentimetersSquared:
                    return CentimetersSquared;
                case AreaType.MetersSquared:
                    return MetersSquared;
                case AreaType.KilometersSquared:
                    return KilometersSquared;
                case AreaType.InchesSquared:
                    return InchesSquared;
                case AreaType.FeetSquared:
                    return FeetSquared;
                case AreaType.YardsSquared:
                    return YardsSquared;
                case AreaType.MilesSquared:
                    return MilesSquared;
            }
            throw new Exception("Unknown AreaType");
        }
        #endregion

        #region helper functions
        /// <summary>
        /// Uses AreaConverter to convert to the area requested from intrinsic inches
        /// </summary>
        /// <param name="areaType">unit type to retrieve area in</param>
        /// <returns>area in specified unit type</returns>
        private double retrieveAsExternalUnit(AreaType areaType)
        {
            return ConvertArea(InternalUnitType, _intrinsicValue, areaType);
        }

        /// <summary>
        /// universal converter to and from area types
        /// </summary>
        /// <param name="fromType">unit type to convert from</param>
        /// <param name="passedValue">value to convert</param>
        /// <param name="toType">unit type to convert to</param>
        /// <returns>double of area in toType</returns>
        public static double ConvertArea(AreaType fromType, double passedValue, AreaType toType)
        {
            // set up internal variables
            double returnDouble = 0;

            // switches based on what the input type is
            switch (fromType)
            {
                case AreaType.MillimetersSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue; // Return given millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue / 100; // Convert millimeters squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 0.0015500031; // Convert millimeters squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 1.07639104 * Math.Pow(10,-5); // Convert millimeters squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 1.19599005 * Math.Pow(10,-6); // Convert millimeters squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * Math.Pow(10, -6); // Convert millimeters squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * Math.Pow(10, -12); // Convert millimeters squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 3.86102159 * Math.Pow(10, -13); // Convert millimeters squared to miles squared
                            break;
                    }
                    break;
                case AreaType.CentimetersSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 100; // Convert centimeters squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue; // Return given centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 0.15500031; // Convert centimeters squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 0.00107639104; // Convert centimeters squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 1.19599005 * Math.Pow(10, -4); // Convert centimeters squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * Math.Pow(10, -4); // Convert centimeters squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * Math.Pow(10, -10); // Convert centimeters squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 3.86102159 * Math.Pow(10, -11); // Convert centimeters squared to miles squared
                            break;
                    }
                    break;
                case AreaType.InchesSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 645.16; // Convert inches squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 6.4516; // Convert inches squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue; // Return given inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 0.00694444; // Convert inches squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 0.000771605; // Convert inches squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * 0.00064516; // Convert inches squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * 6.4516 * Math.Pow(10, -10); // Convert inches squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 2.49098 * Math.Pow(10, -10); // Convert inches squared to miles squared
                            break;
                    }
                    break;
                case AreaType.FeetSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 92903.04; // Convert feet squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 929.0304; // Convert feet squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 144; // Convert feet squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue; // Return given feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 0.111111; // Convert feet squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * 0.092903; // Convert feet squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * 9.2903 * Math.Pow(10, -8); // Convert feet squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 3.58701 * Math.Pow(10, -8); // Convert feet squared to miles squared
                            break;
                    }
                    break;
                case AreaType.YardsSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 836127.36; // Convert yards squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 8361.2736; // Convert yards squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 1296; // Convert yards squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 9; // Convert yards squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue; // Return given yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * 0.836127; // Convert yards squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * 8.36127 * Math.Pow(10, -7); // Convert yards squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 3.22831 * Math.Pow(10, -7); // Convert yards squared to miles squared
                            break;
                    }
                    break;
                case AreaType.MetersSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 1000000; // Convert meters squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 10000; // Convert meters squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 1550; // Convert meters squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 10.7639; // Convert meters squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 1.19599; // Convert meters squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue; // Return given meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue * Math.Pow(10, -6); // Convert meters squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 3.86102 * Math.Pow(10, -7); // Convert meters squared to miles squared
                            break;
                    }
                    break;
                case AreaType.KilometersSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 1000000000000; // Convert kilometers squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 10000000000; // Convert kilometers squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 1.55 * Math.Pow(10, 9); // Convert kilometers squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 1.07639 * Math.Pow(10, 7); // Convert kilometers squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 1.19599 * Math.Pow(10, 6); // Convert kilometers squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * 1000000; // Convert kilometers squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = passedValue; // Return given kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 0.386102; // Convert kilometers squared to miles squared
                            break;
                    }
                    break;
                case AreaType.MilesSquared:
                    switch (toType)
                    {
                        case AreaType.MillimetersSquared:
                            returnDouble = passedValue * 2589988110336; // Convert miles squared to millimeters squared
                            break;
                        case AreaType.CentimetersSquared:
                            returnDouble = passedValue * 2.58998811 * Math.Pow(10,10); // Convert miles squared to centimeters squared
                            break;
                        case AreaType.InchesSquared:
                            returnDouble = passedValue * 4014489600; // Convert miles squared to inches squared
                            break;
                        case AreaType.FeetSquared:
                            returnDouble = passedValue * 27878400; // Convert miles squared to feet squared
                            break;
                        case AreaType.YardsSquared:
                            returnDouble = passedValue * 3097600; // Convert miles squared to yards squared
                            break;
                        case AreaType.MetersSquared:
                            returnDouble = passedValue * 2589990; // Convert miles squared to meters squared
                            break;
                        case AreaType.KilometersSquared:
                            returnDouble = 2.58999; // Convert miles squared to kilometers squared
                            break;
                        case AreaType.MilesSquared:
                            returnDouble = passedValue * 0.386102; // Return miles squared
                            break;
                    }
                    break;
            }

            return returnDouble;
        }
        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        /// <summary>
        /// adds two areas together
        /// </summary>
        /// <param name="a1">area 1</param>
        /// <param name="a2">area 2</param>
        /// <returns>sum of two areas</returns>
        public static Area operator +(Area a1, Area a2)
        {
            //add the two Areas together
            //return a new Area with the new value
            return new Area(a1.InternalUnitType, (a1._intrinsicValue + a2.GetValue(a1.InternalUnitType)));
        }

        /// <summary>
        /// subtracts an area from the other
        /// </summary>
        /// <param name="a1">area to be subtracted from</param>
        /// <param name="a2">area to subtract</param>
        /// <returns>d1 - d2</returns>
        public static Area operator -(Area a1, Area a2)
        {
            //subtract the two Areas
            //return a new Area with the new value
            return new Area(a1.InternalUnitType, (a1._intrinsicValue - a2.GetValue(a1.InternalUnitType)));
        }

        /// <summary>
        /// checks equality of two areas
        /// </summary>
        /// <param name="a1">area 1</param>
        /// <param name="a2">area 2</param>
        /// <returns>true if the areas are equal</returns>
        public static bool operator ==(Area a1, Area a2)
        {
            return a1.Equals(a2);
        }

        /// <summary>
        /// checks inequality of two areas
        /// </summary>
        /// <param name="a1">area 1</param>
        /// <param name="a2">area 2</param>
        /// <returns>true if the areas are not equal</returns>
        public static bool operator !=(Area a1, Area a2)
        {
            return !a1.Equals(a2);
        }

        /// <summary>
        /// checks specific inequality of two areas
        /// </summary>
        /// <param name="a1">area supposed to be larger</param>
        /// <param name="a2">area supposed to be smaller</param>
        /// <returns>whether the first area is larger than second area</returns>
        public static bool operator >(Area a1, Area a2)
        {
            return a1._intrinsicValue > a2.GetValue(a1.InternalUnitType);
        }

        /// <summary>
        /// checks specific inequality of two areas
        /// </summary>
        /// <param name="a1">area supposed to be smaller</param>
        /// <param name="a2">area supposed to be larger</param>
        /// <returns>whether the first area is smaller than second area</returns>
        public static bool operator <(Area a1, Area a2)
        {
            return a1._intrinsicValue < a2.GetValue(a1.InternalUnitType);
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
        /// checks equality within the Accepted Equality Deviation
        /// </summary>
        /// <param name="obj">object to check equality against</param>
        /// <returns>true if the areas are equal</returns>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._intrinsicValue - ((Area)(obj)).GetValue(this.InternalUnitType)) < Constants.AcceptedEqualityDeviationConstant;
        }

        #endregion

        #region Interface Implementations
        /// <summary>
        /// This implements the IComparable interface and allows Areas to be sorted and such
        /// </summary>
        /// <param name="other">area to check against</param>
        /// <returns>0 if equal; 1 if this > other; -1 if this < other</returns>
        public int CompareTo(Area other)
        {
            // We use the equals to avoid having to rehash the equality deviation
            // and then we check using the intrinsic value
            if (this.Equals(other))
                return 0;
            else
                return _intrinsicValue.CompareTo(other._intrinsicValue);
        }
        #endregion
    }
}
