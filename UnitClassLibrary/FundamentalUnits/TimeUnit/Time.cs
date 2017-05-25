/*
    This file is part of Unit Class Library.
    Copyright (C) 2016 Paragon Component Systems, LLC.

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System.Collections.Generic;

using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.TimeUnit
{
    public sealed class Time : Unit<TimeType> 
    {
        public Time(TimeType timeType, double value)
           : base(timeType, value) { }

        public Time(Unit<TimeType> time) : base(time) { }

        public new Time Negate()
        {
            return (Time)(this.Negate());
        }

        
        public static TimeType Hours { get; } = new Hour();
        public static TimeType Minutes { get; } = new Minute();
        public static TimeType Seconds { get; } = new Second();
        #region Operator Overloads

        public static Time operator +(Time time1, Time time2)
        {
            return (Time)(time1.Add(time2));
        }

        public static Time operator -(Time time1, Time time2)
        {
            return (Time)(time1.Subtract(time2));
        }

        public static Time operator *(Time time, double scalar)
        {
            return (Time)(time.Multiply(scalar));
        }

        public static Time operator *(double scalar, Time time)
        {
            return time * scalar;
        }

        public static Time operator /(Time time, double divisor)
        {
            return time / divisor;
        }
        #endregion
    }
}