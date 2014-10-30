using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Dimension
    {
        public double Sixteenths
        {
            get { return _retrieveAsExternalUnit(DimensionType.Sixteenth); }
        }

        public double ThirtySeconds
        {
            get { return _retrieveAsExternalUnit(DimensionType.ThirtySecond); }
        }

        public double Inches
        {
            get { return _retrieveAsExternalUnit(DimensionType.Inch); }
        }

        public double Feet
        {
            get { return _retrieveAsExternalUnit(DimensionType.Foot); }
        }

        public double Yards
        {
            get { return _retrieveAsExternalUnit(DimensionType.Yard); }
        }

        public double Miles
        {
            get { return _retrieveAsExternalUnit(DimensionType.Mile); }
        }

        public double Millimeters
        {
            get { return _retrieveAsExternalUnit(DimensionType.Millimeter); }
        }

        public double Centimeters
        {
            get { return _retrieveAsExternalUnit(DimensionType.Centimeter); }
        }

        public double Meters
        {
            get { return _retrieveAsExternalUnit(DimensionType.Meter); }
        }

        public double Kilometers
        {
            get { return _retrieveAsExternalUnit(DimensionType.Kilometer); }
        }

        /// <summary>
        /// Returns the dimension as a string in AutoCAD notation with sixteenths of an inch percision
        /// </summary>
        public string Architectural
        {
            get { return _retrieveInternalUnitAsArchitecturalString(); }
        }

        public double GetValue(DimensionType Units)
        {
            switch (Units)
            {
                case DimensionType.Millimeter:
                    return Millimeters;
                case DimensionType.Centimeter:
                    return Centimeters;
                case DimensionType.Meter:
                    return Meters;
                case DimensionType.Kilometer:
                    return Kilometers;
                case DimensionType.ThirtySecond:
                    return ThirtySeconds;
                case DimensionType.Sixteenth:
                    return Sixteenths;
                case DimensionType.Inch:
                    return Inches;
                case DimensionType.Foot:
                    return Feet;
                case DimensionType.Yard:
                    return Yards;
                case DimensionType.Mile:
                    return Miles;
                case DimensionType.ArchitecturalString:
                    throw new Exception("Cannot return a double value from architectural string");
            }
            throw new Exception("Unknown DimensionType");
        }
    }
}
