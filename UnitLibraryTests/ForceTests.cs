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
            Force poundForce = new Force(ForceType.Pound, 100);
            Force newtonForce = new Force(ForceType.Newton, 100);
            Force kipForce = new Force(ForceType.Kip, 100);

            // act
            double pound = poundForce.Pounds;
            double newton = poundForce.Newtons;
            double kip = poundForce.Kips;

            // assert
            pound.Should().Be(100);
            newton.Should().Be(444.822162);
            kip.Should().Be(0.1);
        }

        [Test()]
        public void Force_AbsoluteValueTests()
        {
            // new units
            ForceUnit negativeForce = new ForceUnit(ForceType.Pounds, -100);
            ForceUnit positiveForce = new ForceUnit(ForceType.Pounds, 100);

            // get absolute values
            double negativeAbs = negativeForce.GetAbsoluteValue(ForceType.Pounds);
            double positiveAbs = positiveForce.GetAbsoluteValue(ForceType.Pounds);

            // assert
            negativeAbs.Should().Be(100);
            positiveAbs.Should().Be(100);
            negativeAbs.ShouldBeEquivalentTo(positiveAbs);
        }

    }
}
