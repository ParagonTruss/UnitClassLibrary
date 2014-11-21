using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    /// <summary>
    /// A flow of electric charge
    /// </summary>
    public class ElectricCurrent : IComparable<ElectricCurrent>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="passedType"></param>
        /// <param name="passedValue"></param>
        public ElectricCurrent(ElectricCurrentType passedType, double passedValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public ElectricCurrent()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(ElectricCurrent other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public double Amperes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double MilliAmperes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double VoltOhms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double WattVolts { get; set; }
    }
}
