using System;
using NUnit.Framework;
using UnitClassLibrary;
using FluentAssertions;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class ElectricCurrentTests
    {
        /// <summary>
        /// Conversions to tests.
        /// </summary>
        [Test()]
        public void ElectricCurrent_ConversionToTests()
        {
            // arrange
            ElectricCurrent AmperesElectricCurrent = new ElectricCurrent(ElectricCurrentType.Amperes, 250);

            // act
            double Amperes = AmperesElectricCurrent.Amperes;
            double MilliAmperes = AmperesElectricCurrent.MilliAmperes;
            double VoltOhms = AmperesElectricCurrent.VoltOhms;
            double WattVolts = AmperesElectricCurrent.WattVolts;

            // assert
            Amperes.Should().Be(250);
            MilliAmperes.Should().BeApproximately(250000, 0.00001);
            VoltOhms.Should().BeApproximately(250, 0.00001);
            WattVolts.Should().BeApproximately(250, 0.00001);
        }

        [Test()]
        public void ElectricCurrent_ConstructorTest()
        {
            ElectricCurrent ec1 = new ElectricCurrent();
            ElectricCurrent ec2 = new ElectricCurrent(ElectricCurrentType.MilliAmperes, 100);
            ElectricCurrent ec3 = new ElectricCurrent(ElectricCurrentType.VoltOhms, 100);

            ec1.Amperes.Should().Be(0);
            ec2.MilliAmperes.Should().Be(100);
            ec3.VoltOhms.Should().Be(100);
        }

        [Test()]
        public void ElectricCurrent_CompareToTest()
        {
            ElectricCurrent ec1 = new ElectricCurrent(ElectricCurrentType.WattVolts, 100);
            ElectricCurrent ec2 = new ElectricCurrent(ElectricCurrentType.Amperes, 100);
            ElectricCurrent ec3 = new ElectricCurrent(ElectricCurrentType.MilliAmperes, 100);

            ec1.CompareTo(ec2).Should().Be(0);
            ec1.CompareTo(ec3).Should().Be(1);
            ec2.CompareTo(ec3).Should().Be(1);
            ec3.CompareTo(ec2).Should().Be(-1);
        }

        [Test()]
        public void ElectricCurrent_EqualsTest()
        {
            ElectricCurrent ec1 = new ElectricCurrent(ElectricCurrentType.VoltOhms, 100);
            ElectricCurrent ec2 = new ElectricCurrent(ElectricCurrentType.WattVolts, 50);
            ElectricCurrent ec3 = new ElectricCurrent(ElectricCurrentType.Amperes, 100);

            ec1.Equals(ec2).Should().BeFalse();
            ec1.Equals(ec3).Should().BeTrue();
            ec2.Equals(ec3).Should().BeFalse();
        }

        [Test()]
        [ExpectedException(typeof(NotImplementedException))]
        public void ElectricCurrent_ToStringTest()
        {
            ElectricCurrent ec1 = new ElectricCurrent(ElectricCurrentType.MilliAmperes, 100);

            string ElectricCurrentToString = ec1.ToString();

            ElectricCurrentToString.Should().Be("");
        }
    }
}
