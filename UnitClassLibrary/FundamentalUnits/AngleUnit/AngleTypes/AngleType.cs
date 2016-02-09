using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    abstract public class AngleType : FundamentalUnitType
    {
        public override string Type { get { return nameof(AngleType); } }
    }
}
