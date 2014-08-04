using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClassLibrary;
using FluentAssertions;
using System.Collections.Generic;

namespace UnitClassLibraryTest
{
    [TestClass()]
    public class AreaTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [TestMethod()]
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

        [TestMethod()]
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
            double MilInches = MillimetersArea.InchesSquared;
            double CenInches = CentimetersArea.InchesSquared;
            double Inches = InchesArea.InchesSquared;
            double FeetInches = FeetArea.InchesSquared;
            double YardInches = YardsArea.InchesSquared;
            double MeterInches = MetersArea.InchesSquared;
            double KilometerInches = KilometersArea.InchesSquared;
            double MileInches = MilesArea.InchesSquared;

            // assert
            MilInches.Should().BeApproximately(0.15500031, 0.000001);
            CenInches.Should().BeApproximately(15.500031, 0.000001);
            Inches.Should().Be(100);
            FeetInches.Should().Be(14400);
            YardInches.Should().Be(129600);
            MeterInches.Should().Be(155000.31);
            KilometerInches.Should().Be(155000310000);
            MileInches.Should().Be(401448959990);
        }
    }
}
