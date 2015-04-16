using System;
using System.Collections.Generic;

using System.Text;

namespace UnitClassLibrary
{
    public partial class Time
    {
        /// <summary>
        /// Converts from one TimeType to another
        /// </summary>
        /// <param name="typeConvertingFrom"></param>
        /// <param name="passedValue"></param>
        /// <param name="typeConvertingTo"></param>
        /// <returns></returns>
        public static double ConvertTime(TimeType typeConvertingFrom, double passedValue, TimeType typeConvertingTo)
        {
            double returnDouble = 0.0;

            switch (typeConvertingFrom)
            {
                case TimeType.Nanosecond:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 0.001;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 1e-6;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 1e-9;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 1.6667e-11;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 2.7778e-13;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 1.1574e-14;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 1.6534e-15;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 3.8027e-16;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 3.1689e-17;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 3.1689e-18;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 3.1689e-19;
                            break;
                    }
                    break;
                case TimeType.Microsecond:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 1000;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 0.001;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 1e-6;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 1.6667e-8;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 2.7778e-10;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 1.1574e-11;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 1.6534e-12;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 3.8027e-13;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 3.1689e-14;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 3.1689e-15;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 3.1689e-16;
                            break;
                    }
                    break;
                case TimeType.Millisecond:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 1e+6;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 1000;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 0.001;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 1.6667e-5;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 2.7778e-7;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 1.1574e-8;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 1.6534e-9;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 3.8027e-10;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 3.1689e-11;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 3.1689e-12;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 3.1689e-13;
                            break;
                    }
                    break;
                case TimeType.Second:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 1e+9;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 1e+6;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 1000;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 0.0166667;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 0.000277778;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 1.1574e-5;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 1.6534e-6;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 3.8027e-7;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 3.1689e-8;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 3.1689e-9;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 3.1689e-10;
                            break;
                    }
                    break;
                case TimeType.Minute:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 6e+10;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 6e+7;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 60000;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 60;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue / 60;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 0.000694444;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 9.9206e-5;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 2.2816e-5;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 1.9013e-6;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 1.9013e-7;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 1.9013e-8;
                            break;
                    }
                    break;
                case TimeType.Hour:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 3.6e+12;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 3.6e+9;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 3.6e+6;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 3600;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 60;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 0.0416667;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 0.00595238;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 0.00136895;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 0.00011408;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 1.1408e-5;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 1.1408e-6;
                            break;
                    }
                    break;
                case TimeType.Day:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 8.64e+13;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 8.64e+10;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 8.64e+7;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 86400;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 1440;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 24;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 0.142857;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 0.0328549;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 0.00273791;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 0.000273791;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 2.7379e-5;
                            break;
                    }
                    break;
                case TimeType.Week:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 6.048e+14;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 6.048e+11;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 6.048e+8;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 604800;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 10080;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 168;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 7;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 0.229984;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 0.0191654;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 0.00191654;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 0.000191654;
                            break;
                    }
                    break;
                case TimeType.Month:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 2.63e+15;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 2.63e+12;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 2.63e+9;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 2.63e+6;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 43829.1;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 730.484;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 30.4368;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 4.34812;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 0.0833333;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 0.00833333;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 0.000833333;
                            break;
                    }
                    break;
                case TimeType.Year:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 3.156e+16;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 3.156e+13;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 3.156e+10;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 3.156e+7;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 525949;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 8765.81;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 365.242;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 52.1775;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 12;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 0.1;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 0.01;
                            break;
                    }
                    break;
                case TimeType.Decade:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 3.156e+17;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 3.156e+14;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 3.156e+11;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 3.156e+8;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 5.259e+6;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 87658.1;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 3652.42;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 521.775;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 120;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 10;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue * 0.1;
                            break;
                    }
                    break;
                case TimeType.Century:
                    switch (typeConvertingTo)
                    {
                        case TimeType.Nanosecond:
                            returnDouble = passedValue * 3.156e+18;
                            break;
                        case TimeType.Microsecond:
                            returnDouble = passedValue * 3.156e+15;
                            break;
                        case TimeType.Millisecond:
                            returnDouble = passedValue * 3.156e+12;
                            break;
                        case TimeType.Second:
                            returnDouble = passedValue * 3.156e+9;
                            break;
                        case TimeType.Minute:
                            returnDouble = passedValue * 5.259e+7;
                            break;
                        case TimeType.Hour:
                            returnDouble = passedValue * 876581;
                            break;
                        case TimeType.Day:
                            returnDouble = passedValue * 36524.2;
                            break;
                        case TimeType.Week:
                            returnDouble = passedValue * 5217.75;
                            break;
                        case TimeType.Month:
                            returnDouble = passedValue * 1200;
                            break;
                        case TimeType.Year:
                            returnDouble = passedValue * 100;
                            break;
                        case TimeType.Decade:
                            returnDouble = passedValue * 10;
                            break;
                        case TimeType.Century:
                            returnDouble = passedValue;
                            break;
                    }
                    break;


            }

            return returnDouble;
        }
    }
}
