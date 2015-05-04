namespace UnitClassLibrary
{
    public interface ISimpleUnitType: IUnitType
    {
        double ConversionFactor { get; } 
    }
}