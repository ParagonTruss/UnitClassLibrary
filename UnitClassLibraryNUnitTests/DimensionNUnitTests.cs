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
        public void DimensionN_Constructors()
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
        public void DimensionN_Math_Operators()
        {
            // arrange
            Dimension inchDimension = new Dimension(DimensionType.Inch, 14.1875);
            Dimension architecturalDimension = new Dimension("1'2 3/16\"");

            // act
            Dimension subtractionDimension = inchDimension - architecturalDimension;
            Dimension additionDimension = inchDimension + architecturalDimension;

            // assert
            Assert.AreEqual(0, subtractionDimension.Feet, .00000001, "Doubles math should get us at least this close");
            Assert.AreEqual(720.725, additionDimension.Millimeters, .00000001, "Doubles math should get us at least this close");
            Assert.AreEqual("2'4 6/16\"", additionDimension.Architectural);
        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [Test()]
        public void DimensionN_Architectural_Constructor()
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
            Assert.AreEqual("1'2 3/16\"",dimension1.Architectural);
            Assert.AreEqual("1'",dimension2.Architectural);
            Assert.AreEqual("1'2\"",dimension3.Architectural);
            Assert.AreEqual("2 3/16\"",dimension4.Architectural);
            Assert.AreEqual("1'2 3/16\"",dimension5.Architectural);
            Assert.AreEqual("3/16\"",dimension6.Architectural);
            Assert.AreEqual("12'11 3/16\"",dimension7.Architectural);
            Assert.AreEqual("-1'2\"",dimension8.Architectural);
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void DimensionN_Equality_Operators()
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
        public void DimensionN_GetHashCode()
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
        public void DimensionN_ToString()
        {
            // arrange
            Dimension dimension = new Dimension(DimensionType.Millimeter, 14.1875);

            // act
            string dimToString = dimension.ToString();

            // assert
            Assert.AreEqual("",dimToString);
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
        public void DimensionN_CompareTo()
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
            Assert.AreEqual(smallDimension,dimensions[0]);
            Assert.AreEqual(mediumDimension,dimensions[1]);
            Assert.AreEqual(largeDimension,dimensions[2]);
        }
    }
}
