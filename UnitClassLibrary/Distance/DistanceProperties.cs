using System;
using Newtonsoft.Json;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Distance
    {
        public double ThirtySecondsOfAnInch
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch) * 32; }
        }

        public double SixteenthsOfAnInch
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch) * 16; }
        }

        public double EighthsOfAnInch
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch) * 8; }
        }

        public double QuartersOfAnInch
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch) * 4; }
        }

        public double HalvesOfAnInch
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DistanceType.Inch) * 2; }
        }

        [JsonProperty]
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
                case DistanceType.Inch:
                    return Inches;
                case DistanceType.Foot:
                    return Feet;
                case DistanceType.Yard:
                    return Yards;
                case DistanceType.Mile:
                    return Miles;
            }
            throw new Exception("Unknown DistanceType");
        }
    }
}
