using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary
{
    /// <summary>
    /// class that defines mass with a base unit of Kilograms
    /// </summary>
    public class Mass
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
        /// <summary>
        /// constructor that takes passedKilograms and sets Kilograms to it
        /// </summary>
        /// <param name="passedKilograms">amount that kilograms should have</param>
        public Mass(double passedKilograms)
        {
            Kilograms = passedKilograms;
        }
        #endregion
    }
}
