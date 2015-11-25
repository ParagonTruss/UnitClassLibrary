using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AngleUnit.AngleTypes
{
    public abstract class AngleType : FundamentalUnitType
    {
        public override string Type
        {
            get { return nameof(AngleType); }
        }
    }
}
