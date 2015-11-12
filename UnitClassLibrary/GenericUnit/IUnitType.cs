namespace UnitClassLibrary.GenericUnit
{
    public interface IUnitType
    {
        double ConversionFactor { get; }
        string AsStringSingular { get; }
        string AsStringPlural { get; }
    }
}
