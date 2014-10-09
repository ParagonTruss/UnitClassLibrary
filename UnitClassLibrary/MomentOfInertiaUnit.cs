using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class MomentOfIntertiaUnit
    {
        // m
        Mass _mass;

        // r
        Dimension _length;

        public Dimension LengthToFourthPower
        {
            get { return _length.raiseToPower(4); }
            
        }

        public MomentOfIntertiaUnit(Dimension passedLengthToFourthPower)
        {
            _length = new Dimension(DimensionType.Millimeter, Math.Pow(passedLengthToFourthPower.Millimeters, 0.25));
        }
    }
}
