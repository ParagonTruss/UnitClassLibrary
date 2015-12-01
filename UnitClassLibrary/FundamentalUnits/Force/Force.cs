using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.ForceUnit
{
    public class Force : Unit<ForceType>
    {
        public Force(ForceType type, Measurement value) : base(type,value)
        {
            
        }
        #region Static Properties
        public static readonly Force Zero = new Force(new Pound(), new Measurement());

        public static readonly Force Pound = new Force(new Pound(), new Measurement(1));

        public static readonly Force Newton = new Force(new Newton(), new Measurement(1));
        #endregion
    }
}
