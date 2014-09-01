using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;

namespace UnitClassLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestClass()]
    public class DimensionTests
    {
        /// <summary>
        /// Tests the architectural string constructor and the regular dimension constructor
        /// </summary>
        [TestMethod()]
        public void Dimensions_Constructors()
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
        [TestMethod()]
        public void Dimensions_Math_Operators()
        {
            // arrange
            Dimension inchDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension architecturalDimension = new Dimension("1'2 3/16\"");

            // act
            Dimension subtractionDimension = inchDimension - architecturalDimension;
            Dimension additionDimension = inchDimension + architecturalDimension;

            // assert
            subtractionDimension.Feet.Should().BeApproximately(0, .00000001, "Doubles math should get us at least this close");
            additionDimension.Millimeters.Should().BeApproximately(720.725, .00000001, "Doubles math should get us at least this close");
            additionDimension.Architectural.ShouldBeEquivalentTo("2'4 6/16\"");
        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [TestMethod()]
        public void Dimensions_Architectural_Constructor()
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
        [TestMethod()]
        public void Dimensions_Equality_Operators()
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


            (equivalentbiggerDimension == biggerDimension).Should().Be(true);
            (equivalentbiggerDimension == smallerDimension).Should().Be(false);


            (equivalentbiggerDimension != smallerDimension).Should().Be(true);
            (equivalentbiggerDimension != biggerDimension).Should().Be(false);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [TestMethod()]
        public void Dimensions_GetHashCode()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Meter, 14.1875);
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
        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void Dimensions_ToString()
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
        [TestMethod()]
        public void Dimensions_CompareTo()
        {
            // arrange
            Dimension smallDimension = new Dimension(DimensionType.Millimeter, 1);
            Dimension mediumDimension = new Dimension(DimensionType.Foot, 1);
            Dimension largeDimension = new Dimension(DimensionType.Kilometer, 1);

            List<Dimension> dimensions = new List<Dimension>();
            dimensions.Add(smallDimension);
            dimensions.Add(largeDimension);
            dimensions.Add(mediumDimension);

            // act
            dimensions.Sort();

            // assert
            dimensions[0].ShouldBeEquivalentTo(smallDimension);
            dimensions[1].ShouldBeEquivalentTo(mediumDimension);
            dimensions[2].ShouldBeEquivalentTo(largeDimension);
        }
    }
}
