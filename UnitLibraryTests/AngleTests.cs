using System;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class AngleTests
    {
        [Test()]
        public void Angle_JSON()
        {
            Angle angle = new Angle(AngleType.Degree, 717);

            var jsonSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(angle, jsonSettings);
            Angle deserializedAngle = JsonConvert.DeserializeObject<Angle>(json, jsonSettings);

            bool areEqual = (angle == deserializedAngle);
            areEqual.Should().BeTrue();
        }

        [Test()]
        public void Angle_GetValue()
        {
            Angle a1 = new Angle(AngleType.Degree, 1);
            a1.GetValue(AngleType.Degree).Should().Be(1);

            Angle a2 = new Angle(AngleType.Degree, 0);
            a2.GetValue(AngleType.Degree).Should().Be(0);
        }

        [Test()]
        public void Angle_EqualityTests()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);
            Angle a3 = new Angle(AngleType.Degree, -360);

            a1.Equals(a2).Should().BeTrue();
            a1.Equals(a3).Should().BeTrue();

            //test for null handling capabilities
            Angle nullAngle = null;
            Angle otherNullAngle = null;

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
        public void Angle_MathOperatorTest()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI * 2);

            Angle addedAngle = a1 + a2;
            addedAngle.Degrees.ShouldBeEquivalentTo(0);

            Angle subtractedAngle = a1 - a2;
            subtractedAngle.Radians.ShouldBeEquivalentTo(0);
        }

        [Test()]
        public void Angle_Negate()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI);
            Angle a3 = new Angle(AngleType.Degree, 45);

            a1.Negate().Degrees.Should().Be(0);
            a2.Negate().Radians.Should().BeApproximately(Math.PI, .00000001);
            a1.Negate().Radians.Should().BeApproximately(0, .00000001);
            a2.Negate().Degrees.Should().Be(180);

            a3.Negate().Degrees.Should().Be(315);
        }

        [Test()]
        public void Angle_Reverse()
        {
            Angle a1 = new Angle(AngleType.Degree, 360);
            Angle a2 = new Angle(AngleType.Radian, Math.PI);
            Angle a3 = new Angle(AngleType.Degree, 45);

            a1.Reverse().Degrees.Should().Be(180);
            a2.Reverse().Radians.Should().BeApproximately(0, .00000001);
            a1.Reverse().Radians.Should().BeApproximately(Math.PI, .00000001);
            a2.Reverse().Degrees.Should().Be(0);

            a3.Reverse().Degrees.Should().Be(225);
        }

        [Test()]
        public void Angle_AdditionSubtraction()
        {
            AngularDistance a1 = new AngularDistance(AngleType.Degree, 78);
            AngularDistance a2 = new AngularDistance(AngleType.Radian, Math.PI / 2);
            AngularDistance a3 = new AngularDistance(AngleType.Degree, 300);

            (a1 + a2 == new AngularDistance(AngleType.Degree, 168)).Should().BeTrue();
            (a1 + a3 == new AngularDistance(AngleType.Degree, 378)).Should().BeTrue();
            (a1 - a2 == new AngularDistance(AngleType.Degree, -12)).Should().BeTrue();
            (a2 - a1 == new AngularDistance(AngleType.Degree, 12)).Should().BeTrue();
            (a3 - a2 == new AngularDistance(AngleType.Degree, 210)).Should().BeTrue();
        }
    }
}
