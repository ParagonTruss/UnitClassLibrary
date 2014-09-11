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
            Assert.AreEqual(MillimetersSquared, 660643.84);
            Assert.AreEqual(CentimetersSquared,6606.4384);
            Assert.AreEqual(InchesSquared,1024.0);
            Assert.AreEqual(FeetSquared,7.11111, 0.00001);
            Assert.AreEqual(YardsSquared,0.790123, 0.000001);
            Assert.AreEqual(MetersSquared,0.6606438, 0.00001);
            Assert.AreEqual(KilometersSquared, .00000066064384, 0.00000000001);
            Assert.AreEqual(MilesSquared,.000000255076, 0.0000000001);
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
            double MilInches = MillimetersArea.InchesSquared;
            double CenInches = CentimetersArea.InchesSquared;
            double Inches = InchesArea.InchesSquared;
            double FeetInches = FeetArea.InchesSquared;
            double YardInches = YardsArea.InchesSquared;
            double MeterInches = MetersArea.InchesSquared;
            double KilometerInches = KilometersArea.InchesSquared;
            double MileInches = MilesArea.InchesSquared;

            // assert
            Assert.AreEqual(MilInches,0.15500031, 0.000001);
            Assert.AreEqual(CenInches,15.500031, 0.000001);
            Assert.AreEqual(Inches,100);
            Assert.AreEqual(FeetInches,14400);
            Assert.AreEqual(YardInches,129600);
            Assert.AreEqual(MeterInches,155000.31);
            Assert.AreEqual(KilometerInches,155000310000);
            Assert.AreEqual(MileInches,401448959990);
        }

        [Test()]
        public void Area_CompareToTest()
        {
            Area a1 = new Area(AreaType.InchesSquared, 100);
            Area a2 = new Area(AreaType.MetersSquared, 0.5);
            Area a3 = new Area(AreaType.CentimetersSquared, 5);
            Area a4 = new Area(AreaType.KilometersSquared, 0.0000005);

            Assert.AreEqual(a1.CompareTo(a2),-1);
            Assert.AreEqual(a2.CompareTo(a3),1);
            Assert.AreEqual(a3.CompareTo(a1),-1);
            Assert.AreEqual(a4.CompareTo(a2),0);
        }

        [Test()]
        public void Area_ConstructorTests()
        {
            Area a1 = new Area();
            Area a2 = new Area(AreaType.InchesSquared, 100);
            Area a3 = new Area(AreaType.KilometersSquared, 100);

            Assert.AreEqual(a1.MillimetersSquared,0);
            Assert.AreEqual(a2.InchesSquared,100);
            Assert.AreEqual(a3.InchesSquared, 155000310000);
        }

        [Test()]
        public void Area_EqualsTests()
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
