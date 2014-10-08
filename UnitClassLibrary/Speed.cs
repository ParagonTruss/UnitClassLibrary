using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class Speed : IComparable<Speed>
    {
        public Speed(SpeedType passedType, double passedValue)
        {
            throw new NotImplementedException();
        }

        public Speed()
        {
            // TODO: Complete member initialization
        }

        public double MilesPerHour { get; set; }

        public double FeetPerSecond { get; set; }

        public double MetersPerSecond { get; set; }

        public double KilometersPerHour { get; set; }

        public double Knots { get; set; }

        public int CompareTo(Speed other)
        {
            throw new NotImplementedException();
        }
    }
}
