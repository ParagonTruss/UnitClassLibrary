using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public interface IUnit
    {
        string AsStringSingular { get; }
        string AsStringPlural { get; }
    }

    public interface IFundamentalUnit : IUnit
    { 
        double ConversionFactor { get; }
        double DefaultErrorMargin { get; }
    }

    public interface IDerivedUnit : IUnit
    {
        List<IFundamentalUnit> Numerators { get; }
        List<IFundamentalUnit> Denominators { get; }
    }
}
