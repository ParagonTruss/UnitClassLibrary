using System.Collections.Generic;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestFixture()]
    public class DistanceTests
    {
        /// <summary>
        /// Tests the architectural string constructor and the regular Distance constructor
        /// </summary>
        [Test()]
        public void Distance_Constructors() 
        {
 
            // arrange & act

            //numeric value constructor
            Distance inchDistance = new Distance(DistanceType.Inch, 14.1875);
            
            //architectural string constructor
            Distance architecturalDistance = new Distance("1' 2 3/16\"");

            //copy constructor
            Distance copiedDistance = new Distance(architecturalDistance);

            // assert
            inchDistance.Millimeters.Should().Be(architecturalDistance.Millimeters);
            copiedDistance.ShouldBeEquivalentTo(architecturalDistance);
        }

        [Test()]
        public void Distance_JSON()
        {

            Distance distance = new Distance(DistanceType.Yard, 12);

            var json = JsonConvert.SerializeObject(distance);
            Distance deserializedDistance = JsonConvert.DeserializeObject<Distance>(json);

            bool areEqual = (distance == deserializedDistance);
            areEqual.Should().BeTrue();
        }

        /// <summary>
        /// Tests mathematical operators
        /// </summary>
        [Test()]
        public void Distance_Math_Operators()
        {
            // arrange
            Distance inchDistance = new Distance(DistanceType.Inch, 14.1875);
            Distance architecturalDistance = new Distance("1'2 3/16\"");

            // act
            Distance subtractionDistance = inchDistance - architecturalDistance;
            Distance additionDistance = inchDistance + architecturalDistance;

            // assert
            subtractionDistance.Equals(new Distance(DistanceType.Inch, 0)).Should().BeTrue();
            additionDistance.Equals(new Distance(DistanceType.Millimeter, 720.725)).Should().BeTrue();
            additionDistance.Architectural.Should().Be("2'4 6/16\"");
        }

        [Test()]
        public void Distance_Division()
        {
            Distance inch = new Distance(DistanceType.Inch, 1);
            Distance centimeter = new Distance(DistanceType.Centimeter, 1);

            (inch / centimeter).Should().Be(2.54);
        }

        [Test]
        public void DistanceConversions()
        {

            Distance kilometerDistance = new Distance(DistanceType.Kilometer, 1, EqualityStrategyImplementations.DefaultPercentageEquality);

            (kilometerDistance == new Distance(DistanceType.Millimeter, 1000000)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Centimeter, 100000)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Inch, 39370.1)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Foot, 3280.84)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Yard, 1093.61)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Mile, 0.621371)).Should().BeTrue();
            (kilometerDistance == new Distance(DistanceType.Meter, 1000)).Should().BeTrue();
            kilometerDistance.Architectural.Should().Be("3280'10 1/16\""); //need to recheck


        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [Test()]
        public void Distance_Architectural_Constructor()
        {
            // arrange
            Distance Distance1 = new Distance("1'2 3/16\"");
            Distance Distance2 = new Distance("1'");
            Distance Distance3 = new Distance("1'2\"");
            Distance Distance4 = new Distance("2 3/16\"");
            Distance Distance5 = new Distance("1'2-3/16\"");
            Distance Distance6 = new Distance("3/16\"");
            Distance Distance7 = new Distance("121103");
            Distance Distance8 = new Distance("-1'2\"");

            // assert
            Distance1.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            Distance2.Architectural.ShouldBeEquivalentTo("1'");
            Distance3.Architectural.ShouldBeEquivalentTo("1'2\"");
            Distance4.Architectural.ShouldBeEquivalentTo("2 3/16\"");
            Distance5.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            Distance6.Architectural.ShouldBeEquivalentTo("3/16\"");
            Distance7.Architectural.ShouldBeEquivalentTo("12'11 3/16\"");
            Distance8.Architectural.ShouldBeEquivalentTo("-1'2\"");
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Distance_EqualityTests()
        {
            // arrange
            Distance biggerDistance = new Distance(DistanceType.Inch, 14.1875);
            Distance smallerDistance = new Distance("1' 2 1/16\"");
            Distance equivalentbiggerDistance = new Distance(DistanceType.Millimeter, 360.3625);

            (equivalentbiggerDistance.Equals(biggerDistance)).Should().Be(true);
            (equivalentbiggerDistance == smallerDistance).Should().Be(false);

            (equivalentbiggerDistance != smallerDistance).Should().Be(true);
            (equivalentbiggerDistance != biggerDistance).Should().Be(false);


            //check ==
            bool nonNullFirst = (biggerDistance == null);
            bool nullFirst = (null == biggerDistance);
            bool bothNull = (null == null);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (biggerDistance != null);
            bool nullFirstNotEqual = (null != biggerDistance);
            bool bothNullNotEqual = (null != null);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should throw a nullPointerException)
            bool nullSecond = biggerDistance.Equals(null);

            nullSecond.Should().BeFalse();
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Dimension_ComparisonOperatorTest()
        {
            // arrange
            Distance biggerDistance = new Distance(DistanceType.Inch, 14.1875);
            Distance smallerDistance = new Distance("1' 2 1/16\"");
            Distance equivalentbiggerDistance = new Distance(DistanceType.Millimeter, 360.3625);

            // assert
            (smallerDistance < biggerDistance).Should().Be(true);
            (biggerDistance < smallerDistance).Should().Be(false);

            (biggerDistance > smallerDistance).Should().Be(true);
            (smallerDistance > biggerDistance).Should().Be(false);
        }


        [Test()]
        public void Distance_EqualsWithinPassedAcceptedDeviation()
        {
            // arrange
            Distance biggerDistance = new Distance(DistanceType.Inch, -14.1875);
            Distance smallerDistance = new Distance("1' 2 1/16\"");
            Distance equivalentbiggerDistance = new Distance(DistanceType.Millimeter, -360.3625);

            (equivalentbiggerDistance.EqualsWithinDeviationConstant( biggerDistance, new Distance(DistanceType.Millimeter, 1))).Should().Be(true);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [Test()]
        public void Distance_GetHashCode()
        {
            // arrange
            Distance Distance = new Distance(DistanceType.Millimeter, 14.1875);
            double number = 14.1875/25.4;

            // act
            int DistanceHashCode = Distance.GetHashCode();

            int hashCode = number.GetHashCode();

            // assert
            hashCode.ShouldBeEquivalentTo(DistanceHashCode);
        }

        /// <summary>
        /// Tests toString
        /// </summary>
        [Test()]
        public void Distance_ToString()
        {
            // arrange
            Distance Distance = new Distance(DistanceType.Millimeter, 14.1875);
            Distance Distance2 = new Distance(DistanceType.Millimeter, 0);

            //should come back rounded due to DeviationConstant
            // act            

            // assert
            Distance.ToString().Should().Be("14 Millimeter");
            Distance2.ToString().Should().Be("0 Millimeter");
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
        public void Distance_CompareTo()
        {
            // arrange
            Distance smallDistance = new Distance(DistanceType.Millimeter, 1);
            Distance mediumDistance = new Distance(DistanceType.Foot, 1);
            Distance largeDistance = new Distance(DistanceType.Kilometer, 1);

            //Act & Assert
            smallDistance.CompareTo(mediumDistance).Should().Be(-1);
            mediumDistance.CompareTo(smallDistance).Should().Be(1);
            largeDistance.CompareTo(largeDistance).Should().Be(0);
        }

        [Test()]
        public void Distance_Incrementing()
        {

            //Static constants
            Distance oneFoot = Distance.Foot;

            //increments
            oneFoot += oneFoot; //should be two feet

            (oneFoot == new Distance(DistanceType.Foot, 2)).Should().BeTrue();

            oneFoot -= oneFoot; //should be zero feet

            (oneFoot == new Distance(DistanceType.Foot, 0)).Should().BeTrue();

        }

        [Test()]
        public void Distance_SelfConversionTest()
        {
            Distance testInstance = new Distance(DistanceType.Mile, 1);
            testInstance.Miles.Should().Be(1);
        }


        /// <summary>
        /// Tests intuitiveness. If this compiles then these "pass"
        /// </summary>
        [Test()]
        public void Distance_Intuitiveness()
        {
            //zero constructor
            Distance zero = Distance.Zero;

            //simple constructor
            Distance smallDistance = new Distance(DistanceType.Millimeter, 1);
            Distance mediumDistance = new Distance(DistanceType.Foot, 1);
            Distance largeDistance = new Distance(DistanceType.Kilometer, 1);

            //copy constructor
            Distance copy = new Distance(smallDistance);

            //comparisons
            if (copy > zero)
            {
		 
            }
            
            if (zero == Distance.Zero)
            {

            }

            if (zero >= Distance.Zero)
            {

            }
            

            //Math operations
            Distance distance4 = smallDistance + largeDistance;
            Distance doubleDistance = mediumDistance ^ 2;

            //absolute value
            Distance positiveDistance = (new Distance(DistanceType.Inch, -1).AbsoluteValue());

            //Static constants
            Distance oneFoot = Distance.Foot;

            //increments
            oneFoot += oneFoot; // 2 feet
            oneFoot -= oneFoot; // 0 feet

            //we do not implement ++ and -- because that would break our "all units simultaneously" abstraction.
            // oneFoot++;
            // oneFoot--;

            //User defined equality strategies
            DistanceEqualityStrategy userStrategy = (d1, d2) => { return true; };

            oneFoot.EqualsWithinDistanceEqualityStrategy(positiveDistance, userStrategy);

            // ToString override
            oneFoot.ToString();

            oneFoot.ToString(DistanceType.Inch);

            List<Distance> distances = new List<Distance> { oneFoot, positiveDistance, distance4, zero };

            foreach (var distance in distances)
            {
                distance.ToString();
            }

           
        }

        [Test()]
        public void Distance_DistanceInIntrinsicUnitsIsGreaterThan()
        {
            Distance d1 = Distance.Zero;// empty constructor
            Distance d2 = new Distance(DistanceType.Meter, 1000);
            Distance d3 = new Distance(DistanceType.Meter, 1000.1);
            Distance d4 = new Distance(DistanceType.Mile, 0) + d3; //converts d3's internal units to miles.

            d1.DistanceInIntrinsicUnitsIsGreaterThan(10).Should().BeFalse();
            d1.DistanceInIntrinsicUnitsIsGreaterThan(-10).Should().BeTrue();
            d2.DistanceInIntrinsicUnitsIsGreaterThan(1000).Should().BeFalse();
            d3.DistanceInIntrinsicUnitsIsGreaterThan(1000).Should().BeTrue();
            d4.DistanceInIntrinsicUnitsIsGreaterThan(1000).Should().BeFalse();
        }
    }
}

