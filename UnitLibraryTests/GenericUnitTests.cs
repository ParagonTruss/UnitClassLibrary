using System;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary.TimeUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MillimeterUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.CentimeterUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.FootUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.YardUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.MileUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Metric.MeterUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.SpeedUnit;

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
            Speed d2 = new Speed(new InchPerSecond(), 3);

            var x = d2.ValueInThisUnit(new InchPerSecond());

            Speed negative = d2.Negate();

            var y = negative.ValueInThisUnit(new InchPerSecond());

           // Speed d = new Speed(new Time(new Inch(), 2), new Time(new Second(), 4));
            Speed d3= new Speed(new InchPerSecond(), 3);

            var x2 = d2.ValueInThisUnit(new InchPerSecond());

            Speed negative2 = d2.Negate();

            var y2 = negative.ValueInThisUnit(new InchPerSecond());
        }

        /// <summary>
        /// Tests the architectural string constructor and the regular Time constructor
        /// </summary>
        [Test()]
        public void BasicUnit()
        {

            // arrange & act

            //numeric value constructor
            Time inchTime = new Time(new Second(), 60);

            //architectural string constructor
            Time minuteTime = new Time(new Minute(), 1);

            //copy constructor
            Time copiedTime = new Time(minuteTime);

            // assert
            // these don't compile 

            //inchTime.AsMillimeters().Should().Be(architecturalTime.AsMillimeters());
            //copiedTime.ShouldBeEquivalentTo(architecturalTime);
        }

        /// <summary>
        /// Tests mathmatical operators
        /// </summary>
        [Test()]
        public void MultiDimensionalUnit()
        {
            // these don't compile : 

            // arrange
            //Time inchTime = new Time(new Inch(), 14.1875);
            //Time architecturalTime = new Time("1'2 3/16\"");

            //// act
            //Time subtractionTime = inchTime - architecturalTime;
            //Time additionTime = inchTime + architecturalTime;

            //// assert
            //subtractionTime.Equals(new Time(new Inch(), 0)).Should().BeTrue();
            //additionTime.Equals(new Time(new Millimeter(), 720.725)).Should().BeTrue();
            //additionTime.Architectural.Should().Be("2'4 6/16\"");
        }

        [Test]
        public void CompositeUnit()
        {
            // These don't compile :

            //Time kilometerTime = new Time(new Kilometer(), 1);

            //(kilometerTime == new Time(new Millimeter(), 1000000)).Should().BeTrue();
            //(kilometerTime == new Time(new Centimeter(), 100000)).Should().BeTrue();
            //(kilometerTime == new Time(new Inch(), 39370.1)).Should().BeTrue();
            //(kilometerTime == new Time(new Foot(), 3280.84)).Should().BeTrue();
            //(kilometerTime == new Time(new Yard(), 1093.61)).Should().BeTrue();
            //(kilometerTime == new Time(new Mile(), 0.621371)).Should().BeTrue();
            //(kilometerTime == new Time(new Meter(), 1000)).Should().BeTrue();
            //kilometerTime.Architectural.Should().Be("3280'10 1/16\""); //need to recheck
        }



    }
}
