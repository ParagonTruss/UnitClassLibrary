using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class Mass
    {
        private double _intrinsicValue = 0.0;

        public double Kilograms
        {
            get { return _intrinsicValue; }
            set { _intrinsicValue = value; }
        }

        public Mass(double passedKilograms)
        {
            _intrinsicValue = passedKilograms;
        }
    }
}
