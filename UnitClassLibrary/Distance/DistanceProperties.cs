using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Distance
    {
        public double Sixteenths
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Sixteenth); }
        }

        public double ThirtySeconds
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.ThirtySecond); }
        }

        public double Inches
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch); }
        }

        public double Feet
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Foot); }
        }

        public double Yards
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Yard); }
        }

        public double Miles
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Mile); }
        }

        public double Millimeters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Millimeter); }
        }

        public double Centimeters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Centimeter); }
        }

        public double Meters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Meter); }
        }

        public double Kilometers
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Kilometer); }
        }

        /// <summary>
        /// Returns the Distance as a string in AutoCAD notation with sixteenths of an inch percision
        /// </summary>
        public string Architectural
        {
            get { return _retrieveIntrinsicValueAsArchitecturalString(); }
        }

        public double GetValue(DistanceType Units)
        {
            switch (Units)
            {
                case DistanceType.Millimeter:
                    return Millimeters;
                case DistanceType.Centimeter:
                    return Centimeters;
                case DistanceType.Meter:
                    return Meters;
                case DistanceType.Kilometer:
                    return Kilometers;
                case DistanceType.ThirtySecond:
                    return ThirtySeconds;
                case DistanceType.Sixteenth:
                    return Sixteenths;
                case DistanceType.Inch:
                    return Inches;
                case DistanceType.Foot:
                    return Feet;
                case DistanceType.Yard:
                    return Yards;
                case DistanceType.Mile:
                    return Miles;
                case DistanceType.ArchitecturalString:
                    throw new Exception("Cannot return a double value from architectural string");
            }
            throw new Exception("Unknown DistanceType");
        }
    }
}
