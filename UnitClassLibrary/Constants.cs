
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.Properties;

namespace UnitClassLibrary
{
    public static class Constants
    {

        public static Dimension AcceptedEqualityDeviationDimension
        {
            get
            {
                try
                {
                  return new Dimension(DimensionType.Inch, double.Parse(Settings.Default.AcceptedEqualityDeviationDimensionInches));
                }
                catch (Exception)
                {

                    return new Dimension(DimensionType.Inch, 0.03125);
                }
            }

        }

        public static ForceUnit AcceptedEqualityDeviationForceUnit
        {
            get
            {
                try
                {
                    return new ForceUnit(ForceType.Pounds, double.Parse(Settings.Default.AcceptedEqualityDeviationForceUnitPounds));
                }
                catch (Exception)
                {

                    return new ForceUnit(ForceType.Pounds, 0.03125);
                }
            }

        }

        public static Area AcceptedEqualityDeviationArea
        {
            get
            {
                try
                {
                    return new Area(AreaType.InchesSquared, double.Parse(Settings.Default.AcceptedEqualityDeviationAreaInchesSquared));
                }
                catch (Exception)
                {

                    return new Area(AreaType.InchesSquared, 0.03125);
                }
            }

        }

        public static Angle AcceptedEqualityDeviationAngle
        {
            get
            {
                try
                {
                    return new Angle(AngleType.Degree, double.Parse(Settings.Default.AcceptedDeviationAngleRadians));
                }
                catch (Exception)
                {

                    return new Angle(AngleType.Degree, 1);
                }
            }

        }

        public static Stress AcceptedEqualityDeviationStress
        {
            get
            {
                try
                {
                    return new Stress(StressType.PoundsPerSquareInch, double.Parse(Settings.Default.AcceptedEqualityDeviationStressPoundsPerSquareInch));
                }
                catch (Exception)
                {

                    return new Stress(StressType.PoundsPerSquareInch, 1);
                }
            }

        }
    }
}
