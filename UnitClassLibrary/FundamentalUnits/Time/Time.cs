using System.Collections.Generic;

using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public class Time : Unit<TimeType> 
    {
         public Time(TimeType timeType, double value = 1.0)
            : base(timeType, value) { }

        public Time(Unit<TimeType> time) : base(time) { }

        new public Time Negate()
        {
            return (Time)(this.Negate());
        }

        

        #region Operator Overloads

        public static Time operator +(Time time1, Time time2)
        {
            return (Time)(time1.Add(time2));
        }

        public static Time operator -(Time time1, Time time2)
        {
            return (Time)(time1.Subtract(time2));
        }

        public static Time operator *(Time time, Measurement scalar)
        {
            return (Time)(time.Multiply(scalar));
        }

        public static Time operator *(Measurement scalar, Time time)
        {
            return time * scalar;
        }

        public static Time operator /(Time time, Measurement divisor)
        {
            return time / divisor;
        }
        #endregion
    }
}