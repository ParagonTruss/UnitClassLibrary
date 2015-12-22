using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.ForceUnit
{
    public abstract class ForceType : FundamentalUnitType
    {
        public override string Type
        {
           get { return nameof(ForceType); }
        }
    }
}
