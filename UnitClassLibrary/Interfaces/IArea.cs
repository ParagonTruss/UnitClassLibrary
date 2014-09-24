using System;
namespace UnitClassLibrary
{
    interface IArea
    {
        double CentimetersSquared { get; }
        double FeetSquared { get; }
        double InchesSquared { get; }
        double KilometersSquared { get; }
        double MetersSquared { get; }
        double MilesSquared { get; }
        double MillimetersSquared { get; }
        double YardsSquared { get; }
    }
}
