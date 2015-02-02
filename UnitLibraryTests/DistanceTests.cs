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
    public class BrokenTests
    {
        /// <summary>
        /// Tests the architectural string constructor and the regular Broken constructor
        /// </summary>
        [Test()]
        public void Broken_Constructors() 
        {
 
            // arrange & act

            //numeric value constructor
            Broken inchBroken = new Broken(BrokenType.Inch, 14.1875);
            
            //architectural string constructor
            Broken architecturalBroken = new Broken("1' 2 3/16\"");

            //copy constructor
            Broken copiedBroken = new Broken(architecturalBroken);

            // assert
            inchBroken.Millimeters.Should().Be(architecturalBroken.Millimeters);
            copiedBroken.ShouldBeEquivalentTo(architecturalBroken);
        }

        /// <summary>
        /// Tests mathmatical operators
        /// </summary>
        [Test()]
        public void Broken_Math_Operators()
        {
            // arrange
            Broken inchBroken = new Broken(BrokenType.Inch, 14.1875);
            Broken architecturalBroken = new Broken("1'2 3/16\"");

            // act
            Broken subtractionBroken = inchBroken - architecturalBroken;
            Broken additionBroken = inchBroken + architecturalBroken;

            // assert
            subtractionBroken.Equals(new Broken(BrokenType.Inch, 0)).Should().BeTrue();
            additionBroken.Equals(new Broken(BrokenType.Millimeter, 720.725)).Should().BeTrue();
            additionBroken.Architectural.Should().Be("2'4 6/16\"");
        }

        [Test]
        public void BrokenConversions()
        {

            Broken kilometerBroken = new Broken(BrokenType.Kilometer, 1, EqualityStrategyImplementations.DefaultPercentageEquality);

            (kilometerBroken == new Broken(BrokenType.Millimeter, 1000000)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Centimeter, 100000)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Inch, 39370.1)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.ThirtySecond, 1259843.2)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Sixteenth, 629921.6)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Foot, 3280.84)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Yard, 1093.61)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Mile, 0.621371)).Should().BeTrue();
            (kilometerBroken == new Broken(BrokenType.Meter, 1000)).Should().BeTrue();
            kilometerBroken.Architectural.Should().Be("3280'10 1/16\""); //need to recheck


        }

        /// <summary>
        /// Tests Architectural string inputs.
        /// </summary>
        [Test()]
        public void Broken_Architectural_Constructor()
        {
            // arrange
            Broken Broken1 = new Broken("1'2 3/16\"");
            Broken Broken2 = new Broken("1'");
            Broken Broken3 = new Broken("1'2\"");
            Broken Broken4 = new Broken("2 3/16\"");
            Broken Broken5 = new Broken("1'2-3/16\"");
            Broken Broken6 = new Broken("3/16\"");
            Broken Broken7 = new Broken("121103");
            Broken Broken8 = new Broken("-1'2\"");

            // assert
            Broken1.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            Broken2.Architectural.ShouldBeEquivalentTo("1'");
            Broken3.Architectural.ShouldBeEquivalentTo("1'2\"");
            Broken4.Architectural.ShouldBeEquivalentTo("2 3/16\"");
            Broken5.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
            Broken6.Architectural.ShouldBeEquivalentTo("3/16\"");
            Broken7.Architectural.ShouldBeEquivalentTo("12'11 3/16\"");
            Broken8.Architectural.ShouldBeEquivalentTo("-1'2\"");
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Broken_EqualityTests()
        {
            // arrange
            Broken biggerBroken = new Broken(BrokenType.Inch, 14.1875);
            Broken smallerBroken = new Broken("1' 2 1/16\"");
            Broken equivalentbiggerBroken = new Broken(BrokenType.Millimeter, 360.3625);

            (equivalentbiggerBroken.Equals(biggerBroken)).Should().Be(true);
            (equivalentbiggerBroken == smallerBroken).Should().Be(false);

            (equivalentbiggerBroken != smallerBroken).Should().Be(true);
            (equivalentbiggerBroken != biggerBroken).Should().Be(false);


            //check ==
            bool nonNullFirst = (biggerBroken == null);
            bool nullFirst = (null == biggerBroken);
            bool bothNull = (null == null);

            nonNullFirst.Should().BeFalse();
            nullFirst.Should().BeFalse();
            bothNull.Should().BeTrue();

            //check != 
            bool nonNullFirstNotEqual = (biggerBroken != null);
            bool nullFirstNotEqual = (null != biggerBroken);
            bool bothNullNotEqual = (null != null);

            nonNullFirstNotEqual.Should().BeTrue();
            nullFirstNotEqual.Should().BeTrue();
            bothNullNotEqual.Should().BeFalse();

            //check equals (other way should throw a nullPointerException)
            bool nullSecond = biggerBroken.Equals(null);

            nullSecond.Should().BeFalse();
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Broken_ComparisonOperatorTest()
        {
            // arrange
            Broken biggerBroken = new Broken(BrokenType.Inch, 14.1875);
            Broken smallerBroken = new Broken("1' 2 1/16\"");
            Broken equivalentbiggerBroken = new Broken(BrokenType.Millimeter, 360.3625);

            // assert
            (smallerBroken < biggerBroken).Should().Be(true);
            (biggerBroken < smallerBroken).Should().Be(false);

            (biggerBroken > smallerBroken).Should().Be(true);
            (smallerBroken > biggerBroken).Should().Be(false);
        }


        [Test()]
        public void Broken_EqualsWithinPassedAcceptedDeviation()
        {
            // arrange
            Broken biggerBroken = new Broken(BrokenType.Inch, -14.1875);
            Broken smallerBroken = new Broken("1' 2 1/16\"");
            Broken equivalentbiggerBroken = new Broken(BrokenType.Millimeter, -360.3625);

            (equivalentbiggerBroken.EqualsWithinDeviationConstant( biggerBroken, new Broken(BrokenType.Millimeter, 1))).Should().Be(true);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [Test()]
        public void Broken_GetHashCode()
        {
            // arrange
            Broken Broken = new Broken(BrokenType.Millimeter, 14.1875);
            double number = 14.1875;

            // act
            int BrokenHashCode = Broken.GetHashCode();

            int hashCode = number.GetHashCode();

            // assert
            hashCode.ShouldBeEquivalentTo(BrokenHashCode);
        }

        /// <summary>
        /// Tests toString failure
        /// </summary>
        [Test()]
        public void Broken_ToString()
        {
            // arrange
            Broken Broken = new Broken(BrokenType.Millimeter, 14.1875);

            // act
            string dimToString = Broken.ToString();

            // assert
            dimToString.Should().Be("14.1875 Millimeter");
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
        public void Broken_CompareTo()
        {
            // arrange
            Broken smallBroken = new Broken(BrokenType.Millimeter, 1);
            Broken mediumBroken = new Broken(BrokenType.Foot, 1);
            Broken largeBroken = new Broken(BrokenType.Kilometer, 1);

            //Act & Assert
            smallBroken.CompareTo(mediumBroken).Should().Be(-1);
            mediumBroken.CompareTo(smallBroken).Should().Be(1);
            largeBroken.CompareTo(largeBroken).Should().Be(0);
        }

        [Test()]
        public void Broken_Incrementing()
        {

            //Static constants
            Broken oneFoot = Broken.Foot;

            //increments
            oneFoot += oneFoot; //should be two feet

            (oneFoot == new Broken(BrokenType.Foot, 2)).Should().BeTrue();

            oneFoot -= oneFoot; //should be zero feet

            (oneFoot == new Broken(BrokenType.Foot, 0)).Should().BeTrue();

        }

        /// <summary>
        /// Tests intuitiveness. If this compiles then these "pass"
        /// </summary>
        [Test()]
        public void Broken_Intuitiveness()
        {
            //zero constructor
            Broken zero = new Broken();

            //simple constructor
            Broken smallBroken = new Broken(BrokenType.Millimeter, 1);
            Broken mediumBroken = new Broken(BrokenType.Foot, 1);
            Broken largeBroken = new Broken(BrokenType.Kilometer, 1);

            //copy constructor
            Broken copy = new Broken(smallBroken);

            //comparisons
            if (copy > zero)
            {
		 
            }
            
            if (zero == new Broken())
            {

            }

            if (zero >= new Broken())
            {

            }
            

            //Math operations
            Broken Broken4 = smallBroken + largeBroken;
            Broken doubleBroken = mediumBroken ^ 2;

            //absolute value
            Broken positiveBroken = (new Broken(BrokenType.Inch, -1).AbsoluteValue());

            //Static constants
            Broken oneFoot = Broken.Foot;

            //increments
            oneFoot += oneFoot; // 2 feet
            oneFoot -= oneFoot; // 0 feet

            //we do not implement ++ and -- because that would break our "all units simultaneously" abstraction.
            // oneFoot++;
            // oneFoot--;

            //User defined equality strategies
            BrokenEqualityStrategy userStrategy = (d1, d2) => { return true; };

            oneFoot.EqualsWithinBrokenEqualityStrategy(positiveBroken, userStrategy);

            // ToString override
            oneFoot.ToString();

            oneFoot.ToString(BrokenType.Inch);

            List<Broken> Brokens = new List<Broken> { oneFoot, positiveBroken, Broken4, zero };

            //foreach ( in Brokens)
            //{
            //    Broken.ToString();
            //}

           
        }
    }
}
