﻿using System;
using System.Collections.Generic;
 
using System.Text;

#pragma warning disable 1591

namespace UnitClassLibrary
{
    /// <summary>
    /// Distance class for units of power
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
                    _energy = new Energy(EnergyType.Footpound, passedValue / 33000);
                    _time = new Time(TimeType.Minute, 1);
                    break;
                case PowerType.FootPoundsPerSecond:
                    _energy = new Energy(EnergyType.Footpound, passedValue);
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
            get { return _energy.Joules / _time.Seconds; }
        }

        /// <summary>
        /// Returns power as horsepower
        /// </summary>
        public double Horsepower
        {
            get { return 33000 * _energy.Footpounds / _time.Minutes; }
        }

        /// <summary>
        /// Returns power as foot pounds / minute
        /// </summary>
        public double FootPoundsPerSecond
        {
            get { return _energy.Footpounds / _time.Seconds; }
        }

        /// <summary>
        /// Returns power as ergs / second
        /// </summary>
        public double ErgsPerSecond
        {
            get { return _energy.Ergs / _time.Seconds; }
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
                case PowerType.ErgsPerSecond:
                    return ErgsPerSecond;
            }
            throw new Exception("Unknown PowerType");
        }

        #endregion

        #region Overloaded Operators
        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return  (_energy.Footpounds / _time.Seconds).GetHashCode();
        }

        /// <summary>
        /// adds two powers
        /// </summary>
        /// <param name="p1">power one</param>
        /// <param name="p2">power two</param>
        /// <returns>the sum of the two forces</returns>
        public static Power operator +(Power p1, Power p2)
        {
            return new Power(p1._energy + p2._energy, p1._time + p2._time);
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

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Power p1, Power p2)
        {
            if ((object)p1 == null)
            {
                if ((object)p2 == null)
                {
                    return true;
                }
                return false;
            }
            return p1.Equals(p2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Power p1, Power p2)
        {
            if ((object)p1 == null)
            {
                if ((object)p2 == null)
                {
                    return false;
                }
                return true;
            }
            return !p1.Equals(p2);
        }

        /// <summary>
        /// Compare p1 and p2 in units of p1
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator >(Power p1, Power p2)
        {
            return p1._energy.GetValue(p1._energy.InternalUnitType) / p1._time.GetValue(p1._time.InternalUnitType) >
                p2._energy.GetValue(p1._energy.InternalUnitType) / p2._time.GetValue(p1._time.InternalUnitType);
        }

        /// <summary>
        /// Compare p1 and p2 in units of p1
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator <(Power p1, Power p2)
        {
            return p1._energy.GetValue(p1._energy.InternalUnitType) / p1._time.GetValue(p1._time.InternalUnitType) <
                p2._energy.GetValue(p1._energy.InternalUnitType) / p2._time.GetValue(p1._time.InternalUnitType);
        }

        public static bool operator <=(Power p1, Power p2)
        {
            return p1.Equals(p2) || p1 < p2;
        }

        public static bool operator >=(Power p1, Power p2)
        {
            return p1.Equals(p2) || p1 > p2;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in Constants
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                Power other = (Power)obj;
                 return Math.Abs(this._energy.GetValue(this._energy.InternalUnitType) / this._time.GetValue(this._time.InternalUnitType) - ((Power)(obj))._energy.GetValue(this._energy.InternalUnitType) / ((Power)(obj))._time.GetValue(this._time.InternalUnitType)) <= // This power and the passed power (in units of this power)...
                    DeviationDefaults.AcceptedEqualityDeviationPower._energy.GetValue(this._energy.InternalUnitType) / DeviationDefaults.AcceptedEqualityDeviationPower._time.GetValue(this._time.InternalUnitType); // Is less than the accepted deviation power constant in units of this power
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Power passedAcceptedEqualityDeviationDistance)
        {
            return Math.Abs(this._energy.GetValue(this._energy.InternalUnitType) / this._time.GetValue(this._time.InternalUnitType) - ((Power)(obj))._energy.GetValue(this._energy.InternalUnitType) / ((Power)(obj))._time.GetValue(this._time.InternalUnitType)) <= // This power and the passed power (in units of this power)...
                passedAcceptedEqualityDeviationDistance._energy.GetValue(this._energy.InternalUnitType) / passedAcceptedEqualityDeviationDistance._time.GetValue(this._time.InternalUnitType); // Is less than the passed accepted deviation power constant in units of this power
        }
        #endregion
    }
}
