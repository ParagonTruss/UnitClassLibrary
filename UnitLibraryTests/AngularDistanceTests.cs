using System;
using System.Collections.Generic;
 
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class AngularBrokenTests
    {
        [Test()]
        public void AngularBroken_GetHashCode()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360.0);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI * 2);
            AngularBroken a3 = new AngularBroken(AngleType.Degree, 359);

            int hash1 = a1.GetHashCode();
            int hash2 = a2.GetHashCode();
            int hash3 = a3.GetHashCode();

            hash1.Should().Be(hash2);
            hash2.Should().NotBe(hash3);
        }

        [Test()]
        public void AngularBroken_ToStringOverride()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 275);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, 2 * Math.PI);

            a1.ToString(AngleType.Degree).Should().Be("275°");
        }

        [Test()]
        public void AngularBroken_EqualityTests()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI * 2);
            AngularBroken a3 = new AngularBroken(AngleType.Degree, -358);
            AngularBroken a4 = new AngularBroken(AngleType.Degree, -360);

            a1.Equals(a2).Should().BeTrue();
            a2.Equals(a3).Should().BeFalse();
            a1.Equals(a4).Should().BeFalse();

            //test for null handling capabilities
            AngularBroken nullAngle = null;
            AngularBroken otherNullAngle = null;

            //check ==
            bool nonNullFirst = (a1 == nullAngle);
            bool nullFirst = (nullAngle == a1);
            bool bothNull = (nullAngle == otherNullAngle);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (a1 != nullAngle);
            bool nullFirstNotEqual = (nullAngle != a1);
            bool bothNullNotEqual = (nullAngle != otherNullAngle);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should through a nullPointerException)
            bool nullSecond = a1.Equals(nullAngle);

            nullSecond.Should().BeFalse();
        }

        [Test()]
        public void AngularBroken_MathOperatorTest()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI * 2);

            AngularBroken addedAngle = a1 + a2;
            addedAngle.Degrees.ShouldBeEquivalentTo(720);

            AngularBroken subtractedAngle = a1 - a2;
            subtractedAngle.Radians.ShouldBeEquivalentTo(0);
        }

        [Test()]
        public void AngularBroken_ComparisonOperatorTest()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI * 2);
            AngularBroken subtractedAngle = a1 - a2;

            (subtractedAngle < a2).Should().BeTrue();
            (a1 > subtractedAngle).Should().BeTrue();
            (a1 == a2).Should().BeTrue();
            (a1 >= a2).Should().BeTrue();
            (a1 <= a2).Should().BeTrue();
        }

        [Test()]
        public void AngularBroken_CompareToTest()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI * 2);
            AngularBroken a3 = new AngularBroken(AngleType.Degree, 720);

            AngularBroken a4 = new AngularBroken(AngleType.Radian, Math.PI);
            AngularBroken a5 = new AngularBroken(AngleType.Degree, 178);

            a1.CompareTo(a2).Should().Be(0);
            a1.CompareTo(a2).Should().Be(0);
            a1.CompareTo(a3).Should().Be(0);
            a3.CompareTo(a2).Should().Be(0);

            a4.CompareTo(a3).Should().Be(-1);
            a4.CompareTo(a5).Should().Be(1);
        }

        [Test()]
        public void AngularBroken_NegationTest()
        {
            AngularBroken a1 = new AngularBroken(AngleType.Degree, 360);
            AngularBroken a2 = new AngularBroken(AngleType.Radian, Math.PI);

            a1.Negate().Degrees.Should().Be(-360);
            a2.Negate().Radians.Should().Be(Math.PI * -1);
            a1.Negate().Radians.Should().Be(Math.PI * -2);
            a2.Negate().Degrees.Should().Be(-180);
        }
    }
}
