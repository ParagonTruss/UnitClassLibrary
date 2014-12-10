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
        public static Mass Gram
        {
            get { return new Mass(MassType.Grams, 1); }
        }
        public static Mass Kilogram
        {
            get { return new Mass(MassType.Kilograms, 1); }
        }
        public static Mass MetricTon
        {
            get { return new Mass(MassType.MetricTons, 1); }
        }
        public static Mass Milligram
        {
            get { return new Mass(MassType.Milligrams, 1); }
        }
        public static Mass Microgram
        {
            get { return new Mass(MassType.Micrograms, 1); }
        }
        public static Mass LongTon
        {
            get { return new Mass(MassType.LongTons, 1); }
        }
        public static Mass ShortTon
        {
            get { return new Mass(MassType.ShortTons, 1); }
        }
        public static Mass Stone
        {
            get { return new Mass(MassType.Stones, 1); }
        }
        public static Mass Pound
        {
            get { return new Mass(MassType.Pounds, 1); }
        }
        public static Mass Ounce
        {
            get { return new Mass(MassType.Ounces, 1); }
        }
    }
}
