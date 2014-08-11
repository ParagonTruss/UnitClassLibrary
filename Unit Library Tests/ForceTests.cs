using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using UnitClassLibrary;


namespace UnitClassLibraryTests
{
    [TestClass()]
    public class ForceTests
    {
        [TestMethod()]
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

        [TestMethod()]
        public void Force_MathOperatorTests()
        {
            ForceUnit pound = new ForceUnit(ForceType.Pounds, 250);
            ForceUnit pound2 = new ForceUnit(ForceType.Pounds, 250);
            ForceUnit kip = new ForceUnit(ForceType.Kips, 250);
            ForceUnit kip2 = new ForceUnit(ForceType.Kips, 500);
            ForceUnit newton = new ForceUnit(ForceType.Newtons, 500);
            ForceUnit newton2 = new ForceUnit(ForceType.Newtons, 250);

            ForceUnit sumPound = pound + pound2;
            ForceUnit differenceKip = kip - kip2;
            ForceUnit differenceNewton = newton - newton2;

            sumPound.Pounds.Should().Be(500);
            differenceKip.Kips.Should().Be(-250);
            differenceNewton.Newtons.Should().Be(250);
        }
    }
}
