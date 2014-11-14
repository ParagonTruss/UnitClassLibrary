using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public delegate bool DimensionEqualityStrategy (Dimension dimension1, Dimension dimension2, Dimension? DeviationConstant = null);

    public static partial class DeviationConstants
    {
        public static Dimension AcceptedEqualityDeviationDimension
        {
            get
            {
                return new Dimension(DimensionType.ThirtySecond, 1);
            }
        }
    }

    public static class EqualityFunctionImplementations
    {
        public static bool PercentageEquality(Dimension dimension1, Dimension dimension2, Dimension? DeviationConstant = null)
        {
            return (Math.Abs(dimension1.GetValue(dimension1.InternalUnitType) - (dimension2).GetValue(dimension1.InternalUnitType))) <= Math.Abs(dimension1.GetValue(dimension1.InternalUnitType) * 0.00001);
        }

        public static bool ConstantEquality(Dimension dimension1, Dimension dimension2, Dimension? DeviationConstant = null)
        {
            return (Math.Abs(dimension1.GetValue(dimension1.InternalUnitType) - (dimension2).GetValue(dimension1.InternalUnitType))) <= DeviationConstant.Value.GetValue(dimension1.InternalUnitType);
        }
    }
}
