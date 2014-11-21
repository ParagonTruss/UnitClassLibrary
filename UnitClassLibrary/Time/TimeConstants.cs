using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//suppress XML comment warnings in this file
#pragma warning disable 1591

namespace UnitClassLibrary
{
    public partial struct Time
    {
        public static Time Nanosecond
        {
            get { return new Time(TimeType.Nanosecond, 1); }
        }
        public static Time Microsecond
        {
            get { return new Time(TimeType.Microsecond, 1); }
        }
        public static Time Millisecond
        {
            get { return new Time(TimeType.Millisecond, 1); }
        }
        public static Time Second
        {
            get { return new Time(TimeType.Second, 1); }
        }
        public static Time Minute
        {
            get { return new Time(TimeType.Minute, 1); }
        }
        public static Time Hour
        {
            get { return new Time(TimeType.Hour, 1); }
        }
        public static Time Day
        {
            get { return new Time(TimeType.Day, 1); }
        }
        public static Time Week
        {
            get { return new Time(TimeType.Week, 1); }
        }
        public static Time Month
        {
            get { return new Time(TimeType.Month, 1); }
        }
        public static Time Year
        {
            get { return new Time(TimeType.Year, 1); }
        }
        public static Time Decade
        {
            get { return new Time(TimeType.Decade, 1); }
        }
        public static Time Century
        {
            get { return new Time(TimeType.Century, 1); }
        }
    }
}
