using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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
            hourTime.Hours.Should().Be(mintueTime.Hours);
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

            subtractionTime.Hours.Should().Be(0);
            subtractionTime.Minutes.Should().Be(0);
            additionTime.Hours.Should().Be(2);
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

            (equivalentbiggerTime.EqualsWithinPassedAcceptedDeviation(biggerTime, 1)).Should().Be(true);
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
        [ExpectedException(typeof(NotImplementedException))]
        public void Time_ToString()
        {
            // arrange
            Time Time = new Time(TimeType.Second, 1);

            // act
            string dimToString = Time.ToString();

            // assert
            dimToString.Should().Be("");
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

            //Act & Assert
            secondTime.Hours.Should().Be(1);
            secondTime.Minutes.Should().Be(60);
            secondTime.Seconds.Should().Be(3600);
            secondTime.Milliseconds.Should().Be(3600);
            secondTime.Days.Should().Be(0.04166667);
            secondTime.Weeks.Should().Be(0.005952381);
            secondTime.Months.Should().Be(0.001368955);
            secondTime.Years.Should().Be(0.0001140796);
            secondTime.Decades.Should().Be(1.1408e-5);
        }
    }
}
