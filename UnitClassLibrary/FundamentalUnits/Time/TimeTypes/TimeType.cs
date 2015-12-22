

namespace UnitClassLibrary.TimeUnit.TimeTypes
{
    public abstract class TimeType : FundamentalUnitType
    {
        public override string Type
        {
            get { return nameof(TimeType); }
        }
    }
}