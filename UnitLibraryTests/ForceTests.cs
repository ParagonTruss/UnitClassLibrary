using System;
using NUnit.Framework;
using FluentAssertions;
using UnitClassLibrary;


namespace UnitLibraryTests
{
    [TestFixture()]
    public class ForceTests
    {
        [Test()]
        public void Force_ConstructorAndCoversionTests()
        {
            // arrange
            ForceUnit poundForce = new ForceUnit(ForceType.Pounds, 100);
            ForceUnit newtonForce = new ForceUnit(ForceType.Newtons, 100);
            ForceUnit kipForce = new ForceUnit(ForceType.Kips, 100);

            // act
            double pound = poundForce.Pounds;
            double newton = poundForce.Newtons;
            double kip = poundForce.Kips;

            // assert
            pound.Should().Be(100);
            newton.Should().Be(444.822162);
            kip.Should().Be(0.1);
        }

    }
}
