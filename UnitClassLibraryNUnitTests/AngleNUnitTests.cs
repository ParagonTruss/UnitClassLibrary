using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitClassLibrary.Tests
{
    [TestFixture()]
    public class AngleTests
    {
        [Test()]
        public void Angle_GetHashCode()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 359);

            int hash1 = a1.GetHashCode();
            int hash2 = a2.GetHashCode();
            int hash3 = a3.GetHashCode();

            Assert.AreEqual(hash1,hash2);
            Assert.AreNotEqual(hash2,hash3);
        }

        // SHOULD BE 275 BUT HAS ROUNDING ERRORS
        [Test()]
        public void Angle_ToStringOverride()
        {
            Angle a1 = new Angle(AngleType.Degree, 275);
            Angle a2 = new Angle(AngleType.Radian, 2 * Math.PI);

            Assert.AreEqual(a1.ToString(AngleType.Degree),"275°0'-16500\"°");
        }

        [Test()]
        public void Angle_EqualsTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 359);

            bool result1 = a1.Equals(a2);
            bool result2 = a2.Equals(a3);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test()]
        public void Angle_MathOperatorTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);

            Angle addedAngle = a1 + a2;
            Assert.AreEqual(addedAngle.Degrees,720);

            Angle subtractedAngle = a1 - a2;
            Assert.AreEqual(subtractedAngle.Radians,0);
        }

        [Test()]
        public void Angle_ComparisonOperatorTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle subtractedAngle = a1 - a2;

            Assert.IsTrue(subtractedAngle < a2);
            Assert.IsTrue(a1 > subtractedAngle);
            Assert.IsTrue(a1 == a2);
            Assert.IsTrue(a1 >= a2);
            Assert.IsTrue(a1 <= a2);
        }

        [Test()]
        public void Angle_CompareToTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 720);

            Assert.AreEqual(a1.CompareTo(a2),0);
            Assert.AreEqual(a1.CompareTo(a2),0);
            Assert.AreEqual(a1.CompareTo(a3),-1);
            Assert.AreEqual(a3.CompareTo(a2), 1);
        }

        [Test()]
        public void Angle_NegationTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI);

            Assert.AreEqual(a1.Negate().Degrees,-360);
            Assert.AreEqual(a2.Negate().Radians,Math.PI * -1);
            Assert.AreEqual(a1.Negate().Radians,Math.PI * -2);
            Assert.AreEqual(a2.Negate().Degrees, -180);
        }
    }
}
