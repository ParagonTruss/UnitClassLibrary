using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// Enum for specifying the type of unit a dimension is
    /// </summary>
    public enum DimensionType { Millimeter, Centimeter, Meter, Kilometer, ThirtySecond, Sixteenth, Inch, Foot, Yard, Mile, ArchitecturalString };

    /// <summary>
    /// Enum for specifying the type of unit an area is
    /// </summary>
    public enum AreaType { MillimetersSquared, CentimetersSquared, MetersSquared, KilometersSquared, InchesSquared, FeetSquared, YardsSquared, MilesSquared };

    /// <summary>
    /// Enum for specifying the type of unit a force is
    /// </summary>
    public enum ForceType { Newtons, Pounds, Kips }

    /// <summary>
    /// Enum for specifying the type of unit an angle is
    /// </summary>
    public enum AngleType { Radian, Degree }

    /// <summary>
    /// Enum for specifying the type of unit a power is
    /// </summary>
    public enum PowerType { Watt, Horsepower, FootPoundsPerSecond, MetricHorsepower, ErgsPerSecond }

    /// <summary>
    /// Enum for specifying the type of unit a moment is
    /// </summary>
    public enum MomentType { PoundsMillimeters, PoundsFeet, NewtonMeters}

    /// <summary>
    /// Enum for specifying the type of unit a energy is
    /// </summary>
    public enum EnergyType { Joule, Erg, FootPound, KilogramMeter }

    /// <summary>
    /// Enum for specifying the type of unit a time is
    /// </summary>
    public enum TimeType { Second, Minute, Hour }

    /// <summary>
    /// Enum for specifying the type of unit a stress is
    /// </summary>
    public enum StressType { PoundsPerSquareInch, PoundsPerSquareMillimeter, NewtonsPerSquareMeter, NewtonsPerSquareMillimeter }
}
