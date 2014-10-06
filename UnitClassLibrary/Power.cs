using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Dimension class for units of power
    /// </summary>
    public class Power
    {
        #region _internalVariables
        private Energy _energy;
        private Time _time;
        #endregion

        #region Constructors

        public Power()
        {
            _energy = new Energy();
            _time = new Time();
        }

        public Power(Energy passedEnergy, Time passedTime)
        {
            _energy = passedEnergy;
            _time = passedTime;
        }

        public Power(PowerType passedPowerType, double passedValue)
        {
            switch (passedPowerType)
            {
                case PowerType.Watt:
                    _energy = new Energy(EnergyType.Joule, passedValue);
                    _time = new Time(TimeType.Second, 1);
                    break;
                case PowerType.Horsepower:
                    _energy = new Energy(EnergyType.FootPound, passedValue/33000);
                    _time = new Time(TimeType.Minute, 1);
                    break;
                case PowerType.MetricHorsepower:
                    _energy = new Energy(EnergyType.KilogramMeter, passedValue/75);
                    _time = new Time(TimeType.Second, 1);
                    break;
                case PowerType.FootPoundsPerSecond:
                    _energy = new Energy(EnergyType.FootPound, passedValue);
                    _time = new Time(TimeType.Second, 1);
                    break;
                case PowerType.ErgsPerSecond:
                    _energy = new Energy(EnergyType.Erg, passedValue);
                    _time = new Time(TimeType.Second, 1);
                    break;
                default:
                    // Should never reach; cases should cover all members of enumerated set
                    throw new NotSupportedException("Unit not supported!");
            }
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
            get { return _energy.Joule / _time.Seconds; }
        }

        /// <summary>
        /// Returns power as horsepower
        /// </summary>
        public double Horsepower
        {
            get { return 33000 * _energy.FootPound / _time.Minutes; }
        }

        /// <summary>
        /// Returns power as foot pounds / minute
        /// </summary>
        public double FootPoundsPerSecond
        {
            get { return _energy.FootPound / _time.Seconds; } 
        }

        /// <summary>
        /// Returns power as metric horsepower
        /// </summary>
        public double MetricHorsepower
        {
            get { return 75 * _energy.KilogramMeter / _time.Seconds; }
        }

        /// <summary>
        /// Returns power as ergs / second
        /// </summary>
        public double ErgsPerSecond
        {
            get { return _energy.Erg / _time.Seconds; }
        }

        public double GetValue(PowerType Units)
        {
            switch (Units)
            {
                case PowerType.Watt:
                    return Watt;
                case PowerType.Horsepower:
                    return Horsepower;
                case PowerType.FootPoundsPerSecond:
                    return FootPoundsPerSecond;
                case PowerType.MetricHorsepower:
                    return MetricHorsepower;
                case PowerType.ErgsPerSecond:
                    return ErgsPerSecond;
            }
            throw new Exception("Unknown PowerType");
        }

        #endregion

        #region Overloaded Operators
        /// <summary>
        /// adds two powers
        /// </summary>
        /// <param name="p1">power one</param>
        /// <param name="p2">power two</param>
        /// <returns>the sum of the two forces</returns>
        public static Power operator +(Power p1, Power p2)
        {
            return new Power( p1._energy + p2._energy, p1._time + p2._time);
        }

        /// <summary>
        /// subtracts two powers
        /// </summary>
        /// <param name="p1">power one</param>
        /// <param name="p2">power two</param>
        /// <returns>the sum of the two forces</returns>
        public static Power operator -(Power p1, Power p2)
        {
            return new Power(p1._energy - p2._energy, p1._time - p2._time);
        }
        #endregion
    }
}
