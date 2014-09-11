using System;
using UnitClassLibrary;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitClassLibraryTests
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
            Assert.AreEqual(inchDimension.Millimeters,architecturalDimension.Millimeters);
            Assert.AreEqual(copiedDimension, architecturalDimension);
        }

        /// <summary>
        /// Tests mathmatical operators we will test the properties at the same time.
        /// </summary>
        [Test()]
        public void Dimensions_Math_Operators()
        {
            // arrange
            Dimension inchDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension architecturalDimension = new Dimension("1'2 3/16\"");

            // act
            Dimension subtractionDimension = inchDimension - architecturalDimension;
            Dimension additionDimension = inchDimension + architecturalDimension;

            // assert
            Assert.AreEqual(subtractionDimension.Feet,0, .00000001, "Doubles math should get us at least this close");
            Assert.AreEqual(additionDimension.Millimeters, 720.725, .00000001, "Doubles math should get us at least this close");
            Assert.AreEqual(additionDimension.Architectural, "2'4 6/16\"");
        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [Test()]
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
            Assert.AreEqual(dimension1.Architectural,"1'2 3/16\"");
            Assert.AreEqual(dimension2.Architectural,"1'");
            Assert.AreEqual(dimension3.Architectural,"1'2\"");
            Assert.AreEqual(dimension4.Architectural,"2 3/16\"");
            Assert.AreEqual(dimension5.Architectural,"1'2 3/16\"");
            Assert.AreEqual(dimension6.Architectural,"3/16\"");
            Assert.AreEqual(dimension7.Architectural,"12'11 3/16\"");
            Assert.AreEqual(dimension8.Architectural, "-1'2\"");
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Dimensions_Equality_Operators()
        {
            // arrange
            Dimension biggerDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension smallerDimension = new Dimension("1' 2 1/16\"");
            Dimension equivalentbiggerDimension = new Dimension(DimensionType.Millimeter, 360.3625);

            // assert
            Assert.IsTrue(smallerDimension < biggerDimension);
            Assert.IsFalse(biggerDimension < smallerDimension);


            Assert.IsTrue(biggerDimension > smallerDimension);
            Assert.IsFalse(smallerDimension > biggerDimension);


            Assert.IsTrue(equivalentbiggerDimension == biggerDimension);
            Assert.IsFalse(equivalentbiggerDimension == smallerDimension);


            Assert.IsTrue(equivalentbiggerDimension != smallerDimension);
            Assert.IsFalse(equivalentbiggerDimension != biggerDimension);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [Test()]
        public void Dimensions_GetHashCode()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Millimeter, 14.1875);
            double number = 14.1875;

            // act
            int dimensionHashCode = dimension.GetHashCode();

            int hashCode = number.GetHashCode();

            // assert
            Assert.AreEqual(hashCode, dimensionHashCode);
        }

        /// <summary>
        /// Tests toString failure
        /// </summary>
        [Test()]
        [ExpectedException(typeof(NotImplementedException))]
        public void Dimensions_ToString()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Millimeter, 14.1875);

            // act
            string dimToString = dimension.ToString();

            // assert
            Assert.AreEqual(dimToString, "");
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
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
            Assert.AreEqual(dimensions[0],smallDimension);
            Assert.AreEqual(dimensions[1],mediumDimension);
            Assert.AreEqual(dimensions[2], largeDimension);
        }
    }
}
