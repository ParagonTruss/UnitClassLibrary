using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary
{
    public class Time
    {
        #region _internalVariables
        private TimeType _internalUnitType;
        private double _intrinsicValue;
        private Time mintueTime;
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

        public Time(Time mintueTime)
        {
            // TODO: Complete member initialization
            this.mintueTime = mintueTime;
        }
        #endregion

        #region Properties

        public double Decades
        {
            get;
            set;
        }

        public double Years
        {
            get;
            set;
        }

        public double Weeks
        {
            get;
            set;
        }

        public double Months
        {
            get;
            set;
        }


        public double Days
        {
            get;
            set;
        }


        public double Hours
        {
            get;
            set;
        }

        public double Minutes
        {
            get;
            set;
        }

        public double Seconds
        {
            get;
            set;
        }

        public double Milliseconds
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

        public static bool operator >(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(Time t1, Time t2)
        {
            throw new NotImplementedException();
        }

        #endregion

        public object CompareTo(Time mediumTime)
        {
            throw new NotImplementedException();
        }

        public object EqualsWithinPassedAcceptedDeviation(Time biggerTime, int p)
        {
            throw new NotImplementedException();
        }
    }
}
