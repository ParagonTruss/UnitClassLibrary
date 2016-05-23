

namespace UnitClassLibrary.DistanceUnit.DistanceTypes
{
    public abstract class DistanceType : FundamentalUnitType
    {
        public override string Type
        {
           get { return nameof(DistanceType); }
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