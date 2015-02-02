using System;
using System.Collections.Generic;
 
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Broken
    {
        public double Sixteenths
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Sixteenth); }
        }

        public double ThirtySeconds
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.ThirtySecond); }
        }

        public double Inches
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Inch); }
        }

        public double Feet
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Foot); }
        }

        public double Yards
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Yard); }
        }

        public double Miles
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Mile); }
        }

        public double Millimeters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Millimeter); }
        }

        public double Centimeters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Centimeter); }
        }

        public double Meters
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Meter); }
        }

        public double Kilometers
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(BrokenType.Kilometer); }
        }

        /// <summary>
        /// Returns the Broken as a string in AutoCAD notation with sixteenths of an inch percision
        /// </summary>
        public string Architectural
        {
            get { return _retrieveIntrinsicValueAsArchitecturalString(); }
        }

        public double GetValue(BrokenType Units)
        {
            switch (Units)
            {
                case BrokenType.Millimeter:
                    return Millimeters;
                case BrokenType.Centimeter:
                    return Centimeters;
                case BrokenType.Meter:
                    return Meters;
                case BrokenType.Kilometer:
                    return Kilometers;
                case BrokenType.ThirtySecond:
                    return ThirtySeconds;
                case BrokenType.Sixteenth:
                    return Sixteenths;
                case BrokenType.Inch:
                    return Inches;
                case BrokenType.Foot:
                    return Feet;
                case BrokenType.Yard:
                    return Yards;
                case BrokenType.Mile:
                    return Miles;
            }
            throw new Exception("Unknown BrokenType");
        }
    }
}
