using System;
using NUnit.Framework;
using UnitClassLibrary;
using System.Collections.Generic;

namespace UnitClassLibraryTests
{
    [TestFixture()]
    public class AreaNUNitTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void AreaN_ConversionToTests()
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
            Assert.AreEqual(660643.84, MillimetersSquared);
            Assert.AreEqual(6606.4384, CentimetersSquared);
            Assert.AreEqual(1024.0, InchesSquared);
            Assert.AreEqual(7.11111, FeetSquared, 0.00001);
            Assert.AreEqual(0.790123, YardsSquared, 0.000001);
            Assert.AreEqual(0.6606438, MetersSquared, 0.00001);
            Assert.AreEqual(.00000066064384, KilometersSquared, 0.00000000001);
            Assert.AreEqual(.000000255076, MilesSquared, 0.0000000001);
        }

        [Test()]
        public void AreaN_ConversionFromTests()
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
            Assert.AreEqual(0.15500031, MilInches, 0.000001);
            Assert.AreEqual(15.500031, CenInches, 0.000001);
            Assert.AreEqual(100,Inches);
            Assert.AreEqual(14400,FeetInches);
            Assert.AreEqual(129600,YardInches);
            Assert.AreEqual(155000.31,MeterInches);
            Assert.AreEqual(155000310000,KilometerInches);
            Assert.AreEqual(401448959990,MileInches);
        }

        [Test()]
        public void AreaN_CompareToTest()
        {
            Area a1 = new Area(AreaType.InchesSquared, 100);
            Area a2 = new Area(AreaType.MetersSquared, 0.5);
            Area a3 = new Area(AreaType.CentimetersSquared, 5);
            Area a4 = new Area(AreaType.KilometersSquared, 0.0000005);

            Assert.AreEqual(-1,a1.CompareTo(a2));
            Assert.AreEqual(1,a2.CompareTo(a3));
            Assert.AreEqual(-1,a3.CompareTo(a1));
            Assert.AreEqual(0,a4.CompareTo(a2));
        }

        [Test()]
        public void AreaN_ConstructorTests()
        {
            Area a1 = new Area();
            Area a2 = new Area(AreaType.InchesSquared, 100);
            Area a3 = new Area(AreaType.KilometersSquared, 100);

            Assert.AreEqual(0,a1.MillimetersSquared);
            Assert.AreEqual(100,a2.InchesSquared);
            Assert.AreEqual(155000310000,a3.InchesSquared);
        }

        [Test()]
        public void AreaN_EqualsTests()
        {
            Area a1 = new Area();
            Area a2 = new Area(AreaType.InchesSquared, 100);
            Area a3 = new Area(AreaType.CentimetersSquared, 645.16);
            Area a4 = new Area(AreaType.KilometersSquared, 0.00064516);

            Assert.IsFalse(a1.Equals(a2));
            Assert.IsTrue(a2.Equals(a3));
            Assert.IsFalse(a3.Equals(a4));
        }
    }
}
