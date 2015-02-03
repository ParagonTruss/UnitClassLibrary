using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;
using System.Collections.Generic;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class AreaTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void Area_ConversionToTests()
        {
            // arrange
            Area SquareInchesArea = new Area(AreaType.InchesSquared, 1024);

            // act
            double MillimetersSquared = SquareInchesArea.MillimetersSquared;
            double CentimetersSquared = SquareInchesArea.CentimetersSquared;
            double InchesSquared = SquareInchesArea.InchesSquared;
            double FeetSquared = SquareInchesArea.FeetSquared;
            double YardsSquared = SquareInchesArea.YardsSquared;
            double MetersSquared = SquareInchesArea.MetersSquared;
            double KilometersSquared = SquareInchesArea.KilometersSquared;
            double MilesSquared = SquareInchesArea.MilesSquared;

            // assert
            MillimetersSquared.Should().Be(660643.84);
            CentimetersSquared.Should().Be(6606.4384);
            InchesSquared.Should().Be(1024.0);
            FeetSquared.Should().BeApproximately(7.11111, 0.00001);
            YardsSquared.Should().BeApproximately(0.790123, 0.000001);
            MetersSquared.Should().BeApproximately(0.6606438, 0.00001);
            KilometersSquared.Should().BeApproximately(.00000066064384, 0.00000000001);
            MilesSquared.Should().BeApproximately(.000000255076, 0.0000000001);
        }

        [Test()]
        public void Area_ConversionFromTests()
        {
            // arrange
            Area MillimetersArea = new Area(AreaType.MillimetersSquared, 100);
            Area CentimetersArea = new Area(AreaType.CentimetersSquared, 100);
            Area InchesArea = new Area(AreaType.InchesSquared, 100);
            Area FeetArea = new Area(AreaType.FeetSquared, 100);
            Area YardsArea = new Area(AreaType.YardsSquared, 100);
            Area MetersArea = new Area(AreaType.MetersSquared, 100);
            Area KilometersArea = new Area(AreaType.KilometersSquared, 100);
            Area MilesArea = new Area(AreaType.MilesSquared, 100);

            // act
            double millimetersSquaredAsInchesSquared = MillimetersArea.InchesSquared;
            double centimetersSquaredAsInchesSquared = CentimetersArea.InchesSquared;
            double InchesSquaredAsInchesSquared = InchesArea.InchesSquared;
            double feetSquaredAsInchesSquared = FeetArea.InchesSquared;
            double yardsSquaredAsInchesSquared = YardsArea.InchesSquared;
            double metersAsInchesSquared = MetersArea.InchesSquared;
            double kilometersAsInchesSquared = KilometersArea.InchesSquared;
            double milesSquaredAsInchesSquared = MilesArea.InchesSquared;

            // assert
            millimetersSquaredAsInchesSquared.Should().BeApproximately(0.15500031, 0.000001);
            centimetersSquaredAsInchesSquared.Should().BeApproximately(15.500031, 0.000001);
            InchesSquaredAsInchesSquared.Should().BeApproximately(100, 0.000001);
            feetSquaredAsInchesSquared.Should().BeApproximately(14400, 0.000001);
            yardsSquaredAsInchesSquared.Should().BeApproximately(129600, 0.000001);
            metersAsInchesSquared.Should().BeApproximately(155000, 100);
            kilometersAsInchesSquared.Should().BeApproximately(155000000000, 100000000);
            milesSquaredAsInchesSquared.Should().BeApproximately(401448960000, 100000000);
        }

        [Test()]
        public void Area_CompareToTest()
        {
            Area a1 = new Area(AreaType.InchesSquared, 100);
            Area a2 = new Area(AreaType.MetersSquared, 0.5);
            Area a3 = new Area(AreaType.CentimetersSquared, 5);
            Area a4 = new Area(AreaType.KilometersSquared, 0.0000005);

            a1.CompareTo(a2).Should().Be(-1);
            a2.CompareTo(a3).Should().Be(1);
            a3.CompareTo(a1).Should().Be(-1);
            a4.CompareTo(a2).Should().Be(0);
        }

        [Test()]
        public void Area_ConstructorTests()
        {
            Area a1 = new Area();
            Area a2 = new Area(AreaType.InchesSquared, 100);
            Area a3 = new Area(AreaType.KilometersSquared, 100);
            Area a4 = new Area(new Distance(DistanceType.Foot, 10), new Distance(DistanceType.Inch, 12));


            a1.MillimetersSquared.Should().Be(0);
            a2.InchesSquared.Should().Be(100);
            a3.InchesSquared.Should().Be(155000000000);
            a4.FeetSquared.Should().Be(10);
        }

        [Test()]
        public void Area_EqualityTests()
        {
            Area a1 = new Area();
            Area a2 = new Area(AreaType.InchesSquared, 100);
            Area a3 = new Area(AreaType.CentimetersSquared, 645.16);
            Area a4 = new Area(AreaType.KilometersSquared, 0.00064516);

            a1.Equals(a2).Should().BeFalse();
            a2.Equals(a3).Should().BeTrue();
            a3.Equals(a4).Should().BeFalse();

            //test for null handling capabilities
            Area nullAngle = null;
            Area otherNullAngle = null;

            //check ==
            bool nonNullFirst = (a1 == nullAngle);
            bool nullFirst = (nullAngle == a1);
            bool bothNull = (nullAngle == otherNullAngle);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (a1 != nullAngle);
            bool nullFirstNotEqual = (nullAngle != a1);
            bool bothNullNotEqual = (nullAngle != otherNullAngle);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should through a nullPointerException)
            bool nullSecond = a1.Equals(nullAngle);

            nullSecond.Should().BeFalse();
        }
    }
}
