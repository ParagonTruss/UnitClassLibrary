namespace UnitClassLibrary.GenericUnit
{
    public interface IUnit
    {
        double ConversionFactor { get; }

        string AsStringSingular { get; }
        string AsStringPlural { get; }
    }
}
