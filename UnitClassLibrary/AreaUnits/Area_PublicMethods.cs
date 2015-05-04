using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AreaUnits.AreaTypes;
using UnitClassLibrary.AreaUnits.AreaTypes.Imperial.AcreUnit;
using UnitClassLibrary.BaseUnit;

namespace UnitClassLibrary.AreaUnits
{
    public partial class Area
    {
        /// <summary>
        /// Creates a new Area that is the negative of this one
        /// </summary>
        public new Area Negate()
        {
            return (Area)base.Negate();
        }

        /// <summary>
        /// Creates a new Area that is the absolute value of this one
        /// </summary>
        public new Area AbsoluteValue()
        {
            return (Area)base.AbsoluteValue(); ;
        }
    }
}
