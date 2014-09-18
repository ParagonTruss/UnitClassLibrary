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
            double pnewton = poundForce.Newtons;
            double ppound = poundForce.Pounds;
            double pkip = poundForce.Kips;

            double nnewton = newtonForce.Newtons;
            double npound = newtonForce.Pounds;
            double nkip = newtonForce.Kips;

            double knewton = kipForce.Newtons;
            double kpound = kipForce.Pounds;
            double kkips = kipForce.Kips;

            // assert
            Assert.AreEqual(444.822162, pnewton);
            Assert.AreEqual(100,ppound);
            Assert.AreEqual(0.1,pkip);

            Assert.AreEqual(100, nnewton, 0.00001);
            Assert.AreEqual(22.4808943, npound, 0.00001);
            Assert.AreEqual(0.022480894387096183, nkip, 0.00001);

            Assert.AreEqual(444822.16, knewton, 0.01);
            Assert.AreEqual(100000, kpound);
            Assert.AreEqual(100, kkips);
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

            Assert.AreEqual(500,sumPound.Pounds, 0.00000001d);
            Assert.AreEqual(-250, differenceKip.Kips, 0.00000001d);
            Assert.AreEqual(250,differenceNewton.Newtons, 0.00000001d);
        }
    }
}
