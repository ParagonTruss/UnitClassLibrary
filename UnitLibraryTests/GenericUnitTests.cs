using System;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary.TimeUnit;
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
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.AreaUnit;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.AcreUnit;
using UnitClassLibrary.AreaUnit.AreaTypes.Imperial.SquareInchesUnit;
using UnitClassLibrary.AngleUnit;

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

            var x = d2.MeasurementIn(new InchPerSecond());

            Speed negative = d2.Negate();

            var y = negative.MeasurementIn(new InchPerSecond());

           // Speed d = new Speed(new Time(new Inch(), 2), new Time(new Second(), 4));
            Speed d3= new Speed(new InchPerSecond(), 3);

            var x2 = d2.MeasurementIn(new InchPerSecond());

            Speed negative2 = d2.Negate();

            var y2 = negative.MeasurementIn(new InchPerSecond());
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
            Distance distance = new Distance(new Inch(), 4);
            Time time = new Time(new Second(), 33);
            Unit result = distance / time;
            Speed speed1 = new Speed(new InchPerSecond(), 4.0/33.0);
            Speed speed2 = speed1;

            (speed1 == result).Should().BeTrue();
            (speed1 == speed2).Should().BeTrue();

        }

        [Test()]
        public void DerivedUnits_Multiplication()
        {
            Distance fiveMeters = new Distance(new Meter(), 5);
            Distance twoMiles = new Distance(new Mile(), 2);

            Unit area =  twoMiles * fiveMeters;        
            Area acreage = new Area(new Acre(), 3.977);
            Unit addition = area + acreage;
            (area == acreage).Should().BeTrue();

            bool exceptionThrown = false;
            try
            {
                Area areaAsInchesSquared = new Area(new SquareInch(), area);
            }
            catch
            {
                exceptionThrown = true;
            }
            (exceptionThrown).Should().BeFalse();

            Unit notAnArea = area * new Angle(new Radian(), 2);
            bool exceptionThrown2 = false;
            try
            {
                Area areaAsInchesSquared = new Area(new SquareInch(), notAnArea);
            }
            catch
            {
                exceptionThrown2 = true;
            }
            (exceptionThrown2).Should().BeTrue();
        }

        [Test]
        public void DerivedUnit_Constructors()
        {
            DerivedUnitType type = new DerivedUnitType(1.0, new List<IUnitType>() { new InchPerSecond(), new Minute() });
            Unit unit = new Unit<DerivedUnitType>(type, 34);

            string str = type.AsStringSingular();
            Assert.Pass();
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


        [Test()]
        public void DerivedUnits_PerformanceTest()
        {
            Time oneSecond = new Time(new Minute(), 1);
            Unit result1 = new Unit<DerivedUnitType>(new DerivedUnitType(),1.0);

            for (int i = 0; i < 10000; i++)
            {
                result1 *= oneSecond;
            }
            (result1.ConversionFactor).Should().Be(Math.Pow(60, 10000));

            Unit frequency = new Unit<DerivedUnitType>(new DerivedUnitType(1.0, null, new Second()), 1);
            Unit result2 = new Unit<DerivedUnitType>(new DerivedUnitType(), 1.0);

            for (int i = 0; i < 10000; i++)
            {
                result2 *= frequency;
            }
            (result2.ConversionFactor).Should().Be(1);

            var result3 = result1 * result2;

            (result3.Measurement == Math.Pow(60, 10000)).Should().BeTrue();

        }
    }
}
