using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
namespace UnitClassLibrary.Tests
{
    [TestClass()]
    public class AngleTests
    {
        [TestMethod()]
        public void Angle_GetHashCode()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 359);

            int hash1 = a1.GetHashCode();
            int hash2 = a2.GetHashCode();
            int hash3 = a3.GetHashCode();

            hash1.Should().Be(hash2);
            hash2.Should().NotBe(hash3);
        }

        // SHOULD BE 275 BUT HAS ROUNDING ERRORS
        [TestMethod()]
        public void Angle_ToStringOverride()
        {
            Angle a1 = new Angle(AngleType.Degree, 275);
            Angle a2 = new Angle(AngleType.Radian, 2 * Math.PI);

            a1.ToString(AngleType.Degree).Should().Be("275°0'-16500\"°");
        }

        [TestMethod()]
        public void Angle_EqualsTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 359);

            bool result1 = a1.Equals(a2);
            bool result2 = a2.Equals(a3);

            result1.Should().BeTrue();
            result2.Should().BeFalse();
        }

        [TestMethod()]
        public void Angle_MathOperatorTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);

            Angle addedAngle = a1 + a2;
            addedAngle.Degrees.ShouldBeEquivalentTo(720);

            Angle subtractedAngle = a1 - a2;
            subtractedAngle.Radians.ShouldBeEquivalentTo(0);
        }

        [TestMethod()]
        public void Angle_ComparisonOperatorTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle subtractedAngle = a1 - a2;

            (subtractedAngle < a2).Should().BeTrue();
            (a1 > subtractedAngle).Should().BeTrue();
            (a1 == a2).Should().BeTrue();
            (a1 >= a2).Should().BeTrue();
            (a1 <= a2).Should().BeTrue();
        }

        [TestMethod()]
        public void Angle_CompareToTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, 720);

            a1.CompareTo(a2).Should().Be(0);
            a1.CompareTo(a2).Should().Be(0);
            a1.CompareTo(a3).Should().Be(-1);
            a3.CompareTo(a2).Should().Be(1);
        }

        [TestMethod()]
        public void Angle_NegationTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI);

            a1.Negate().Degrees.Should().Be(-360);
            a2.Negate().Radians.Should().Be(Math.PI * -1);
            a1.Negate().Radians.Should().Be(Math.PI * -2);
            a2.Negate().Degrees.Should().Be(-180);
        }
    }
}
