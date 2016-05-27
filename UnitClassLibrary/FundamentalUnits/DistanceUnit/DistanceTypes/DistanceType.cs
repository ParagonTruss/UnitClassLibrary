using System;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnit.DistanceTypes
{
    public class DistanceType : FundamentalUnitType
    {
        private static Inch _defaultDistanceType = new Inch(); 
        public override double ConversionFactor
        {
            get
            {
                return _defaultDistanceType.ConversionFactor;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return _defaultDistanceType.DefaultErrorMargin;
            }
        }

        public override string Type
        {
           get { return nameof(DistanceType); }
        }

        public override string AsStringSingular()
        {
            return _defaultDistanceType.AsStringSingular();
        }
        public override string AsStringPlural()
        {
            return _defaultDistanceType.AsStringPlural();
        }

        public static Distance operator *(Measurement m, DistanceType type)
        {
            return new Distance(m, type);
        }

        public static Distance operator *(double d, DistanceType type)
        {
            return new Distance(d, type);
        }

        public static Distance operator *(int m, DistanceType type)
        {
            return new Distance(m, type);
        }
    }
}