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

    public enum PerspectiveType{ Top, Side, Bottom }

    /// <summary>
    /// Enum for specifying the type of unit an angle is
    /// </summary>
    public enum AngleType { Radian, Degree}

    public enum LoadType { Snow, Wind, Seismic, Thermal}

    public enum LoadDistribution { Point, Triangular, Uniform, Trapezoidal, Irregular }

    public enum LoadDurationType { Live, Dead, Enviormental}

    /// <summary>
    /// Enum for specifying which plane a point exists in
    /// </summary>
    public enum CoordinateSystem { XY, XZ, YZ, YX, ZX, ZY }

    public enum Axis { X, Y, Z }

    public enum FixityType { Pin, HorizontalRoller, VerticalRoller }

    public enum BearingType { Wall}

    public enum CutType { Scarf, Butt, Seat, Bevel}

    public enum KXRComponentType { Gable, Girder, Hip, Jack, Rafter, Attic, Ag, Reversed, StructuralGable, Normal }

    public enum ComponentStructure { Roof, Floor, Wall }

    public enum MemberType { Web, Chord }

    public enum LevelType { Normal, Basement}

    public enum LinkLoadingType { TopChord, BottomChord}

    public enum LinkType { Overhang}

    public enum ExposureCategory {C, Partial}

    public enum TerrainCategory { Unheated}

    public enum BuildingCategory {II }

    public enum ComponentFileType { TRE, KXR, Component}

    public enum BuildingType { MultiFamily, Commercial, SingleFamily}

    public enum UnitType { Handicap, Normal }

}
