using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.DerivedUnits.Mass
{
    public class Slug : MassType
    {
        public override UnitDimensions Dimensions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string AsStringSingular()
        {
            return "Slug";
        }
    }
}
