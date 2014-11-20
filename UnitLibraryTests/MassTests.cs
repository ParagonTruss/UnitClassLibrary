using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class MassTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void Mass_ConversionToTests()
        {
            // arrange
            Mass KilogramsMass = new Mass(MassType.Kilograms, 880);

            // act
            double MetricTons = KilogramsMass.MetricTons;
            double Kilograms = KilogramsMass.Kilograms;
            double Grams = KilogramsMass.Grams;
            double Milligrams = KilogramsMass.Milligrams;
            double Micrograms = KilogramsMass.Micrograms;
            double LongTons = KilogramsMass.LongTons;
            double ShortTons = KilogramsMass.ShortTons;
            double Stones = KilogramsMass.Stones;
            double Pounds = KilogramsMass.Pounds;
            double Ounces = KilogramsMass.Ounces;
            

            // assert
            MetricTons.Should().BeApproximately(0.88, 0.00001);
            Kilograms.Should().Be(880);
            Grams.Should().BeApproximately(880000, 0.00001);
            Milligrams.Should().BeApproximately(880000000, 0.00001);
            Micrograms.Should().BeApproximately(880000000000, 0.00001);
            LongTons.Should().BeApproximately(0.866102, 0.00001);
            ShortTons.Should().BeApproximately(0.970034, 0.00001);
            Stones.Should().BeApproximately(138.576, 0.00001);
            Pounds.Should().BeApproximately(1940.07, 0.00001);
            Ounces.Should().BeApproximately(31041.1, 0.00001);
        }

        [Test()]
        public void Mass_ConstructorTest()
        {
            Mass m1 = new Mass();
            Mass m2 = new Mass(MassType.Gram, 100);
            Mass m3 = new Mass(MassType.Ounces, 100);

            m1.Kilograms.Should().Be(0);
            m2.Grams.Should().Be(100);
            m3.Ounces.Should().Be(100);
        }

        [Test()]
        public void Mass_CompareToTest()
        {
            Mass m1 = new Mass(MassType.Milligram, 100);
            Mass m2 = new Mass(MassType.LongTon, 100);
            Mass m3 = new Mass(MassType.Pounds, 100);

            m1.CompareTo(m2).Should().Be(-1);
            m2.CompareTo(m3).Should().Be(1);
            m1.CompareTo(m3).Should().Be(-1);
        }

        [Test()]
        public void Mass_EqualsTest()
        {
            Mass m1 = new Mass(MassType.MetricTon, 100);
            Mass m2 = new Mass(MassType.ShortTon, 50);
            Mass m3 = new Mass(MassType.Stone, 157.473);

            m1.Equals(m2).Should().BeFalse();
            m1.Equals(m3).Should().BeTrue();
            m2.Equals(m3).Should().BeFalse();
        }

        [Test()]
        [ExpectedException(typeof(NotImplementedException))]
        public void Mass_ToStringTest()
        {
            Mass m1 = new Mass(MassType.Gram, 100);

            string massToString = m1.ToString();

            massToString.Should().Be("");
        }
    }
}
