using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Dimension class for units of power
    /// </summary>
    public class Power
    {
        #region _internalVariables
        private PowerType InternalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors

        public Power(PowerType passedPowerType, double passedValue)
        {
            InternalUnitType = passedPowerType;
            _intrinsicValue = passedValue;
        }

        #endregion

        #region Helper Methods

        

        #endregion

        #region Getters

        /// <summary>
        /// returns power as watts
        /// </summary>
        public double Watt
        {
            get { return retrieveAsExternalUnit(PowerType.Watt); }
        }

        private double retrieveAsExternalUnit(PowerType powerType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns power as horsepower
        /// </summary>
        public double Horsepower
        {
            get { return retrieveAsExternalUnit(PowerType.Horsepower); }
        }

        /// <summary>
        /// Returns power as foot pounds / minute
        /// </summary>
        public double FootPoundsPerSecond
        {
            get { return retrieveAsExternalUnit(PowerType.FootPoundsPerSecond); } 
        }

        /// <summary>
        /// Returns power as metric horsepower
        /// </summary>
        public double MetricHorsepower
        {
            get { return retrieveAsExternalUnit(PowerType.MetricHorsepower); }
        }

        /// <summary>
        /// Returns power as ergs / second
        /// </summary>
        public double ErgsPerSecond
        {
            get { return retrieveAsExternalUnit(PowerType.ErgsPerSecond); }
        }

        #endregion
    }
}
