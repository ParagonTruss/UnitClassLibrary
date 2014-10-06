using NUnit.Framework;
using FluentAssertions;
using UnitClassLibrary;


namespace UnitLibraryTests
{
    [TestFixture]
    public class Dimension_Conversions
    {
        [Test]
        public void FromKilometer_Test()
        {

            Dimension kilometerDimension = new Dimension(DimensionType.Kilometer, 1);

            kilometerDimension.Millimeters.Should().Be(1000000,"millimeters");
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
    }
}
