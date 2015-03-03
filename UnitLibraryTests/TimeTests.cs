using NUnit.Framework;
using System;
using System.Collections.Generic;
 
using System.Text;
using System.Threading.Tasks;
using UnitClassLibrary;
using FluentAssertions;

namespace UnitLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestFixture()]
    public class TimeTests
    {
        /// <summary>
        /// Tests the  Time constructors
        /// </summary>
        [Test()]
        public void Time_Constructors()
        {

            // arrange & act

            //numeric value constructor
            Time hourTime = new Time(TimeType.Hour, 1);

            Time mintueTime = new Time(TimeType.Minute, 60);

            //copy constructor
            Time copiedTime = new Time(mintueTime);

            // assert
            (hourTime == mintueTime).Should().BeTrue();
            copiedTime.ShouldBeEquivalentTo(mintueTime);
        }

        /// <summary>
        /// Tests mathmatical operators we will test the properties at the same time.
        /// </summary>
        [Test()]
        public void Time_Math_Operators()
        {
            // arrange
            Time hourTime = new Time(TimeType.Hour, 1);
            Time mintueTime = new Time(TimeType.Minute, 60);


            // act
            Time subtractionTime = hourTime - mintueTime;
            Time additionTime = hourTime + mintueTime;

            (subtractionTime == new Time()).Should().BeTrue();
            (additionTime == new Time(TimeType.Hour, 2)).Should().BeTrue();
        }

        /// <summary>
        /// Tests all equality operators
        /// </summary>
        [Test()]
        public void Time_Equality_Operators()
        {
            // arrange
            Time biggerTime = new Time(TimeType.Hour, 1);
            Time smallerTime = new Time(TimeType.Minute, 30);
            Time equivalentbiggerTime = new Time(TimeType.Minute, 60);

            // assert
            (smallerTime < biggerTime).Should().Be(true);
            (biggerTime < smallerTime).Should().Be(false);


            (biggerTime > smallerTime).Should().Be(true);
            (smallerTime > biggerTime).Should().Be(false);


            (equivalentbiggerTime == biggerTime).Should().Be(true);
            (equivalentbiggerTime == smallerTime).Should().Be(false);


            (equivalentbiggerTime != smallerTime).Should().Be(true);
            (equivalentbiggerTime != biggerTime).Should().Be(false);
        }

        [Test()]
        public void Time_EqualsWithinPassedAcceptedDeviation()
        {
            // arrange
            Time biggerTime = new Time(TimeType.Hour, 1);

            Time equivalentbiggerTime = new Time(TimeType.Minute, 59.1);

            equivalentbiggerTime.EqualsWithinDeviationConstant(biggerTime, new Time(TimeType.Minute, 1)).Should().Be(true);
        }



        /// <summary>
        /// Tests GetHashCodeOperation
        /// </summary>
        [Test()]
        public void Time_GetHashCode()
        {
            // arrange
            Time biggerTime = new Time(TimeType.Second, 1);
            double number = 1;

            // act
            int TimeHashCode = biggerTime.GetHashCode();

            int hashCode = number.GetHashCode();

            // assert
            hashCode.ShouldBeEquivalentTo(TimeHashCode);
        }

        /// <summary>
        /// Tests toString failure
        /// </summary>
        [Test()]
        public void Time_ToString()
        {
            // arrange
            Time Time = new Time(TimeType.Second, 1);

            // act
            string dimToString = Time.ToString();

            // assert
            dimToString.Should().Be("1 Second");
        }

        /// <summary>
        /// Tests CompareTo implementation
        /// </summary>
        [Test()]
        public void Time_CompareTo()
        {
            // arrange
            Time smallTime = new Time(TimeType.Second, 1);
            Time mediumTime = new Time(TimeType.Minute, 1);
            Time largeTime = new Time(TimeType.Hour, 1);

            //Act & Assert
            smallTime.CompareTo(mediumTime).Should().Be(-1);
            mediumTime.CompareTo(smallTime).Should().Be(1);
            largeTime.CompareTo(largeTime).Should().Be(0);
        }

        /// <summary>
        /// Tests ConversionFactor implementation
        /// </summary>
        [Test()]
        public void Time_Conversions()
        {
            // arrange
            Time secondTime = new Time(TimeType.Second, 3600);
            Time hourTime = new Time(TimeType.Hour, 1);
            Time minuteTime = new Time(TimeType.Minute, 60);
            Time milliSecondTime = new Time(TimeType.Millisecond, 3600000);
            Time dayTime = new Time(TimeType.Day, (3600.0/86400));
            Time weekTime = new Time(TimeType.Week, 0.005952381);
            Time monthTime = new Time(TimeType.Month, 0.001368955);
            Time yearTime = new Time(TimeType.Year, 0.0001140796);
            Time decadeTime = new Time(TimeType.Decade, 1/87658.1);

            //Act & Assert
            (secondTime == hourTime).Should().BeTrue();
            (secondTime == minuteTime).Should().BeTrue();
            (secondTime == milliSecondTime).Should().BeTrue();
            (secondTime == dayTime).Should().BeTrue();
            (secondTime == weekTime).Should().BeTrue();
            (secondTime == monthTime).Should().BeTrue();
            (secondTime == yearTime).Should().BeTrue();
            (secondTime == decadeTime).Should().BeTrue();

        }
    }
}
