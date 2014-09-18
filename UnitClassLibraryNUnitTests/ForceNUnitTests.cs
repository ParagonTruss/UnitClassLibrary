using System;
using UnitClassLibrary;
using NUnit.Framework;


namespace UnitClassLibraryTests
{
    [TestFixture()]
    public class ForceTests
    {
        [Test()]
        public void ForceN_ConstructorAndCoversionTests()
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
            Assert.AreEqual(100,pound);
            Assert.AreEqual(444.822162,newton);
            Assert.AreEqual(0.1,kip);
        }

        [Test()]
        public void ForceN_MathOperatorTests()
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

            Assert.AreEqual(500,sumPound.Pounds);
            Assert.AreEqual(-250,differenceKip.Kips);
            Assert.AreEqual(250,differenceNewton.Newtons);
        }
    }
}
