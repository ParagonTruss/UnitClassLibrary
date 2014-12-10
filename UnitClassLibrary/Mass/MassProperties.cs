using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial class Mass
    {
        //public enum MassType { MetricTons, Kilograms, Grams, Milligrams, Micrograms, LongTons, ShortTons, Stones, Pounds, Ounces };
        public double MetricTons
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.MetricTons); }
        }

        public double Kilograms
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Kilograms); }
        }

        public double Grams
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Grams); }
        }

        public double Milligrams
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Milligrams); }
        }

        public double Micrograms
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Micrograms); }
        }

        public double LongTons
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.LongTons); }
        }

        public double ShortTons
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.ShortTons); }
        }

        public double Stones
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Stones); }
        }

        public double Pounds
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Pounds); }
        }

        public double Ounces
        {
            get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Ounces); }
        }

        /// <summary>
        /// Returns the Mass as a string in AutoCAD notation with sixteenths of an inch percision
        /// </summary>
        //public string Architectural
        //{
        //    get { return _retrieveIntrinsicValueAsArchitecturalString(); }
        //}

        public double GetValue(MassType Units)
        {
            switch (Units)
            {
                case MassType.MetricTons:
                    return MetricTons;
                case MassType.Kilograms:
                    return Kilograms;
                case MassType.Grams:
                    return Grams;
                case MassType.Milligrams:
                    return Milligrams;
                case MassType.Micrograms:
                    return Micrograms;
                case MassType.LongTons:
                    return LongTons;
                case MassType.ShortTons:
                    return ShortTons;
                case MassType.Stones:
                    return Stones;
                case MassType.Pounds:
                    return Pounds;
                case MassType.Ounces:
                    return Ounces;
            }
            throw new Exception("Unknown MassType");
        }
    }
}
