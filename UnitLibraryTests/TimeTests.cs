using System;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary.TimeUnit;
using UnitClassLibrary.GenericUnit;


namespace UnitLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestFixture()]
    public class GenericUnitTests
    {
        [Test()]
        public void Generic_Tests()
        {
            //Speed d = new Speed(new Time(new Inch(), 2), new Time(new Second(), 4));
            //Speed d2 = new Speed(new InchPerSecond(), 3);

            //var x = d2.GetValue(new InchPerSecond());

            //Speed negative = d2.Negate();

            //var y = negative.GetValue(new InchPerSecond());

            //Speed d = new Speed( new Time(new Inch(), 2), new Time(new Second(), 4));
            //Speed d2 = new Speed( new InchPerSecond(), 3);

            //var x = d2.GetValue(new InchPerSecond());

            //Speed negative = d2.Negate();

            //var y = negative.GetValue(new InchPerSecond());
        }

        /// <summary>
        /// Tests the architectural string constructor and the regular Time constructor
        /// </summary>
        //[Test()]
        //public void Time_Constructors()
        //{

        //    // arrange & act

        //    //numeric value constructor
        //    Time inchTime = new Time(new Inch(), 14.1875);

        //    //architectural string constructor
        //    Time architecturalTime = new Time("1' 2 3/16\"");

        //    //copy constructor
        //    Time copiedTime = new Time(architecturalTime);

        //    // assert
        //    inchTime.AsMillimeters().Should().Be(architecturalTime.AsMillimeters());
        //    copiedTime.ShouldBeEquivalentTo(architecturalTime);
        //}

        ///// <summary>
        ///// Tests mathmatical operators
        ///// </summary>
        //[Test()]
        //public void Time_Math_Operators()
        //{
        //    // arrange
        //    Time inchTime = new Time(new Inch(), 14.1875);
        //    Time architecturalTime = new Time("1'2 3/16\"");

        //    // act
        //    Time subtractionTime = inchTime - architecturalTime;
        //    Time additionTime = inchTime + architecturalTime;

        //    // assert
        //    subtractionTime.Equals(new Time(new Inch(), 0)).Should().BeTrue();
        //    additionTime.Equals(new Time(new Millimeter(), 720.725)).Should().BeTrue();
        //    additionTime.Architectural.Should().Be("2'4 6/16\"");
        //}

        //[Test]
        //public void TimeConversions()
        //{

        //    Time kilometerTime = new Time(new Kilometer(), 1);

        //    (kilometerTime == new Time(new Millimeter(), 1000000)).Should().BeTrue();
        //    (kilometerTime == new Time(new Centimeter(), 100000)).Should().BeTrue();
        //    (kilometerTime == new Time(new Inch(), 39370.1)).Should().BeTrue();
        //    (kilometerTime == new Time(new Foot(), 3280.84)).Should().BeTrue();
        //    (kilometerTime == new Time(new Yard(), 1093.61)).Should().BeTrue();
        //    (kilometerTime == new Time(new Mile(), 0.621371)).Should().BeTrue();
        //    (kilometerTime == new Time(new Meter(), 1000)).Should().BeTrue();
        //    kilometerTime.Architectural.Should().Be("3280'10 1/16\""); //need to recheck


        //}

        ///// <summary>
        ///// Tests Architectural string inputs.
        ///// </summary>
        //[Test()]
        //public void Time_Architectural_Constructor()
        //{
        //    // arrange
        //    Time Time1 = new Time("1'2 3/16\"");
        //    Time Time2 = new Time("1'");
        //    Time Time3 = new Time("1'2\"");
        //    Time Time4 = new Time("2 3/16\"");
        //    Time Time5 = new Time("1'2-3/16\"");
        //    Time Time6 = new Time("3/16\"");
        //    Time Time7 = new Time("121103");
        //    Time Time8 = new Time("-1'2\"");

        //    // assert
        //    Time1.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
        //    Time2.Architectural.ShouldBeEquivalentTo("1'");
        //    Time3.Architectural.ShouldBeEquivalentTo("1'2\"");
        //    Time4.Architectural.ShouldBeEquivalentTo("2 3/16\"");
        //    Time5.Architectural.ShouldBeEquivalentTo("1'2 3/16\"");
        //    Time6.Architectural.ShouldBeEquivalentTo("3/16\"");
        //    Time7.Architectural.ShouldBeEquivalentTo("12'11 3/16\"");
        //    Time8.Architectural.ShouldBeEquivalentTo("-1'2\"");
        //}

        ///// <summary>
        ///// Tests all equality operators
        ///// </summary>
        //[Test()]
        //public void Time_EqualityTests()
        //{
        //    // arrange
        //    Time biggerTime = new Time(new Inch(), 14.1875);
        //    Time smallerTime = new Time("1' 2 1/16\"");
        //    Time equivalentbiggerTime = new Time(new Millimeter(), 360.3625);

        //    (equivalentbiggerTime.Equals(biggerTime)).Should().Be(true);
        //    (equivalentbiggerTime == smallerTime).Should().Be(false);

        //    (equivalentbiggerTime != smallerTime).Should().Be(true);
        //    (equivalentbiggerTime != biggerTime).Should().Be(false);


        //    //check ==
        //    bool nonNullFirst = (biggerTime == null);
        //    bool nullFirst = (null == biggerTime);
        //    bool bothNull = (null == null);

        //    nonNullFirst.Should().BeFalse();
        //    nullFirst.Should().BeFalse();
        //    bothNull.Should().BeTrue();

        //    //check != 
        //    bool nonNullFirstNotEqual = (biggerTime != null);
        //    bool nullFirstNotEqual = (null != biggerTime);
        //    bool bothNullNotEqual = (null != null);

        //    nonNullFirstNotEqual.Should().BeTrue();
        //    nullFirstNotEqual.Should().BeTrue();
        //    bothNullNotEqual.Should().BeFalse();

        //    //check equals (other way should throw a nullPointerException)
        //    bool nullSecond = biggerTime.Equals(null);

        //    nullSecond.Should().BeFalse();
        //}

        ///// <summary>
        ///// Tests all equality operators
        ///// </summary>
        //[Test()]
        //public void Dimension_ComparisonOperatorTest()
        //{
        //    // arrange
        //    Time biggerTime = new Time(new Inch(), 14.1875);
        //    Time smallerTime = new Time("1' 2 1/16\"");
        //    Time equivalentbiggerTime = new Time(new Millimeter(), 360.3625);

        //    // assert
        //    (smallerTime < biggerTime).Should().Be(true);
        //    (biggerTime < smallerTime).Should().Be(false);

        //    (biggerTime > smallerTime).Should().Be(true);
        //    (smallerTime > biggerTime).Should().Be(false);
        //}


        //[Test()]
        //public void Time_EqualsWithinPassedAcceptedDeviation()
        //{
        //    // arrange
        //    Time biggerTime = new Time(new Inch(), -14.1875);
        //    Time smallerTime = new Time("1' 2 1/16\"");
        //    Time equivalentbiggerTime = new Time(new Millimeter(), -360.3625);

        //    (equivalentbiggerTime.EqualsWithinDeviationConstant(biggerTime, new Time(new Millimeter(), 1))).Should().Be(true);
        //}



        ///// <summary>
        ///// Tests GetHashCodeOperation
        ///// </summary>
        //[Test()]
        //public void Time_GetHashCode()
        //{
        //    // arrange
        //    Time Time = new Time(new Millimeter(), 14.1875);
        //    double number = 14.1875;

        //    // act
        //    int TimeHashCode = Time.GetHashCode();

        //    int hashCode = number.GetHashCode();

        //    // assert
        //    hashCode.ShouldBeEquivalentTo(TimeHashCode);
        //}

        ///// <summary>
        ///// Tests toString
        ///// </summary>
        //[Test()]
        //public void Time_ToString()
        //{
        //    // arrange
        //    Time Time = new Time(new Millimeter(), 14.1875);
        //    Time Time2 = new Time(new Millimeter(), 0);

        //    //should come back rounded due to DeviationConstant
        //    // act            

        //    // assert
        //    Time.ToString().Should().Be("14.188 Millimeters");
        //    Time2.ToString().Should().Be("0 Millimeters");
        //}

        ///// <summary>
        ///// Tests CompareTo implementation
        ///// </summary>
        //[Test()]
        //public void Time_CompareTo()
        //{
        //    // arrange
        //    Time smallTime = new Time(new Millimeter(), 1);
        //    Time mediumTime = new Time(new Foot(), 1);
        //    Time largeTime = new Time(new Kilometer(), 1);

        //    //Act & Assert
        //    smallTime.CompareTo(mediumTime).Should().Be(-1);
        //    mediumTime.CompareTo(smallTime).Should().Be(1);
        //    largeTime.CompareTo(largeTime).Should().Be(0);
        //}

        //[Test()]
        //public void Time_Incrementing()
        //{

        //    //Static constants
        //    Time oneFoot = 1.FromFeetToTime();

        //    //increments
        //    oneFoot += oneFoot; //should be two feet

        //    (oneFoot == new Time(new Foot(), 2)).Should().BeTrue();

        //    oneFoot -= oneFoot; //should be zero feet

        //    (oneFoot == new Time(new Foot(), 0)).Should().BeTrue();

        //}

        //[Test()]
        //public void Time_SelfConversionTest()
        //{
        //    Time testInstance = new Time(new Mile(), 1);
        //    testInstance.AsMiles().Should().Be(1);
        //}


        ///// <summary>
        ///// Tests intuitiveness. If this compiles then these "pass"
        ///// </summary>
        //[Test()]
        //public void Time_Intuitiveness()
        //{
        //    //zero constructor
        //    Time zero = new Time();

        //    //simple constructor
        //    Time smallTime = new Time(new Millimeter(), 1);
        //    Time mediumTime = new Time(new Foot(), 1);
        //    Time largeTime = new Time(new Kilometer(), 1);

        //    //copy constructor
        //    Time copy = new Time(smallTime);

        //    //comparisons
        //    if (copy > zero)
        //    {

        //    }

        //    if (zero == new Time())
        //    {

        //    }

        //    if (zero >= new Time())
        //    {

        //    }


        //    //Math operations
        //    Time Time4 = smallTime + largeTime;
        //    Time doubleTime = mediumTime ^ 2;

        //    //absolute value
        //    Time positiveTime = (new Time(new Inch(), -1).AbsoluteValue());

        //    //Static constants
        //    Time oneFoot = 1.FromFeetToTime();

        //    //increments
        //    oneFoot += oneFoot; // 2 feet
        //    oneFoot -= oneFoot; // 0 feet

        //    //we do not implement ++ and -- because that would break our "all units simultaneously" abstraction.
        //    // oneFoot++;
        //    // oneFoot--;

        //    //User defined equality strategies
        //    EqualityStrategy userStrategy = (d1, d2) => { return true; };

        //    oneFoot.EqualsWithinEqualityStrategy(positiveTime, userStrategy);

        //    // ToString override
        //    oneFoot.ToString();

        //    oneFoot.ToString(new Inch());

        //    List<Time> Times = new List<Time> { oneFoot, positiveTime, Time4, zero };

        //    foreach (var Time in Times)
        //    {
        //        Time.ToString();
        //    }


        //}

    }
}
