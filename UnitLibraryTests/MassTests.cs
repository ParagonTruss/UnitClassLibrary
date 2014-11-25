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
            Stones.Should().BeApproximately(138.576, 0.001);
            Pounds.Should().BeApproximately(1940.07, 0.01);
            Ounces.Should().BeApproximately(31041.1, 0.1);
        }

        [Test()]
        public void Mass_ConstructorTest()
        {
            Mass m1 = new Mass();
            Mass m2 = new Mass(MassType.Grams, 100);
            Mass m3 = new Mass(MassType.Ounces, 100);

            m1.Kilograms.Should().Be(0);
            m2.Grams.Should().Be(100);
            m3.Ounces.Should().Be(100);
        }

        [Test()]
        public void Mass_CompareToTest()
        {
            Mass m1 = new Mass(MassType.Milligrams, 100);
            Mass m2 = new Mass(MassType.LongTons, 100);
            Mass m3 = new Mass(MassType.Pounds, 100);

            m1.CompareTo(m2).Should().Be(-1);
            m2.CompareTo(m3).Should().Be(1);
            m1.CompareTo(m3).Should().Be(-1);
        }

        [Test()]
        public void Mass_EqualsTest()
        {
            
            // arrange
            Mass biggerMass = new Mass(MassType.Pounds, 2.21);
            Mass smallerMass = new Mass(MassType.Grams, 100);
            Mass equivalentbiggerMass = new Mass(MassType.Kilograms, 1.00244);

            (equivalentbiggerMass.Equals(biggerMass)).Should().Be(true);
            (equivalentbiggerMass == smallerMass).Should().Be(false);

            (equivalentbiggerMass != smallerMass).Should().Be(true);
            (equivalentbiggerMass != biggerMass).Should().Be(false);


            //check ==
            bool nonNullFirst = (biggerMass == null);
            bool nullFirst = (null == biggerMass);
            bool bothNull = (null == null);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (biggerMass != null);
            bool nullFirstNotEqual = (null != biggerMass);
            bool bothNullNotEqual = (null != null);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should throw a nullPointerException)
            bool nullSecond = biggerMass.Equals(null);

            nullSecond.Should().BeFalse();
            
        }

        [Test()]
        public void Mass_ToStringTest()
        {
            Mass m1 = new Mass(MassType.Grams, 100);
            Mass m2 = new Mass(MassType.Kilograms, 80);

            string massToString = m1.ToString();
            string mass2ToString = m2.ToString(MassType.Pounds);

            massToString.Should().Be("100 Grams");
            mass2ToString.Should().Be("176.3696 Pounds");
        }
    }
}
