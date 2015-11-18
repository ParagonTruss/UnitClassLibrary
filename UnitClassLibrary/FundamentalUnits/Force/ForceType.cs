using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.ForceUnit
{
    public abstract class ForceType : FundamentalUnitType
    {
        public override string Type
        {
           get { return typeof(ForceType).ToString(); }
        }
    }
}
