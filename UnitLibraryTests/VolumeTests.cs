using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;
using System.Diagnostics;

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

            // act & assert
            (new Volume(VolumeType.Milliliters, 880000) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicCentimeters, 880000) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.Liters, 880) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicMeters, 0.88) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicInches, 53700.89480800000456) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicFeet, 31.076906714910322) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicYards, 1.15099654) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.CubicMiles, 2.11123228 * Math.Pow(10, -10)) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.Gallons, 232.471406075172) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.Quarts, 929.885624300688) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.Pints, 1859.771248601376) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.Cups, 3719.542497202752) == LitersVolume).Should().BeTrue();
            (new Volume(VolumeType.FluidOunces, 29756.33997762184) == LitersVolume).Should().BeTrue();

        }

        [Test()]
        public void Volume_ConstructorTests()
        {
            Volume v1 = new Volume(VolumeType.CubicMiles, 0);
            Volume v2 = new Volume(VolumeType.CubicFeet, 100);
            Volume v3 = new Volume(VolumeType.Gallons, 100);

            v1.CubicCentimeters.Should().Be(0);
            v2.CubicFeet.Should().Be(100);
            v3.Gallons.Should().Be(100);
        }

        [Test()]
        public void Volume_CompareToTest()
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
