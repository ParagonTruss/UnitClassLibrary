using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary;
using UnitClassLibrary.DerivedUnits;
using UnitClassLibrary.DerivedUnits.StressUnit;
using UnitClassLibrary.DistanceUnit;

namespace UnitLibraryTests
{
    [TestFixture]
    class DerivedUnitTests
    {
        

        [Test]
        public void DerivedUnits_SpeedTest()
        {
            var total = Stress.ZeroStress;
            for (int i = 0; i < 1E7; i++)
            {
                var stress = new Stress(5, Stress.PSI);
                total += stress;
            }
         
            Assert.Pass();
        }

        [Test]
        public void FundamentalUnit_SpeedTest()
        {
            var total = Distance.ZeroDistance;
            for (int i = 0; i < 1E7; i++)
            {
                var distance = new Distance(5, Distance.Inches);
                total += distance;
            }

            Assert.Pass();
        }

        [Test]
        public void Measurement_SpeedTest()
        {
            var total = new Measurement();
            for (int i = 0; i < 1E7; i++)
            {
                var measurement = new Measurement(5);
                total += measurement;
            }

            Assert.Pass();
        }

        [Test]
        public void Double_SpeedTest()
        {
            var total = 0;
            for (int i = 0; i < 1E7; i++)
            {
                var five = 5;
                total += five;
            }

            Assert.Pass();
        }

        [Test]
        public void Moment_ToStringTest()
        {

            var moment = new Moment(-173.87, Moment.PoundInches);

            moment.ToString().Should().Be("-173.87 lb-in.");
        }

    }
}
