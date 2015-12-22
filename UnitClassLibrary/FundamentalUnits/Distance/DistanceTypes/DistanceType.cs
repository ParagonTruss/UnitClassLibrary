

namespace UnitClassLibrary.DistanceUnit.DistanceTypes
{
    public abstract class DistanceType : FundamentalUnitType
    {
        public override string Type
        {
           get { return nameof(DistanceType); }
        }
    }
}