using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// Enum for determining which format to use with Architectual String conversion into decimal units 
    /// </summary>
    public enum ArchitecturalDimensionStyle { Mitek, AutoCAD };

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
    public enum ForceType { Pounds, Newtons, Kips }

    /// <summary>
    /// Enum for specifying the type of unit an angle is
    /// </summary>
    public enum AngleType { Radian, Degree}

}
