using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class SpeedTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void Speed_ConversionToTests()
        {
            // arrange
            Speed MilesPerHourSpeed = new Speed(SpeedType.MilesPerHour, 180);

            // act
            double MilesPerHour = MilesPerHourSpeed.MilesPerHours;
            double FeetPerSecond = MilesPerHourSpeed.FeetPerSeconds;
            double MetersPerSecond = MilesPerHourSpeed.MetersPerSeconds;
            double KilometersPerHour = MilesPerHourSpeed.KilometersPerHours;
            
            // assert
            MilesPerHour.Should().Be(180);
            FeetPerSecond.Should().BeApproximately(264, 0.01);
            MetersPerSecond.Should().BeApproximately(80.4672, 0.01);
            KilometersPerHour.Should().BeApproximately(289.682, 0.01);
        }

        [Test()]
        public void Speed_CompositeConstructorTest()
        {
            Distance d1 = new Distance(DistanceType.Mile, 10);
            Time t1 = new Time(TimeType.Hour, 1);

            Speed s1 = new Speed(d1, t1);
        }

        [Test()]
        public void Speed_ConstructorTest()
        {
            Speed s2 = new Speed(SpeedType.FeetPerSecond, 100);
            Speed s3 = new Speed(SpeedType.MetersPerSecond, 100);

            (new Speed(SpeedType.FeetPerSecond, 100) == s2).Should().BeTrue();
            (new Speed(SpeedType.MetersPerSecond, 100) == s3).Should().BeTrue();
        }


        [Test()]
        public void Speed_EqualsTest()
        {
            Speed s1 = new Speed(SpeedType.FeetPerSecond, 100);
            Speed s2 = new Speed(SpeedType.MetersPerSecond, 50);
            Speed s3 = new Speed(SpeedType.KilometersPerHour, 180);

            s1.Equals(s2).Should().BeFalse();
            s1.Equals(s3).Should().BeFalse();
            s2.Equals(s3).Should().BeTrue();
        }

        [Test()]
        public void Speed_ToStringTest()
        {
            Speed s1 = new Speed(SpeedType.MilesPerHour, 100);

            string SpeedToString = s1.ToString();

            SpeedToString.Should().Be("100/1 Mile/Hour");
        }
    }
}
