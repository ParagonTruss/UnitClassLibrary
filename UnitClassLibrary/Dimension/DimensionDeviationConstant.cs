using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static partial class DeviationConstants
    {
        public static Dimension AcceptedEqualityDeviationDimension
        {
            get
            {
                return new Dimension(DimensionType.Inch, 0.03125);

                //try
                //{
                //  return new Dimension(DimensionType.Inch, double.Parse(Settings.Default.AcceptedEqualityDeviationDimensionInches));
                //}
                //catch (Exception)
                //{

                //    return new Dimension(DimensionType.Inch, 0.03125);
                //}
            }

        }
    }
}