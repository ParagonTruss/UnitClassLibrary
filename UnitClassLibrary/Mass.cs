using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// class that defines mass with a base unit of Kilograms
    /// </summary>
    public class Mass : IComparable<Mass>
    {
        #region _internalVariables
        private double _intrinsicValue = 0.0;
        #endregion

        #region Properties
        /// <summary>
        /// getter / setter for _kilograms
        /// </summary>
        public double Kilograms
        {
            get;
            private set;
        }
        #endregion

        #region Constructors

        public Mass()
        {
            throw new NotImplementedException();
        }

        public Mass(MassType passedType, double passedValue)
        {
            throw new NotImplementedException();
        }

        #endregion

        public int CompareTo(Mass other)
        {
            throw new NotImplementedException();
        }

        public double Grams { get; set; }

        public double MetricTons { get; set; }

        public double Milligrams { get; set; }

        public double Micrograms { get; set; }

        public double LongTons { get; set; }

        public double ShortTons { get; set; }

        public double Stones { get; set; }

        public double Pounds { get; set; }

        public double Ounces { get; set; }
    }
}
