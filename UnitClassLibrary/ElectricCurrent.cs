using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public class ElectricCurrent : IComparable<ElectricCurrent>
    {
        public ElectricCurrent(ElectricCurrentType passedType, double passedValue)
        {
            throw new NotImplementedException();
        }

        public ElectricCurrent()
        {
            // TODO: Complete member initialization
        }

        public int CompareTo(ElectricCurrent other)
        {
            throw new NotImplementedException();
        }

        public double Amperes { get; set; }

        public double MilliAmperes { get; set; }

        public double VoltOhms { get; set; }

        public double WattVolts { get; set; }
    }
}
