
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    public static partial class DeviationDefaults
    {
        public static Power AcceptedEqualityDeviationPower
        {
            get
            {
                return new Power(PowerType.Watt, 0.03125);
            }
        }

        public static ForceUnit AcceptedEqualityDeviationForceUnit
        {
            get
            {
                return new ForceUnit(ForceType.Pounds, 0.03125);


                //try
                //{
                //    return new ForceUnit(ForceType.Pounds, double.Parse(Settings.Default.AcceptedEqualityDeviationForceUnitPounds));
                //}
                //catch (Exception)
                //{

                //    return new ForceUnit(ForceType.Pounds, 0.03125);
                //}
            }

        }

        public static Area AcceptedEqualityDeviationArea
        {
            get
            {
                return new Area(AreaType.InchesSquared, 0.03125);


                //try
                //{
                //    return new Area(AreaType.InchesSquared, double.Parse(Settings.Default.AcceptedEqualityDeviationAreaInchesSquared));
                //}
                //catch (Exception)
                //{

                //    return new Area(AreaType.InchesSquared, 0.03125);
                //}
            }

        }

        public static Angle AcceptedEqualityDeviationAngle
        {
            get
            {
                return new Angle(AngleType.Degree, 1);

                //try
                //{
                //    return new Angle(AngleType.Degree, double.Parse(Settings.Default.AcceptedDeviationAngleRadians));
                //}
                //catch (Exception)
                //{

                //    return new Angle(AngleType.Degree, 1);
                //}
            }

        }

        public static Stress AcceptedEqualityDeviationStress
        {
            get
            {
                return new Stress(StressType.PoundsPerSquareInch, 1);

                //try
                //{
                //    return new Stress(StressType.PoundsPerSquareInch, double.Parse(Settings.Default.AcceptedEqualityDeviationStressPoundsPerSquareInch));
                //}
                //catch (Exception)
                //{

                //    return new Stress(StressType.PoundsPerSquareInch, 1);
                //}
            }

        }

        public static Speed AcceptedEqualityDeviationSpeed
        {
            get
            {
                return new Speed(SpeedType.MilesPerHour, 1);

            }

        }

        public static Volume AcceptedEqualityDeviationVolume
        {
            get
            {
                return new Volume(VolumeType.CubicThirtySeconds, 1);

            }

        }
    }
}
