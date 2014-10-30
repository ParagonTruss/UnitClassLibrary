using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Represents all units of Speed
    /// </summary>
    public class Speed : IComparable<Speed>
    {
        #region _internalVariables
        private Dimension _dimension;
        private Time _time;
        #endregion

        #region Constructors

        public Speed()
        {
            _dimension = new Dimension();
            _time = new Time();
        }

        public Speed(Dimension passedDimension, Time passedTime)
        {
            _dimension = passedDimension;
            _time = passedTime;
        }

        public Speed(SpeedType passedSpeedType, double passedValue)
        {
            switch(passedSpeedType)
            {
                case SpeedType.FeetPerSecond:
                    _dimension = new Dimension(DimensionType.Foot, passedValue);
                    _time = new Time(TimeType.Second, 1);
                    break;
                case SpeedType.KilometersPerHour:
                    _dimension = new Dimension(DimensionType.Kilometer, passedValue);
                    _time = new Time(TimeType.Hour, 1);
                    break;
                case SpeedType.Knots: //Nautical Miles/Hour
                    _dimension = new Dimension(DimensionType.Kilometer, 1.852 * passedValue); //Trying to accomplish the contruction in nautical miles.
                    _time = new Time(TimeType.Hour, 1);
                    break;
                case SpeedType.MetersPerSecond:
                    _dimension = new Dimension(DimensionType.Meter, passedValue);
                    _time = new Time(TimeType.Second, 1);
                    break;
                case SpeedType.MilesPerHour:
                    _dimension = new Dimension(DimensionType.Mile, passedValue);
                    _time = new Time(TimeType.Hour, 1);
                    break;
                default:
                    // Should never reach; cases should cover all members of enumerated set
                    throw new NotSupportedException("Unit not supported!");
            }
        }

        #endregion

        #region Getters
        /// <summary>
        /// returns speed as thirty-seconds / millisecond
        /// </summary>
        public double ThirtySecondsPerMillisecond
        {
            get { return _dimension.ThirtySeconds / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as thirty-seconds / second
        /// </summary>
        public double ThirtySecondsPerSecond
        {
            get { return _dimension.ThirtySeconds / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as thirty-seconds / minute
        /// </summary>
        public double ThirtySecondsPerMinute
        {
            get { return _dimension.ThirtySeconds / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as thirty-seconds / hour
        /// </summary>
        public double ThirtySecondsPerHour
        {
            get { return _dimension.ThirtySeconds / _time.Hours; }
        }

        /// <summary>
        /// returns speed as sixteenths / millisecond
        /// </summary>
        public double SixteenthsPerMillisecond
        {
            get { return _dimension.Sixteenths / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as sixteenths / second
        /// </summary>
        public double SixteenthsPerSecond
        {
            get { return _dimension.Sixteenths / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as sixteenths / minute
        /// </summary>
        public double SixteenthsPerMinute
        {
            get { return _dimension.Sixteenths / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as sixteenths / hour
        /// </summary>
        public double SixteenthsPerHour
        {
            get { return _dimension.Sixteenths / _time.Hours; }
        }

        /// <summary>
        /// returns speed as inches / millisecond
        /// </summary>
        public double InchesPerMillisecond
        {
            get { return _dimension.Inches / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as inches / second
        /// </summary>
        public double InchesPerSecond
        {
            get { return _dimension.Inches / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as inches / minute
        /// </summary>
        public double InchesPerMinute
        {
            get { return _dimension.Inches / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as inches / hour
        /// </summary>
        public double InchesPerHour
        {
            get { return _dimension.Inches / _time.Hours; }
        }

        /// <summary>
        /// returns speed as feet / millisecond
        /// </summary>
        public double FeetPerMillisecond
        {
            get { return _dimension.Feet / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as feet / second
        /// </summary>
        public double FeetPerSecond
        {
            get { return _dimension.Feet / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as feet / minute
        /// </summary>
        public double FeetPerMinute
        {
            get { return _dimension.Feet / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as feet / hour
        /// </summary>
        public double FeetPerHour
        {
            get { return _dimension.Feet / _time.Hours; }
        }

        /// <summary>
        /// returns speed as yards / millisecond
        /// </summary>
        public double YardsPerMillisecond
        {
            get { return _dimension.Yards / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as yards / second
        /// </summary>
        public double YardsPerSecond
        {
            get { return _dimension.Yards / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as yards / minute
        /// </summary>
        public double YardsPerMinute
        {
            get { return _dimension.Yards / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as yards / hour
        /// </summary>
        public double YardsPerHour
        {
            get { return _dimension.Yards / _time.Hours; }
        }

        /// <summary>
        /// returns speed as miles / minute
        /// </summary>
        public double MilesPerMinute
        {
            get { return _dimension.Miles / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as miles / hour
        /// </summary>
        public double MilesPerHour 
        {
            get { return _dimension.Miles / _time.Hours; } 
        }

        /// <summary>
        /// returns speed as millimters / millisecond
        /// </summary>
        public double MillimetersPerMillisecond
        {
            get { return _dimension.Millimeters / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as millimters / second
        /// </summary>
        public double MillimetersPerSecond
        {
            get { return _dimension.Millimeters / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as millimters / minute
        /// </summary>
        public double MillimetersPerMinute
        {
            get { return _dimension.Millimeters / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as millimters / hour
        /// </summary>
        public double MillimetersPerHour
        {
            get { return _dimension.Millimeters / _time.Hours; }
        }

        /// <summary>
        /// returns speed as centimeters / millisecond
        /// </summary>
        public double CentimetersPerMillisecond
        {
            get { return _dimension.Centimeters / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as centimeters / second
        /// </summary>
        public double CentimetersPerSecond
        {
            get { return _dimension.Centimeters / _time.Seconds; }
        }

        /// <summary>
        /// returns speed as centimeters / minute
        /// </summary>
        public double CentimetersPerMinute
        {
            get { return _dimension.Centimeters / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as centimeters / hour
        /// </summary>
        public double CentimetersPerHour
        {
            get { return _dimension.Centimeters / _time.Hours; }
        }

        /// <summary>
        /// returns speed as meters / millisecond
        /// </summary>
        public double MetersPerMillisecond
        {
            get { return _dimension.Meters / _time.Milliseconds; }
        }

        /// <summary>
        /// returns speed as meters / second
        /// </summary>
        public double MetersPerSecond 
        {
            get { return _dimension.Meters / _time.Seconds;} 
        }

        /// <summary>
        /// returns speed as meters / minute
        /// </summary>
        public double MetersPerMinute
        {
            get { return _dimension.Meters / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as meters / hour
        /// </summary>
        public double MetersPerHour
        {
            get { return _dimension.Meters / _time.Hours; }
        }

        /// <summary>
        /// returns speed as kilometers / minute
        /// </summary>
        public double KilometersPerMinute
        {
            get { return _dimension.Kilometers / _time.Minutes; }
        }

        /// <summary>
        /// returns speed as kilometers / hour
        /// </summary>
        public double KilometersPerHour 
        {
            get {return _dimension.Kilometers / _time.Hours;} 
        }

        /// <summary>
        /// returns speed as knots
        /// </summary>
        public double Knots 
        {
            get {return (_dimension.Kilometers * 1.852) / _time.Hours ;} //Nautical Mile = 1.852 Kilometers
        }

        public double GetValue(SpeedType Units)
        {
            switch (Units)
            {
                case SpeedType.ThirtySecondsPerMillisecond:
                    return ThirtySecondsPerMillisecond;
                case SpeedType.ThirtySecondsPerSecond:
                    return ThirtySecondsPerSecond;
                case SpeedType.ThirtySecondsPerMinute:
                    return ThirtySecondsPerMinute;
                case SpeedType.ThirtySecondsPerHour:
                    return ThirtySecondsPerHour;
                case SpeedType.SixteenthsPerMillisecond:
                    return SixteenthsPerMillisecond;
                case SpeedType.SixteenthsPerSecond:
                    return SixteenthsPerSecond;
                case SpeedType.SixteenthsPerMinute:
                    return SixteenthsPerMinute;
                case SpeedType.SixteenthsPerHour:
                    return SixteenthsPerHour;
                case SpeedType.InchesPerMillisecond:
                    return InchesPerMillisecond;
                case SpeedType.InchesPerSecond:
                    return InchesPerSecond;
                case SpeedType.InchesPerMinute:
                    return InchesPerMinute;
                case SpeedType.InchesPerHour:
                    return InchesPerHour;
                case SpeedType.FeetPerMillisecond:
                    return FeetPerMillisecond;
                case SpeedType.FeetPerSecond:
                    return FeetPerSecond;
                case SpeedType.FeetPerMinute:
                    return FeetPerMinute;
                case SpeedType.FeetPerHour:
                    return FeetPerHour;
                case SpeedType.YardsPerMillisecond:
                    return YardsPerMillisecond;
                case SpeedType.YardsPerSecond:
                    return YardsPerSecond;
                case SpeedType.YardsPerMinute:
                    return YardsPerMinute;
                case SpeedType.YardsPerHour:
                    return YardsPerHour;
                case SpeedType.MilesPerMinute:
                    return MilesPerMinute;
                case SpeedType.MilesPerHour:
                    return MilesPerHour;
                case SpeedType.MillimetersPerMillisecond:
                    return MillimetersPerMillisecond;
                case SpeedType.MillimetersPerSecond:
                    return MillimetersPerSecond;
                case SpeedType.MillimetersPerMinute:
                    return MillimetersPerMinute;
                case SpeedType.MillimetersPerHour:
                    return MillimetersPerHour;
                case SpeedType.CentimetersPerMillisecond:
                    return CentimetersPerMillisecond;
                case SpeedType.CentimetersPerSecond:
                    return CentimetersPerSecond;
                case SpeedType.CentimetersPerMinute:
                    return CentimetersPerMinute;
                case SpeedType.CentimetersPerHour:
                    return CentimetersPerHour;
                case SpeedType.MetersPerMillisecond:
                    return MetersPerMillisecond;
                case SpeedType.MetersPerSecond:
                    return MetersPerSecond;
                case SpeedType.MetersPerMinute:
                    return MetersPerMinute;
                case SpeedType.MetersPerHour:
                    return MetersPerHour;
                case SpeedType.KilometersPerMinute:
                    return KilometersPerMinute;
                case SpeedType.KilometersPerHour:
                    return KilometersPerHour;
                case SpeedType.Knots:
                    return Knots;
            }

            throw new Exception("Unknown SpeedType");
        }

        #endregion

        #region Overloaded Operators
        /// <summary>
        /// adds two speeds
        /// </summary>
        /// <param name="s1">speed one</param>
        /// <param name="s2">speed two</param>
        /// <returns>the sum of the two speeds</returns>
        public static Speed operator +(Speed s1, Speed s2)
        {
            return new Speed(s1._dimension + s2._dimension, s1._time + s2._time);
        }

        /// <summary>
        /// subtracts two speeds
        /// </summary>
        /// <param name="s1">speed one</param>
        /// <param name="s2">speed two</param>
        /// <returns>the difference of the two speeds</returns>
        public static Speed operator -(Speed s1, Speed s2)
        {
            return new Speed(s1._dimension - s2._dimension, s1._time - s2._time);
        }

        public static double operator /(Speed s1, Speed s2)
        {
            throw new NotImplementedException();
            //return (s1._dimension / s2._dimension) / (s1._time / s2._time); //Division needs to be implemented in Time Class
        }


        public static Speed operator *(Speed s1, double multiplier)
        {
            throw new NotImplementedException();
            //return  new Speed(s1._dimension * multiplier, s1._time * multiplier); //Multiplication needs to be implemented in Time Class
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Speed s1, Speed s2)
        {
            return s1.Equals(s2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Speed s1, Speed s2)
        {
            return !s1.Equals(s2);
        }

        /// <summary>
        /// Compare s1 and s2 in units of s1
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator >(Speed s1, Speed s2)
        {
            return s1._dimension.GetValue(s1._dimension.InternalUnitType) / s1._time.GetValue(s1._time.InternalUnitType) >
                s2._dimension.GetValue(s1._dimension.InternalUnitType) / s2._time.GetValue(s1._time.InternalUnitType);
        }

        /// <summary>
        /// Compare s1 and s2 in units of s1
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator <(Speed s1, Speed s2)
        {
            return s1._dimension.GetValue(s1._dimension.InternalUnitType) / s1._time.GetValue(s1._time.InternalUnitType) <
                s2._dimension.GetValue(s1._dimension.InternalUnitType) / s2._time.GetValue(s1._time.InternalUnitType);
        }

        public static bool operator <=(Speed s1, Speed s2)
        {
            return s1.Equals(s2) || s1 < s2;
        }

        public static bool operator >=(Speed s1, Speed s2)
        {
            return s1.Equals(s2) || s1 > s2;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within the accepted equality deviation specified in DeviationConstants
        /// </summary>
        public override bool Equals(object obj)
        {
            return Math.Abs(this._dimension.GetValue(this._dimension.InternalUnitType) / this._time.GetValue(this._time.InternalUnitType) - ((Speed)(obj))._dimension.GetValue(this._dimension.InternalUnitType) / ((Speed)(obj))._time.GetValue(this._time.InternalUnitType)) < // This speed and the passed speed (in units of this speed)...
                DeviationConstants.AcceptedEqualityDeviationSpeed._dimension.GetValue(this._dimension.InternalUnitType) / DeviationConstants.AcceptedEqualityDeviationSpeed._time.GetValue(this._time.InternalUnitType); // Is less than the accepted deviation speed constant in units of this speed
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinPassedAcceptedDeviation(object obj, Speed passedAcceptedEqualityDeviationSpeed)
        {
            return Math.Abs(this._dimension.GetValue(this._dimension.InternalUnitType) / this._time.GetValue(this._time.InternalUnitType) - ((Speed)(obj))._dimension.GetValue(this._dimension.InternalUnitType) / ((Speed)(obj))._time.GetValue(this._time.InternalUnitType)) < // This speed and the passed speed (in units of this speed)...
                passedAcceptedEqualityDeviationSpeed._dimension.GetValue(this._dimension.InternalUnitType) / passedAcceptedEqualityDeviationSpeed._time.GetValue(this._time.InternalUnitType); // Is less than the passed accepted deviation speed constant in units of this speed
        }

        #endregion

        public int CompareTo(Speed other)
        {
            if(this.Equals(other))
            {
                return 0;
            }
            else if (this > other)
            {
                return 1;
            }

            return -1;

            /*
            throw new NotImplementedException();
             * */
        }
    }
}
