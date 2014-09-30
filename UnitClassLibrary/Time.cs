using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class Time
    {
        #region _internalVariables
        private TimeType _internalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors
        public Time()
        {
            _intrinsicValue = 0.0;
        }

        public Time(TimeType passedTimeType, double passedValue)
        {
            _internalUnitType = passedTimeType;
            _intrinsicValue = passedValue;
        }
        #endregion

        #region Properties
        public double Second
        {
            get;
            set;
        }

        public double Minute
        {
            get;
            set;
        }

        public double Hour
        {
            get;
            set;
        }

        public DateTime DateTime
        {
            get;
            set;
        }

        private double GetValue(TimeType timeType)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Overloaded Operators
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1._internalUnitType, (t1._intrinsicValue + t2.GetValue(t1._internalUnitType)));
        }

        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1._internalUnitType, (t1._intrinsicValue - t2.GetValue(t1._internalUnitType)));
        }
        #endregion
    }
}
