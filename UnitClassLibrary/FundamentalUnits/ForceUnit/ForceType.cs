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

        public static Force operator *(Measurement m, ForceType type)
        {
            return new Force(m, type);
        }

        public static Force operator *(double d, ForceType type)
        {
            return new Force(d, type);
        }

        public static Force operator *(int m, ForceType type)
        {
            return new Force(m, type);
        }
    }
}
