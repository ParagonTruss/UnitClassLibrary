

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
    }
}