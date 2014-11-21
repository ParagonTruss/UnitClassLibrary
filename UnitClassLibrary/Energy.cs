using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    public class Energy
    {
        #region _internalVariables
        internal EnergyType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private EnergyType _internalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors
        public Energy()
        {
            _intrinsicValue = 0.0;
        }

        public Energy(EnergyType passedEnergyType, double passedValue)
        {
            _internalUnitType = passedEnergyType;
            _intrinsicValue = passedValue;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public double Joule
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double FootPound
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double Erg
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double KilogramMeter
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="energyType"></param>
        /// <returns></returns>
        public double GetValue(EnergyType energyType)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static Energy operator +(Energy e1, Energy e2)
        {
            //add the two energies together
            //return a new Distance with the new value
            return new Energy(e1.InternalUnitType, (e1._intrinsicValue + e2.GetValue(e1.InternalUnitType)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static Energy operator -(Energy e1, Energy e2)
        {
            //add the two energies together
            //return a new Distance with the new value
            return new Energy(e1.InternalUnitType, (e1._intrinsicValue - e2.GetValue(e1.InternalUnitType)));
        }
    }
}
