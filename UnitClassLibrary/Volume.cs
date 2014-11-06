using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    ///Dimension class for volume
    /// </summary>
    public class Volume
    {
        #region _internalVariables
        double _intrinsicValue;
        private VolumeType InternalUnitType;
        #endregion

        #region Constructors
        /// <summary>
        /// sets the volume to 0
        /// </summary>		
        public Volume()
        {
            _intrinsicValue = 0.0;
            //InternalUnitType = VolumeType.Milliliters;
        }

        /// <summary>
        /// sets the volume to the passed double with the passed unit type
        /// </summary>
        /// <param name="volumeType">passed unit type</param>
        /// <param name="passedValue">volume of unit type</param>		
        public Volume(VolumeType volumeType, double passedValue)
        {
            storeAsInternalUnit(volumeType, passedValue);
        }
        #endregion

        #region getters
        /// <summary>
        /// uses Milliliters as a property and retrieves as an external unit when necessary
        /// </summary>		
        public double Milliliters
        {
            get { return retrieveAsExternalUnit(VolumeType.Milliliters); }
        }

        /// <summary>
        /// uses CubicCentimeters as a property and retrieves as an external unit when necessary
        /// </summary>		
        public double CubicCentimeters
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicCentimeters); }
        }

        /// <summary>
        /// uses Liters as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double Liters
        {
            get { return retrieveAsExternalUnit(VolumeType.Liters); }
        }

        /// <summary>
        /// uses CubicMeters as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicMeters
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicMeters); }
        }

        /// <summary>
        /// uses CubicInches as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicInches
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicInches); }
        }

        /// <summary>
        /// uses CubicFeet as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicFeet
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicFeet); }
        }

        /// <summary>
        /// uses CubicYards as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicYards
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicYards); }
        }

        /// <summary>
        /// uses CubicMiles as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicMiles
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicMiles); }
        }

        /// <summary>
        /// uses Gallons as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double Gallons
        {
            get { return retrieveAsExternalUnit(VolumeType.Gallons); }
        }

        /// <summary>
        /// uses Quarts as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double Quarts
        {
            get { return retrieveAsExternalUnit(VolumeType.Quarts); }
        }

        /// <summary>
        /// uses Pints as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double Pints
        {
            get { return retrieveAsExternalUnit(VolumeType.Pints); }
        }

        /// <summary>
        /// uses Cups as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double Cups
        {
            get { return retrieveAsExternalUnit(VolumeType.Cups); }
        }

        /// <summary>
        /// uses FluidOunces as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double FluidOunces
        {
            get { return retrieveAsExternalUnit(VolumeType.FluidOunces); }
        }
        #endregion

        #region helper functions

        /// <summary>
        /// Stores as internal inches from the type and value passed in
        /// </summary>
        /// <param name="passedType">unit type</param>
        /// <param name="passedValue">value to set area to</param>
        private void storeAsInternalUnit(VolumeType passedType, double passedValue)
        {
            _intrinsicValue = ConvertVolume(passedType, passedValue, VolumeType.Milliliters);
        }

        /// <summary>
        /// Uses VolumeConverter to convert to the volume requested from intrinsic Milliliters
        /// </summary>
        /// <param name="volumeType">unit type to retrieve volume in</param>
        /// <returns>volume in specified unit type</returns>
        private double retrieveAsExternalUnit(VolumeType volumeType)
        {
            return ConvertVolume(VolumeType.Milliliters, _intrinsicValue, volumeType);
        }

        /// <summary>
        /// universal converter to and from volume types
        /// </summary>
        /// <param name="fromType">unit type to convert from</param>
        /// <param name="passedValue">value to convert</param>
        /// <param name="toType">unit type to convert to</param>
        /// <returns>double of volume in toType</returns>
        public static double ConvertVolume(VolumeType fromType, double passedValue, VolumeType toType)
        {
            // sets up internal variables
            double returnDouble = 0;
            double internalMilliliters = 0;

            // switches based on what the input type is
            switch (fromType)
            {
                case VolumeType.Milliliters:
                    internalMilliliters = passedValue;
                    break;
                case VolumeType.CubicCentimeters:
                    internalMilliliters = passedValue;
                    break;
                case VolumeType.Liters:
                    internalMilliliters = passedValue * 1000;
                    break;
                case VolumeType.CubicMeters:
                    internalMilliliters = passedValue * 1000000;
                    break;
                case VolumeType.CubicInches:
                    internalMilliliters = passedValue * 16.3871;
                    break;
                case VolumeType.CubicFeet:
                    internalMilliliters = passedValue * 28316.8;
                    break;
                case VolumeType.CubicYards:
                    internalMilliliters = passedValue * 84950.5;
                    break;
                case VolumeType.CubicMiles:
                    internalMilliliters = passedValue * 4168181830000000;
                    break;
                case VolumeType.Gallons:
                    internalMilliliters = passedValue * 3785.41;
                    break;
                case VolumeType.Quarts:
                    internalMilliliters = passedValue * 946.353;
                    break;
                case VolumeType.Pints:
                    internalMilliliters = passedValue * 473.176;
                    break;
                case VolumeType.Cups:
                    internalMilliliters = passedValue * 236.588;
                    break;
                case VolumeType.FluidOunces:
                    internalMilliliters = passedValue * 29.5735;
                    break;
            }

            // switches based on what the output type is
            switch (toType)
            {
                case VolumeType.Milliliters:
                    returnDouble = internalMilliliters;
                    break;
                case VolumeType.CubicCentimeters:
                    returnDouble = internalMilliliters;
                    break;
                case VolumeType.Liters:
                    returnDouble = internalMilliliters / 1000;
                    break;
                case VolumeType.CubicMeters:
                    returnDouble = internalMilliliters / 1000000;
                    break;
                case VolumeType.CubicInches:
                    returnDouble = internalMilliliters / 16.3871;
                    break;
                case VolumeType.CubicFeet:
                    returnDouble = internalMilliliters / 28316.8;
                    break;
                case VolumeType.CubicYards:
                    returnDouble = internalMilliliters / 84950.5;
                    break;
                case VolumeType.CubicMiles:
                    returnDouble = internalMilliliters / 4168181830000000;
                    break;
                case VolumeType.Gallons:
                    returnDouble = internalMilliliters / 3785.41;
                    break;
                case VolumeType.Quarts:
                    returnDouble = internalMilliliters / 946.353;
                    break;
                case VolumeType.Pints:
                    returnDouble = internalMilliliters / 473.176;
                    break;
                case VolumeType.Cups:
                    returnDouble = internalMilliliters / 236.588;
                    break;
                case VolumeType.FluidOunces:
                    returnDouble = internalMilliliters / 29.5735;
                    break;
            }

            return returnDouble;
        }
        #endregion

        #region Overloaded Operators

        /// <summary>
        /// adds two volumes together
        /// </summary>
        /// <param name="v1">volume 1</param>
        /// <param name="v2">volume 2</param>
        /// <returns>sum of two volumes</returns>
        public static Volume operator +(Volume v1, Volume v2)
        {
            //add the two Volumes together
            //return a new Volume with the new value
            return new Volume(v1.InternalUnitType, (v1._intrinsicValue + v2._intrinsicValue));
        }

        /// <summary>
        /// subtracts a volume from the other
        /// </summary>
        /// <param name="d1">volume to be subtracted from</param>
        /// <param name="d2">volume to subtract</param>
        /// <returns>d1 - d2</returns>
        public static Volume operator -(Volume d1, Volume d2)
        {
            //subtract the two Volumes
            //return a new Volume with the new value
            return new Volume(d1.InternalUnitType, (d1._intrinsicValue - d2._intrinsicValue));
        }

        /// <summary>
        /// checks equality of two volumes
        /// </summary>
        /// <param name="d1">volume 1</param>
        /// <param name="d2">volume 2</param>
        /// <returns>true if the volumes are equal</returns>
        public static bool operator ==(Volume d1, Volume d2)
        {
            if ((object)d1 == null)
            {
                if ((object)d2 == null)
                {
                    return true;
                }
                return false;
            }
            return d1.Equals(d2);
        }

        /// <summary>
        /// checks inequality of two volumes
        /// </summary>
        /// <param name="d1">volume 1</param>
        /// <param name="d2">volume 2</param>
        /// <returns>true if the volumes are not equal</returns>
        public static bool operator !=(Volume d1, Volume d2)
        {
            if ((object)d1 == null)
            {
                if ((object)d2 == null)
                {
                    return false;
                }
                return true;
            }
            return !d1.Equals(d2);
        }

        /// <summary>
        /// checks specific inequality of two volumes
        /// </summary>
        /// <param name="d1">volume supposed to be larger</param>
        /// <param name="d2">volume supposed to be smaller</param>
        /// <returns>whether the first volume is larger than second volume</returns>
        public static bool operator >(Volume d1, Volume d2)
        {
            return d1._intrinsicValue > d2._intrinsicValue;
        }

        /// <summary>
        /// checks specific inequality of two volumes
        /// </summary>
        /// <param name="d1">volume supposed to be smaller</param>
        /// <param name="d2">volume supposed to be larger</param>
        /// <returns>whether the first volume is smaller than second volume</returns>
        public static bool operator <(Volume d1, Volume d2)
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
        /// The Volume class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Volume.[unit].ToString() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Volume class does not know what type of unit it contains, (Because it should be thought of as containing all unit types) Call Volume.[unit].ToString() instead");
        }

        /// <summary>
        /// checks equality within the Accepted Equality Deviation
        /// </summary>
        /// <param name="obj">object to check equality against</param>
        /// <returns>true if the volumes are equal</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            try
            {
                Volume other = (Volume)obj;
                return Math.Abs(this._intrinsicValue - other._intrinsicValue) == 0;
            }
            catch
            {
                return false;
            }
        }
        
        #endregion

        #region Interface Implementations
        /// <summary>
        /// This implements the IComparable interface and allows Volumes to be sorted and such
        /// </summary>
        /// <param name="other">volume to check against</param>
        /// <returns>0 if equal; 1 if this > other; -1 if this < other</returns>
        public int CompareTo(Volume other)
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