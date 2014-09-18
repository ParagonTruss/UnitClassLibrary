using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// Dimension class for units of power
    /// </summary>
    public class Power
    {
        #region _internalVariables
        private PowerType InternalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors

        public Power(PowerType passedPowerType, double passedValue)
        {
            InternalUnitType = passedPowerType;
            _intrinsicValue = passedValue;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Retrieves the power as the unit specified
        /// </summary>
        /// <param name="powerType">unit of power</param>
        /// <returns></returns>
        private double retrieveAsExternalUnit(PowerType powerType)
        {
            return ConvertPower(InternalUnitType, _intrinsicValue, powerType);
        }

        public static double ConvertPower(PowerType fromPowerType, double _intrinsicValue, PowerType toPowerType)
        {
            double returnValue = 0;
            
            switch (fromPowerType)
            {
                // Convert Watts or Ergs/Second to another unit
                case PowerType.Watt:
                case PowerType.ErgsPerSecond:
                    // An erg/second is simply 1/10000000 of a Watt, so just convert it to Watts and then perfrom the conversion
                    if (fromPowerType == PowerType.ErgsPerSecond)
                    {
                        _intrinsicValue /= 10000000;
                    }
                    switch (toPowerType)
                    {
                        case PowerType.Watt:
                            returnValue = _intrinsicValue; // Return given Watts
                            break;
                        case PowerType.Horsepower:
                            returnValue = _intrinsicValue * 0.00134102209; // Convert Watts to Horsepower
                            break;
                        case PowerType.FootPoundsPerSecond:
                            returnValue = _intrinsicValue * 0.737562149; // Convert Watts to FootPounds/Second
                            break;
                        case PowerType.MetricHorsepower:
                            returnValue = _intrinsicValue * 0.00135962162; // Convert Watts to Metric Horsepower
                            break;
                        case PowerType.ErgsPerSecond:
                            returnValue = _intrinsicValue * 10000000; // Convert Watts to Ergs/Second
                            break;
                        default:
                            //code should never run
                            throw new NotSupportedException("Unit not supported!");
                    }
                    break;
                // Convert Horsepower to another unit
                case PowerType.Horsepower:
                    switch (toPowerType)
                    {
                        case PowerType.Watt:
                            returnValue = _intrinsicValue * 745.699872; // Convert Horsepower to Watts
                            break;
                        case PowerType.Horsepower:
                            returnValue = _intrinsicValue; // Return given Horsepower
                            break;
                        case PowerType.FootPoundsPerSecond:
                            returnValue = _intrinsicValue * 550; // Convert Horsepower to FootPounds/Second
                            break;
                        case PowerType.MetricHorsepower:
                            returnValue = _intrinsicValue * 1.01386967; // Convert Horsepower to Metric Horsepower
                            break;
                        case PowerType.ErgsPerSecond:
                            returnValue = _intrinsicValue * 7456998720; // Convert Horsepower to Ergs/Second
                            break;
                        default:
                            //code should never run
                            throw new NotSupportedException("Unit not supported!");
                    }
                    break;
                // Convert FootPounds/Second to another unit
                case PowerType.FootPoundsPerSecond:
                    switch (toPowerType)
                    {
                        case PowerType.Watt:
                            returnValue = _intrinsicValue * 1.35581795; // Convert FootPounds/Second to Watts
                            break;
                        case PowerType.Horsepower:
                            returnValue = _intrinsicValue * 0.00181818182; // Convert FootPounds/Second to Horsepower
                            break;
                        case PowerType.FootPoundsPerSecond:
                            returnValue = _intrinsicValue; // Return given FootPounds/Second
                            break;
                        case PowerType.MetricHorsepower:
                            returnValue = _intrinsicValue * 0.00184339939; // Convert FootPounds/Second to Metric Horsepower
                            break;
                        case PowerType.ErgsPerSecond:
                            returnValue = _intrinsicValue * 13558179.5; // Convert FootPounds/Second to Ergs/Second
                            break;
                        default:
                            //code should never run
                            throw new NotSupportedException("Unit not supported!");
                    }
                    break;
                // Convert Metric Horsepower to another unit
                case PowerType.MetricHorsepower:
                    switch (toPowerType)
                    {
                        case PowerType.Watt:
                            returnValue = _intrinsicValue * 735.49875; // Convert Metric Horsepower to Watts
                            break;
                        case PowerType.Horsepower:
                            returnValue = _intrinsicValue * 0.986320071; // Convert Metric Horsepower to Horsepower
                            break;
                        case PowerType.FootPoundsPerSecond:
                            returnValue = _intrinsicValue * 542.476039; // Convert Metric Horsepower to FootPounds/Second
                            break;
                        case PowerType.MetricHorsepower:
                            returnValue = _intrinsicValue; // Return given Metric Horsepower
                            break;
                        case PowerType.ErgsPerSecond:
                            returnValue = _intrinsicValue * 7354987500; // Convert Metric Horsepower to Ergs/Second
                            break;
                        default:
                            //code should never run
                            throw new NotSupportedException("Unit not supported!");
                    }
                    break;
                default:
                    //code should never run
                    throw new NotSupportedException("Unit not supported!");
            }

            return returnValue;
        }

        #endregion

        #region Getters

        /// <summary>
        /// returns power as watts
        /// </summary>
        public double Watt
        {
            get { return retrieveAsExternalUnit(PowerType.Watt); }
        }

        /// <summary>
        /// Returns power as horsepower
        /// </summary>
        public double Horsepower
        {
            get { return retrieveAsExternalUnit(PowerType.Horsepower); }
        }

        /// <summary>
        /// Returns power as foot pounds / minute
        /// </summary>
        public double FootPoundsPerSecond
        {
            get { return retrieveAsExternalUnit(PowerType.FootPoundsPerSecond); } 
        }

        /// <summary>
        /// Returns power as metric horsepower
        /// </summary>
        public double MetricHorsepower
        {
            get { return retrieveAsExternalUnit(PowerType.MetricHorsepower); }
        }

        /// <summary>
        /// Returns power as ergs / second
        /// </summary>
        public double ErgsPerSecond
        {
            get { return retrieveAsExternalUnit(PowerType.ErgsPerSecond); }
        }

        #endregion
    }
}
