using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public partial class Mass
    {
        /// <summary>
        /// Converts any Unit of mass into another
        /// </summary>
        /// <param name="typeConvertingTo">input unit type</param>
        /// <param name="typeConvertingFrom">desired output unit type</param>
        /// <returns>passedValue in desired units</returns>
        /// { Gram, MetricTon, Milligram, Microgram, LongTon, ShortTon, Stone, Pound, Ounce }
        public static double ConvertDistance(MassType typeConvertingFrom, double passedValue, MassType typeConvertingTo)
        {
            double returnDouble = 0.0;

            switch (typeConvertingFrom)
            {
                case MassType.Grams:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            returnDouble = passedValue; // Covnert grams to grams
                            break;
                        case MassType.Kilograms:
                            returnDouble = passedValue / 1000;
                            break;
                        case MassType.MetricTons:
                            returnDouble = passedValue / Math.Pow(10, -6); // Convert grams to metric tons
                            break;
                        case MassType.Milligrams:
                            returnDouble = passedValue * 1000; // Convert grams to milligrams
                            break;
                        case MassType.Micrograms:
                            returnDouble = passedValue * 1000000; // Convert grams to micrograms
                            break;
                        case MassType.LongTons:
                            returnDouble = passedValue * 0.000000984206528; // Convert grams to long tons
                            break;
                        case MassType.ShortTons:
                            returnDouble = passedValue * (1.10231 * Math.Pow(10, -6)); // Convert grams to short tons
                            break;
                        case MassType.Stones:
                            returnDouble = passedValue * 0.000157473; // Convert grams to stones
                            break;
                        case MassType.Pounds:
                            returnDouble = passedValue * 0.00220462; // Convert grams to pounds
                            break;
                        case MassType.Ounces:
                            returnDouble = passedValue * 0.035274; // Convert grams to ounces
                            break;
                    }
                    break;
                case MassType.Kilograms:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            returnDouble = passedValue * 1000;
                            break;
                        case MassType.Kilograms:
                            returnDouble = passedValue;
                            break;
                        case MassType.MetricTons:
                            returnDouble = passedValue / 1000;
                            break;
                        case MassType.Milligrams:
                            returnDouble = passedValue / 1000000;
                            break;
                        case MassType.Micrograms:
                            returnDouble = passedValue / 1000000000;
                            break;
                        case MassType.LongTons:
                            returnDouble = passedValue * 0.000984206528;
                            break;
                        case MassType.ShortTons:
                            returnDouble = passedValue * 0.00110231;
                            break;
                        case MassType.Stones:
                            returnDouble = passedValue * 0.157473;
                            break;
                        case MassType.Pounds:
                            returnDouble = passedValue * 2.20462;
                            break;
                        case MassType.Ounces:
                            returnDouble = passedValue * 35.274;
                            break;
                    }
                    break;
                case MassType.MetricTons:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            returnDouble = passedValue * 1000000;
                            break;
                        case MassType.Kilograms:
                            returnDouble = passedValue * 1000;
                            break;
                        case MassType.MetricTons:
                            returnDouble = passedValue;
                            break;
                        case MassType.Milligrams:
                            returnDouble = passedValue * 1000000000;
                            break;
                        case MassType.Micrograms:
                            returnDouble = passedValue * 1000000000000;
                            break;
                        case MassType.LongTons:
                            returnDouble = passedValue * 0.984206528;
                            break;
                        case MassType.ShortTons:
                            returnDouble = passedValue * 1.10231131;
                            break;
                        case MassType.Stones:
                            returnDouble = passedValue * 157.473044;
                            break;
                        case MassType.Pounds:
                            returnDouble = passedValue * 2204.62262;
                            break;
                        case MassType.Ounces:
                            returnDouble = passedValue * 35273.9619;
                            break;
                    }
                    break;
                case MassType.Milligrams:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            returnDouble = passedValue / 1000;
                            break;
                        case MassType.Kilograms:
                            returnDouble = passedValue / 1000000;
                            break;
                        case MassType.MetricTons:
                            returnDouble = passedValue / 1000000000;
                            break;
                        case MassType.Milligrams:
                            returnDouble = passedValue;
                            break;
                        case MassType.Micrograms:
                            returnDouble = passedValue * 1000;
                            break;
                        case MassType.LongTons:
                            returnDouble = passedValue * (9.84206528 * Math.Pow(10, -10));
                            break;
                        case MassType.ShortTons:
                            returnDouble = passedValue * (1.10231 * Math.Pow(10, -9));
                            break;
                        case MassType.Stones:
                            returnDouble = passedValue * (1.57473 * Math.Pow(10, -7));
                            break;
                        case MassType.Pounds:
                            returnDouble = passedValue * (2.20462 * Math.Pow(10, -6));
                            break;
                        case MassType.Ounces:
                            returnDouble = passedValue * (3.5274 * Math.Pow(10, -5));
                            break;
                    }
                    break;
                case MassType.Micrograms:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            returnDouble = passedValue * Math.Pow(10, -6);
                            break;
                        case MassType.Kilograms:
                            returnDouble = passedValue * Math.Pow(10, -9);
                            break;
                        case MassType.MetricTons:
                            returnDouble = passedValue * Math.Pow(10, -12);
                            break;
                        case MassType.Milligrams:
                            returnDouble = passedValue / 1000;
                            break;
                        case MassType.Micrograms:
                            returnDouble = passedValue;
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
                case MassType.LongTons:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            break;
                        case MassType.Kilograms:
                            break;
                        case MassType.MetricTons:
                            break;
                        case MassType.Milligrams:
                            break;
                        case MassType.Micrograms:
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
                case MassType.ShortTons:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            break;
                        case MassType.Kilograms:
                            break;
                        case MassType.MetricTons:
                            break;
                        case MassType.Milligrams:
                            break;
                        case MassType.Micrograms:
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
                case MassType.Stones:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            break;
                        case MassType.Kilograms:
                            break;
                        case MassType.MetricTons:
                            break;
                        case MassType.Milligrams:
                            break;
                        case MassType.Micrograms:
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
                case MassType.Pounds:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            break;
                        case MassType.Kilograms:
                            break;
                        case MassType.MetricTons:
                            break;
                        case MassType.Milligrams:
                            break;
                        case MassType.Micrograms:
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
                case MassType.Ounces:
                    switch (typeConvertingTo)
                    {
                        case MassType.Grams:
                            break;
                        case MassType.Kilograms:
                            break;
                        case MassType.MetricTons:
                            break;
                        case MassType.Milligrams:
                            break;
                        case MassType.Micrograms:
                            break;
                        case MassType.LongTons:
                            break;
                        case MassType.ShortTons:
                            break;
                        case MassType.Stones:
                            break;
                        case MassType.Pounds:
                            break;
                        case MassType.Ounces:
                            break;
                    }
                    break;
            }

            return returnDouble;
        }
    }
}
