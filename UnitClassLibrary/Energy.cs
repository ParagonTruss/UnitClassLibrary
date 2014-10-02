using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class Energy
    {
        #region _internalVariables
        private EnergyType InternalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors
        public Energy()
        {
            _intrinsicValue = 0.0;
        }

        public Energy(EnergyType passedEnergyType, double passedValue)
        {
            InternalUnitType = passedEnergyType;
            _intrinsicValue = passedValue;
        }
        #endregion

        #region Properties
        public double Joule
        {
            get;
            set;
        }

        public double FootPound
        {
            get;
            set;
        }

        public double Erg
        {
            get;
            set;
        }

        public double KilogramMeter
        {
            get;
            set;
        }
        #endregion
    }
}
