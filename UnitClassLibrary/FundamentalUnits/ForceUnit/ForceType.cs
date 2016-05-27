using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.ForceUnit
{
    public class ForceType : FundamentalUnitType
    {
        private static Pound _defaultForceType = new Pound();
        public override double ConversionFactor
        {
            get
            {
                return _defaultForceType.ConversionFactor;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return _defaultForceType.DefaultErrorMargin;
            }
        }

        public override string AsStringSingular()
        {
            return _defaultForceType.AsStringSingular();
        }

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
