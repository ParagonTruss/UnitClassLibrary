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
        Distance _length;

        public Distance LengthToFourthPower
        {
            get { return _length.RaiseToPower(4); }
            
        }

        public MomentOfIntertiaUnit(Distance passedLengthToFourthPower)
        {
            _length = new Distance(DistanceType.Millimeter, Math.Pow(passedLengthToFourthPower.Millimeters, 0.25));
        }
    }
}
