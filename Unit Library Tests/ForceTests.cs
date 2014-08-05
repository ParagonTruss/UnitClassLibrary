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
        public void ForceConstructorAndConversionTests()
        {
            // arrange
            Force poundForce = new Force(ForceType.Pounds, 100);
            Force newtonForce = new Force(ForceType.Newtons, 100);
            Force kipForce = new Force(ForceType.Kips, 100);

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
