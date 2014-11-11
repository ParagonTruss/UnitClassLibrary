using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial struct Time
    {
        public double Nanoseconds
        {
            get { return _retrieveAsExternalUnit(TimeType.Nanosecond); }
        }

        public double Microseconds
        {
            get { return _retrieveAsExternalUnit(TimeType.Microsecond); }
        }

        public double Milliseconds
        {
            get { return _retrieveAsExternalUnit(TimeType.Millisecond); }
        }

        public double Seconds
        {
            get { return _retrieveAsExternalUnit(TimeType.Second); }
        }

        public double Minutes
        {
            get { return _retrieveAsExternalUnit(TimeType.Minute); }
        }

        public double Hours
        {
            get { return _retrieveAsExternalUnit(TimeType.Hour); }
        }

        public double Days
        {
            get { return _retrieveAsExternalUnit(TimeType.Day); }
        }

        public double Weeks
        {
            get { return _retrieveAsExternalUnit(TimeType.Week); }
        }

        public double Months
        {
            get { return _retrieveAsExternalUnit(TimeType.Month); }
        }

        public double Years
        {
            get { return _retrieveAsExternalUnit(TimeType.Year); }
        }

        public double Decades
        {
            get { return _retrieveAsExternalUnit(TimeType.Decade); }
        }

        public double Centuries
        {
            get { return _retrieveAsExternalUnit(TimeType.Century); }
        }

        public TimeSpan TimeSpan
        {
            get { return new TimeSpan((int)_retrieveAsExternalUnit(TimeType.Second)); }
        }

        public double GetValue(TimeType Units)
        {
            switch(Units)
            {
                case TimeType.Nanosecond:
                    return Nanoseconds;
                case TimeType.Microsecond:
                    return Microseconds;
                case TimeType.Millisecond:
                    return Milliseconds;
                case TimeType.Second:
                    return Seconds;
                case TimeType.Minute:
                    return Minutes;
                case TimeType.Hour:
                    return Hours;
                case TimeType.Day:
                    return Days;
                case TimeType.Week:
                    return Weeks;
                case TimeType.Month:
                    return Months;
                case TimeType.Year:
                    return Years;
                case TimeType.Decade:
                    return Decades;
                case TimeType.Century:
                    return Centuries;
            }
            throw new Exception("Unknown TimeType");
        }
    }
}
