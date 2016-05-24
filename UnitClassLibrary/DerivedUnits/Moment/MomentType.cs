using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.DerivedUnits
{
    abstract public class MomentType : AbstractDerivedUnitType
    {
        public static Moment operator *(Measurement m, MomentType type)
        {
            return new Moment(m, type);
        }

        public static Moment operator *(double d, MomentType type)
        {
            return new Moment(d, type);
        }

        public static Moment operator *(int m, MomentType type)
        {
            return new Moment(m, type);
        }
    }
}
