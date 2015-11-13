using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public interface IUnit
    {
        double ConversionFactor { get; }
        double DefaultErrorMargin { get; }

        string AsStringSingular { get; }
        string AsStringPlural { get; }
    }

    public interface IDerivedUnit
    {
        List<IUnit> Numerators { get; }
        List<IUnit> Denominators { get; }
        string AsStringSingular { get; }
        string AsStringPlural { get; }
    }
}
