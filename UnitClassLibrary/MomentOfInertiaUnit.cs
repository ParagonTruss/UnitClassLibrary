using System;
using System.Collections.Generic;
 
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
        Broken _length;

        /// <summary>
        /// 
        /// </summary>
        public Broken LengthToFourthPower
        {
            get { return _length.RaiseToPower(4); }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="passedLengthToFourthPower"></param>
        public MomentOfIntertiaUnit(Broken passedLengthToFourthPower)
        {
            _length = new Broken(BrokenType.Millimeter, Math.Pow(passedLengthToFourthPower.Millimeters, 0.25));
        }
    }
}
