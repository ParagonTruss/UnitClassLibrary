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

        internal VolumeType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private VolumeType _internalUnitType;  
      
        double _intrinsicValue = 0.0;

        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>		
        public Volume()
        {
            _intrinsicValue = 0.0;
        }

        /// <summary>
        /// copy constructor - create a new Volume with the same _intrinsicValue as the passed Volume
        /// </summary>
        public Volume(Volume passedVolume)
        {
            _intrinsicValue = passedVolume._intrinsicValue;
            _internalUnitType = passedVolume._internalUnitType;
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
        /// uses CubicThirtySeconds as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicThirtySeconds
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicThirtySeconds); }
        }

        /// <summary>
        /// uses CubicSixteenths as a property and retrieves as an external unit when necessary
        /// </summary>			
        public double CubicSixteenths
        {
            get { return retrieveAsExternalUnit(VolumeType.CubicSixteenths); }
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

        public double GetValue(VolumeType Units)
        {
            switch(Units)
            {
                case VolumeType.Milliliters:
                    return Milliliters;
                case VolumeType.CubicCentimeters:
                    return CubicCentimeters;
                case VolumeType.Liters:
                    return Liters;
                case VolumeType.CubicMeters:
                    return CubicMeters;
                case VolumeType.CubicThirtySeconds:
                    return CubicThirtySeconds;
                case VolumeType.CubicSixteenths:
                    return CubicSixteenths;
                case VolumeType.CubicInches:
                    return CubicInches;
                case VolumeType.CubicFeet:
                    return CubicFeet;
                case VolumeType.CubicYards:
                    return CubicYards;
                case VolumeType.CubicMiles:
                    return CubicMiles;
                case VolumeType.Gallons:
                    return Gallons;
                case VolumeType.Quarts:
                    return Quarts;
                case VolumeType.Pints:
                    return Pints;
                case VolumeType.Cups:
                    return Cups;
                case VolumeType.FluidOunces:
                    return FluidOunces;
            }

            throw new Exception("Unknown VolumeType");
        }
        #endregion

        #region helper functions

        /// <summary>
        /// Stores the value argument according to the type argument.
        /// </summary>
        /// <param name="passedType">unit type</param>
        /// <param name="passedValue">value to set area to</param>
        private void storeAsInternalUnit(VolumeType passedType, double passedValue)
        {
            _internalUnitType = passedType;
            _intrinsicValue = passedValue;
        }

        /// <summary>
        /// Uses VolumeConverter to convert to the volume requested from intrinsic Milliliters
        /// </summary>
        /// <param name="volumeType">unit type to retrieve volume in</param>
        /// <returns>volume in specified unit type</returns>
        private double retrieveAsExternalUnit(VolumeType retrievalVolumeType)
        {
            return ConvertVolume(_internalUnitType, _intrinsicValue, retrievalVolumeType);
        }

        /// <summary>
        /// universal converter to and from volume types
        /// </summary>
        /// <param name="typeConvertingFrom">unit type to convert from</param>
        /// <param name="passedValue">value to convert</param>
        /// <param name="typeConvertingTo">unit type to convert to</param>
        /// <returns>double of volume in typeConvertingTo</returns>
        public static double ConvertVolume(VolumeType typeConvertingFrom, double passedValue, VolumeType typeConvertingTo)
        {
            double returnDouble = 0.0;

            switch(typeConvertingFrom)
            {
                case VolumeType.Milliliters:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.001;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000001;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 1999.6246016;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 249.9530752;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 0.0610237;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.000035315;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00000130796;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000000000023991502;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.000264172;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.00105669;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.00211338;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.00422675;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 0.033814;
                            break;
                    }
                    break;
                case VolumeType.CubicCentimeters:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.001;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000001;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 1999.6246016;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 249.9530752;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 0.0610237;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.000035315;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00000130796;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000000000023991502;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.000264172;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.00105669;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.00211338;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.00422675;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 0.033814;
                            break;
                    }
                    break;
                case VolumeType.Liters:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 1000;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 1000;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.001;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 1999624.6016;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 249953.0752;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 61.0237;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.0353147;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00130795185;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000000023991298;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.264172;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 1.05669;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 2.11338;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 4.22675;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 33.814;
                            break;
                    }
                    break;
                case VolumeType.CubicMeters:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 1000000;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 1000000;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 1000;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 1999624601.6;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 249953075.2;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 61023.7;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 35.3147;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 1.30795185185;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000023991298;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 264.172;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 1056.69;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 2113.38;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 4226.75;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 33814;
                            break;
                    }
                    break;
                case VolumeType.CubicThirtySeconds:
                    switch (typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 16.387064;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 16.387064;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.016387064;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000016387064;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue / 8;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue / 32768;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.00057870370354;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00002143347;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000000039314657;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.004329004329;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.017316017316;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.034632034632;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.069264069264;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 0.55411255411;
                            break;
                    }
                    break;
                case VolumeType.CubicSixteenths:
                    switch (typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 16.387064;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 16.387064;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.016387064;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000016387064;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 8;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue / 4096;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.00057870370354;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00002143347;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000000039314657;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.004329004329;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.017316017316;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.034632034632;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.069264069264;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 0.55411255411;
                            break;
                    }
                    break;
                case VolumeType.CubicInches:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 16.3871;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 16.3871;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.0163871;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000016387;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 32768;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 4096;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.000578704;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00002143348;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000000039314677;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.004329;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.017316;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.034632;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.0692641;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 0.554113;
                            break;
                    }
                    break;
                case VolumeType.CubicFeet:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 28316.8;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 28316.8;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 28.3168;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.0283168;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 56623104;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 7077888;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 1728;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue / 27;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue / 147197952000;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 7.48052;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 29.9221;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 59.8442;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 119.688;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 957.506;
                            break;
                    }
                    break;
                case VolumeType.CubicYards:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 28316.8466;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 28316.8466;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 28.3168466;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.0283168466;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 56623104;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 7077888;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 1728;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 27;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000039743447; // 27 * (5280^3) ?
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 7.480519483;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 29.92207793;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 59.84415586;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 119.6883117;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 957.5064938;
                            break;
                    }
                    break;
                case VolumeType.CubicMiles:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 149512950;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 149512950;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 149512.95;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 149.51295;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 298969989120;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 37371248640;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 9123840;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 147197952000; // Multiplied by 5280^3
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 5451776000; // Multiplied by 1760^3 (?)
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 39497.1429;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 157988.571;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 315977.143;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 631954.286;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 5055634.29;
                            break;
                    }
                    break;
                case VolumeType.Gallons:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 3785.41;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 3785.41;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 3.78541;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.00378541;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 7569408;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 946176;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 231;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.133681;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00495114814;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000009081716;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 4;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 8;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 16;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 128;
                            break;
                    }
                    break;
                case VolumeType.Quarts:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 946.353;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 946.353;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.946353;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000946353;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 1892352;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 236544;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 57.75;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.0334201;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00123778148;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000000022704188;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.25;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 2;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 4;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 32;
                            break;
                    }
                    break;
                case VolumeType.Pints:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 473.176;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 473.176;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.473176;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000473176;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 946176;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 118272;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 28.875;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.0167101;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00061889259;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.00000000000011352128;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.125;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.5;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 2;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 16;
                            break;
                    }
                    break;
                case VolumeType.Cups:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 236.588;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 236.588;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.236588;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000236588;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 473088;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 59136;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 14.4375;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.00835503;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00030944555;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.000000000000056760504;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.0625;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.25;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.5;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue * 8;
                            break;
                    }
                    break;
                case VolumeType.FluidOunces:
                    switch(typeConvertingTo)
                    {
                        case VolumeType.Milliliters:
                            returnDouble = passedValue * 29.5735;
                            break;
                        case VolumeType.CubicCentimeters:
                            returnDouble = passedValue * 29.5735;
                            break;
                        case VolumeType.Liters:
                            returnDouble = passedValue * 0.0295735;
                            break;
                        case VolumeType.CubicMeters:
                            returnDouble = passedValue * 0.000029574;
                            break;
                        case VolumeType.CubicThirtySeconds:
                            returnDouble = passedValue * 59136.08192;
                            break;
                        case VolumeType.CubicSixteenths:
                            returnDouble = passedValue * 7392.01024;
                            break;
                        case VolumeType.CubicInches:
                            returnDouble = passedValue * 1.80469;
                            break;
                        case VolumeType.CubicFeet:
                            returnDouble = passedValue * 0.00104438;
                            break;
                        case VolumeType.CubicYards:
                            returnDouble = passedValue * 0.00003868074;
                            break;
                        case VolumeType.CubicMiles:
                            returnDouble = passedValue * 0.0000000000000070950715;
                            break;
                        case VolumeType.Gallons:
                            returnDouble = passedValue * 0.0078125;
                            break;
                        case VolumeType.Quarts:
                            returnDouble = passedValue * 0.03125;
                            break;
                        case VolumeType.Pints:
                            returnDouble = passedValue * 0.0625;
                            break;
                        case VolumeType.Cups:
                            returnDouble = passedValue * 0.125;
                            break;
                        case VolumeType.FluidOunces:
                            returnDouble = passedValue;
                            break;
                    }
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
            return new Volume(v1._internalUnitType, (v1.GetValue(v1._internalUnitType) + v2.GetValue(v1._internalUnitType)));
        }

        /// <summary>
        /// subtracts a volume from the other
        /// </summary>
        /// <param name="v1">volume to be subtracted from</param>
        /// <param name="v2">volume to subtract</param>
        /// <returns>v1 - v2</returns>
        public static Volume operator -(Volume v1, Volume v2)
        {
            //subtract the two Volumes
            //return a new Volume with the new value
            return new Volume(v1._internalUnitType, (v1.GetValue(v1._internalUnitType) - v2.GetValue(v1._internalUnitType)));
        }

        /// <summary>
        /// checks equality of two volumes
        /// </summary>
        /// <param name="v1">volume 1</param>
        /// <param name="v2">volume 2</param>
        /// <returns>true if the volumes are equal</returns>
        public static bool operator ==(Volume v1, Volume v2)
        {
            return v1.Equals(v2);
        }

        /// <summary>
        /// checks inequality of two volumes
        /// </summary>
        /// <param name="v1">volume 1</param>
        /// <param name="v2">volume 2</param>
        /// <returns>true if the volumes are not equal</returns>
        public static bool operator !=(Volume v1, Volume v2)
        {
            return !v1.Equals(v2);
        }

        /// <summary>
        /// checks specific inequality of two volumes
        /// </summary>
        /// <param name="v1">volume supposed to be larger</param>
        /// <param name="v2">volume supposed to be smaller</param>
        /// <returns>whether the first volume is larger than second volume</returns>
        public static bool operator >(Volume v1, Volume v2)
        {
            return v1._intrinsicValue > v2.GetValue(v1._internalUnitType);
        }

        /// <summary>
        /// checks specific inequality of two volumes
        /// </summary>
        /// <param name="v1">volume supposed to be smaller</param>
        /// <param name="v2">volume supposed to be larger</param>
        /// <returns>whether the first volume is smaller than second volume</returns>
        public static bool operator <(Volume v1, Volume v2)
        {
            return v1._intrinsicValue < v2.GetValue(v1._internalUnitType);
        }

        public static bool operator >=(Volume v1, Volume v2)
        {
            return v1.Equals(v2) || v1 > v2;
        }

        public static bool operator <=(Volume v1, Volume v2)
        {
            return v1.Equals(v2) || v1 < v2;
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
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in Constants
        /// </summary>
        public override bool Equals(object obj)
        {
            return (Math.Abs(this.GetValue(this._internalUnitType) - ((Volume)(obj)).GetValue(this._internalUnitType))) <= Math.Abs(this.GetValue(this._internalUnitType) * 0.0001);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Volume passedAcceptedEqualityDeviationVolume)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Volume)(obj)).GetValue(this._internalUnitType))
                ))
                <= passedAcceptedEqualityDeviationVolume.GetValue(_internalUnitType);
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
            if(this.Equals(other))
            {
                return 0;
            }
            else if(this > other)
            {
                return 1;
            }
            else // this instance should be greater than other
            {
                return -1;
            }
        }
        #endregion
    }
}