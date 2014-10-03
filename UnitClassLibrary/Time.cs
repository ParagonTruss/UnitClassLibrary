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
        private TimeType InternalUnitType;
        private double _intrinsicValue;
        #endregion

        #region Constructors
        public Time()
        {
            _intrinsicValue = 0.0;
        }

        public Time(TimeType passedTimeType, double passedValue)
        {
            InternalUnitType = passedTimeType;
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
        #endregion
    }
}
