using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.DerivedUnits
{
    public class MomentType : AbstractDerivedUnitType
    {
        private PoundInch _defaultMomentType = new PoundInch();
        public override string AsStringSingular()
        {
            return _defaultMomentType.AsStringSingular();
        }
        public override string AsStringPlural()
        {
            return _defaultMomentType.AsStringPlural();
        }
        public override UnitDimensions Dimensions()
        {
            return _defaultMomentType.Dimensions();
        }

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
