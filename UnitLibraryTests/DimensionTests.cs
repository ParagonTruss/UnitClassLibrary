using System;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;


namespace UnitLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestFixture()]
    public class DimensionTests
    {
        /// <summary>
        /// Tests the architectural string constructor and the regular dimension constructor
        /// </summary>
        [Test()]
        public void Dimension_Constructors()
        {
 
            // arrange & act

            //numeric value constructor
            Dimension inchDimension = new Dimension(DimensionType.Inch, 14.1875);
            
            //architectural string constructor
            Dimension architecturalDimension = new Dimension("1' 2 3/16\"");

            //copy constructor
            Dimension copiedDimension = new Dimension(architecturalDimension);

            // assert
            inchDimension.Millimeters.Should().Be(architecturalDimension.Millimeters);
            copiedDimension.ShouldBeEquivalentTo(architecturalDimension);
        }

        /// <summary>
        /// Tests mathmatical operators we will test the properties at the same time.
        /// </summary>
        [Test()]
        public void Dimension_Math_Operators()
        {
            // arrange
            Dimension inchDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension architecturalDimension = new Dimension("1'2 3/16\"");

            // act
            Dimension subtractionDimension = inchDimension - architecturalDimension;
            Dimension additionDimension = inchDimension + architecturalDimension;

            // assert
            subtractionDimension.Kilometers.Should().BeApproximately(0, Constants.AcceptedEqualityDeviationDimension.Kilometers);
            subtractionDimension.Feet.Should().BeApproximately(0, Constants.AcceptedEqualityDeviationDimension.Feet);
            additionDimension.Millimeters.Should().BeApproximately(720.725, Constants.AcceptedEqualityDeviationDimension.Millimeters);
            additionDimension.Architectural.Should().Be("2'4 6/16\"");
        }

        [Test]
        public void DimensionConversions_Test()
        {

            Dimension kilometerDimension = new Dimension(DimensionType.Kilometer, 1);

            kilometerDimension.Millimeters.Should().Be(1000000, "millimeters");
            kilometerDimension.Centimeters.Should().Be(100000);
            kilometerDimension.Inches.Should().Be(39370.1);
            kilometerDimension.ThirtySeconds.Should().Be(1259843.2);
            kilometerDimension.Sixteenths.Should().Be(629921.6);
            kilometerDimension.Feet.Should().Be(3280.84);
            kilometerDimension.Yards.Should().Be(1093.61);
            kilometerDimension.Miles.Should().Be(0.621371);
            kilometerDimension.Meters.Should().Be(1000);
            kilometerDimension.Architectural.Should().Be("3280'10 2/16\""); //need to recheck


        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [Test()]
        public void Dimension_Architectural_Constructor()
        {
            // arrange
            Dimension dimension1 = new Dimension("1'2 3/16\"");
            Dimension dimension2 = new Dimension("1'");
            Dimension dimension3 = new Dimension("1'2\"");
            Dimension dimension4 = new Dimension("2 3/16\"");
            Dimension dimension5 = new Dimension("1'2-3/16\"");
            Dimension dimension6 = new Dimension("3/16\"");
            Dimension dimension7 = new Dimension("121103");
            Dimension dimension8 = new Dimension("-1'2\"");

            // assert
            dimension1.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            dimension2.Architectural.ShouldBeEquivalentTo("1'");
            dimension3.Architectural.ShouldBeEquivalentTo("1'2\"");
            dimension4.Architectural.ShouldBeEquivalentTo("2 3/16\"");
            dimension5.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            dimension6.Architectural.ShouldBeEquivalentTo("3/16\"");
            dimension7.Architectural.ShouldBeEquivalentTo("12'11 3/16\"");
            dimension8.Architectural.ShouldBeEquivalentTo("-1'2\"");
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Dimension_EqualityTests()
        {
            // arrange
            Dimension biggerDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension smallerDimension = new Dimension("1' 2 1/16\"");
            Dimension equivalentbiggerDimension = new Dimension(DimensionType.Millimeter, 360.3625);

            (equivalentbiggerDimension == biggerDimension).Should().Be(true);
            (equivalentbiggerDimension == smallerDimension).Should().Be(false);

            (equivalentbiggerDimension != smallerDimension).Should().Be(true);
            (equivalentbiggerDimension != biggerDimension).Should().Be(false);


            //test for null handling capabilities
            Dimension nullAngle = null;
            Dimension otherNullAngle = null;

            //check ==
            bool nonNullFirst = (biggerDimension == nullAngle);
            bool nullFirst = (nullAngle == biggerDimension);
            bool bothNull = (nullAngle == otherNullAngle);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (biggerDimension != nullAngle);
            bool nullFirstNotEqual = (nullAngle != biggerDimension);
            bool bothNullNotEqual = (nullAngle != otherNullAngle);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should through a nullPointerException)
            bool nullSecond = biggerDimension.Equals(nullAngle);

            nullSecond.Should().BeFalse();
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Dimesnion_ComparisonOperatorTest()
        {
            // arrange
            Dimension biggerDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension smallerDimension = new Dimension("1' 2 1/16\"");
            Dimension equivalentbiggerDimension = new Dimension(DimensionType.Millimeter, 360.3625);

            // assert
            (smallerDimension < biggerDimension).Should().Be(true);
            (biggerDimension < smallerDimension).Should().Be(false);

            (biggerDimension > smallerDimension).Should().Be(true);
            (smallerDimension > biggerDimension).Should().Be(false);
        }


        [Test()]
        public void Dimension_EqualsWithinPassedAcceptedDeviation()
        {
            // arrange
            Dimension biggerDimension = new Dimension(DimensionType.Inch, -14.1875);
            Dimension smallerDimension = new Dimension("1' 2 1/16\"");
            Dimension equivalentbiggerDimension = new Dimension(DimensionType.Millimeter, -360.3625);

            (equivalentbiggerDimension.EqualsWithinPassedAcceptedDeviation( biggerDimension, new Dimension(DimensionType.Millimeter, 1))).Should().Be(true);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [Test()]
        public void Dimension_GetHashCode()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Millimeter, 14.1875);
            double number = 14.1875;

            // act
            int dimensionHashCode = dimension.GetHashCode();

            int hashCode = number.GetHashCode();

            // assert
            hashCode.ShouldBeEquivalentTo(dimensionHashCode);
        }

        /// <summary>
        /// Tests toString failure
        /// </summary>
        [Test()]
        [ExpectedException(typeof(NotImplementedException))]
        public void Dimension_ToString()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Millimeter, 14.1875);

            // act
            string dimToString = dimension.ToString();

            // assert
            dimToString.Should().Be("");
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
        public void Dimension_CompareTo()
        {
            // arrange
            Dimension smallDimension = new Dimension(DimensionType.Millimeter, 1);
            Dimension mediumDimension = new Dimension(DimensionType.Foot, 1);
            Dimension largeDimension = new Dimension(DimensionType.Kilometer, 1);

            //Act & Assert
            smallDimension.CompareTo(mediumDimension).Should().Be(-1);
            mediumDimension.CompareTo(smallDimension).Should().Be(1);
            largeDimension.CompareTo(largeDimension).Should().Be(0);

            

        }
    }
}
