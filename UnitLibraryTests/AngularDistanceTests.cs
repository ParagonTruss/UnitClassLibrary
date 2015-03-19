using System;
using System.Collections.Generic;
 
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class AngularDistanceTests
    {

        [Test()]
        public void AngularDistance_ToStringOverride()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 275);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, 2 * Math.PI);

            var stringed = a1.ToString(AngleType.Degree);

            stringed.Should().Be("275 Degree");
        }

        [Test()]
        public void AngularDistance_EqualityTests()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 360);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI * 2);
            AngularDistance a3 = new AngularDistance(AngleType.Degree, -358);
            AngularDistance a4 = new AngularDistance(AngleType.Degree, -360);

            a1.Equals(a2).Should().BeTrue();
            a2.Equals(a3).Should().BeFalse();
            a1.Equals(a4).Should().BeFalse();

            //test for null handling capabilities
            AngularDistance nullAngle = null;
            AngularDistance otherNullAngle = null;

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
        public void AngularDistance_MathOperatorTest()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 360);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI * 2);

            AngularDistance addedAngle = a1 + a2;
            addedAngle.Degrees.ShouldBeEquivalentTo(720);

            AngularDistance subtractedAngle = a1 - a2;
            subtractedAngle.Radians.ShouldBeEquivalentTo(0);
        }

        [Test()]
        public void AngularDistance_ComparisonOperatorTest()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 360);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI * 2);
            AngularDistance subtractedAngle = a1 - a2;

            (subtractedAngle < a2).Should().BeTrue();
            (a1 > subtractedAngle).Should().BeTrue();
            (a1 == a2).Should().BeTrue();
            (a1 >= a2).Should().BeTrue();
            (a1 <= a2).Should().BeTrue();
        }

        [Test()]
        public void AngularDistance_CompareToTest()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 360);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI * 2);
            AngularDistance a3 = new AngularDistance(AngleType.Degree, 720);

            AngularDistance a4 = new AngularDistance(AngleType.Radian, Math.PI);
            AngularDistance a5 = new AngularDistance(AngleType.Degree, 178);

            a1.CompareTo(a2).Should().Be(0);
            a1.CompareTo(a2).Should().Be(0);
            a4.CompareTo(a3).Should().Be(-1);
            a4.CompareTo(a5).Should().Be(1);
        }

        [Test()]
        public void AngularDistance_NegationTest()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 360);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI);

            a1.Negate().Degrees.Should().Be(-360);
            a2.Negate().Radians.Should().Be(Math.PI * -1);
            a1.Negate().Radians.Should().Be(Math.PI * -2);
            a2.Negate().Degrees.Should().Be(-180);
        }
    }
}
