using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public enum TimeType { Nanosecond, Microsecond, Millisecond, Second, Minute, Hour, Day, Week, Month, Year, Decade, Century };
    public partial struct Time
    {
        #region private _fields and Internal Properties
        
        /// <summary>
        /// This property must be internal to allow for our Just-In-Time conversions to work with the GetValue() method
        /// </summary>
        internal TimeType InternalUnitType
        {
            get { return _internalUnitType; }
        }
        private TimeType _internalUnitType;

        private double _intrinsicValue;
        
        #endregion

        #region Constructors

        /// <summary>
        /// copy constructor - create a new Time with the same _intrinsicValue as the passed Time
        /// </summary>
        public Time(Time passedTime)
        {
            _intrinsicValue = passedTime._intrinsicValue;
            _internalUnitType = passedTime._internalUnitType;
        }

        /// <summary>
        /// sets the Time to the passed double with the passed unit type
        /// </summary>
        /// <param name="timeType">passed unit type</param>
        /// <param name="passedValue">period of unit type</param>		
        public Time(TimeType timeType, double passedValue)
        {
            _internalUnitType = timeType;
            _intrinsicValue = passedValue;
        }

        /// <summary>
        /// sets the Time to the TimeSpan in Second TimeType
        /// </summary>		
        public Time(TimeSpan passedTimeSpan)
        {
            _internalUnitType = TimeType.Second;
            _intrinsicValue = passedTimeSpan.Seconds;
        }

        #endregion

        #region helper methods

        private double _retrieveAsExternalUnit(TimeType toTimeType)
        {
            return ConvertTime(_internalUnitType, _intrinsicValue, toTimeType);
        }

        #endregion
    }
}
