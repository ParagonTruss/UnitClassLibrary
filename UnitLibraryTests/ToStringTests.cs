using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;
using UnitClassLibrary.ForceUnit;

namespace UnitLibraryTests
{
    [TestFixture]
    public class ToStringTests
    {
        [Test()]
        public void Unit_ToString()
        {

            // arrange & act

            //numeric value constructor
            var dist = new Distance(new Inch(), 14.1875);

            "my string".Should().Be("my string");
            var str =  dist.ToString(4);
            str.Should().Be("14.1875 in.");
            
            var force = new Force(new Pound(), 14.1875);
            str = force.ToString(4);
            str.Should().Be("14.1875 lb");
//            //architectural string constructor
//            var architecturalDistance = new Distance("1' 2 3/16\"");
//
//            //copy constructor
//            var copiedDistance = new Distance(architecturalDistance);
//
//            // assert
//            copiedDistance.ShouldBeEquivalentTo(architecturalDistance);
        }
    }
}