using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class MomentOfIntertiaUnit
    {
        // m
        //Mass _mass;

        // r
        Distance _length;

        /// <summary>
        /// 
        /// </summary>
        public Distance LengthToFourthPower
        {
            get { return _length.RaiseToPower(4); }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="passedLengthToFourthPower"></param>
        public MomentOfIntertiaUnit(Distance passedLengthToFourthPower)
        {
            _length = new Distance(DistanceType.Millimeter, Math.Pow(passedLengthToFourthPower.Millimeters, 0.25));
        }
    }
}
