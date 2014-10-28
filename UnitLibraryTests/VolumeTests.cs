using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class VolumeTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void Volume_ConversionToTests()
        {
            // arrange
            Volume LitersVolume = new Volume(VolumeType.Liters, 880);

            // act
            double Milliliters = LitersVolume.Milliliters;
            double CubicCentimeters = LitersVolume.CubicCentimeters;
            double Liters = LitersVolume.Liters;
            double CubicMeters = LitersVolume.CubicMeters;
            double CubicInches = LitersVolume.CubicInches;
            double CubicFeet = LitersVolume.CubicFeet;
            double CubicYards = LitersVolume.CubicYards;
            double CubicMiles = LitersVolume.CubicMiles;
			double Gallons = LitersVolume.Gallons;
			double Quarts = LitersVolume.Quarts;
			double Pints = LitersVolume.Pints;
			double Cups = LitersVolume.Cups;
			double FluidOunces = LitersVolume.FluidOunces;

            // assert
            Milliliters.Should().Be(880000);
            CubicCentimeters.Should().Be(880000);
            Liters.Should().Be(880);
            CubicMeters.Should().Be(0.88);
            CubicInches.Should().BeApproximately(53700.894803364165, 53700.894803364165 * 0.00001);
            CubicFeet.Should().BeApproximately(31.076906714910322, 31.076906714910322 * 0.00001);
            CubicYards.Should().BeApproximately(10.3589666667, 10.3589666667 * 0.00001);
            CubicMiles.Should().BeApproximately(2.11123228 * Math.Pow(10, -10), 2.11123228 * Math.Pow(10, -10) * 0.00001);
            Gallons.Should().BeApproximately(232.471406075172, 232.471406075172 * 0.00001);
            Quarts.Should().BeApproximately(929.885624300688, 929.885624300688 * 0.00001);
            Pints.Should().BeApproximately(1859.771248601376, 1859.771248601376 * 0.00001);
            Cups.Should().BeApproximately(3719.542497202752, 3719.542497202752 * 0.00001);
            FluidOunces.Should().BeApproximately(29756.33997762184, 29756.33997762184 * 0.00001);
        }

        [Test()]
        public void Volume_ConstructorTests()
        {
            Volume v1 = new Volume();
            Volume v2 = new Volume(VolumeType.CubicFeet, 100);
            Volume v3 = new Volume(VolumeType.Gallons, 100);

            v1.CubicCentimeters.Should().Be(0);
            v2.CubicFeet.Should().Be(100);
            v3.Gallons.Should().Be(100);
        }

        [Test()]
        public void Area_CompareToTest()
        {
            Volume v1 = new Volume(VolumeType.CubicCentimeters, 100);
            Volume v2 = new Volume(VolumeType.Milliliters, 100);
            Volume v3 = new Volume(VolumeType.Quarts, 100);

            v1.CompareTo(v2).Should().Be(0);
            v2.CompareTo(v3).Should().Be(-1);
            v1.CompareTo(v3).Should().Be(-1);
        }

        [Test()]
        public void Volume_EqualityTests()
        {
            Volume v1 = new Volume(VolumeType.CubicCentimeters, 100);
            Volume v2 = new Volume(VolumeType.Milliliters, 100);
            Volume v3 = new Volume(VolumeType.Quarts, 100);

            v1.Equals(v2).Should().BeTrue();
            v1.Equals(v2).Should().BeTrue();
            v2.Equals(v3).Should().BeFalse();


            //test for null handling capabilities
            Volume nullAngle = null;
            Volume otherNullAngle = null;

            //check ==
            bool nonNullFirst = (v1 == nullAngle);
            bool nullFirst = (nullAngle == v1);
            bool bothNull = (nullAngle == otherNullAngle);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (v1 != nullAngle);
            bool nullFirstNotEqual = (nullAngle != v1);
            bool bothNullNotEqual = (nullAngle != otherNullAngle);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should through a nullPointerException)
            bool nullSecond = v1.Equals(nullAngle);

            nullSecond.Should().BeFalse();
        }
    }
}
