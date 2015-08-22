using System;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class EqualityStrategyTests
    {
        [Test()]
        public void Equality_Default()
        {
            //normal case
            Distance d1 = new Distance();
            Distance d2 = new Distance(DistanceType.Inch, 1);
            Distance d3 = new Distance(DistanceType.Inch, 1.01);

            (d1 == d2).Should().BeFalse();
            (d3 == d2).Should().BeTrue();

            Distance miles = new Distance(DistanceType.Mile, 10.000001);
            Distance slightlyLargerMiles = new Distance(DistanceType.Mile, 10.000002);

            //the default comparison is with a deviation constant of 32 of an inch.
            //so even thought the two numbers are closer than any machine can measure miles in, they will still not be equal

            (miles == slightlyLargerMiles).Should().BeFalse();

            //using a percentage method will cause them to appear equal
            miles.EqualsWithinDeviationPercentage(slightlyLargerMiles, .00001).Should().BeTrue();

        }

        [Test()]
        public void Equality_Percentage_Zero()
        {
            //settings are always determined by the focus object.
            //so using d1 instead would mean that the only dimension object that can be equivalent is another exact zero object

            Distance d1 = new Distance();
            Distance d2 = Distance.ThirtySecondInch;
            Distance d3 = new Distance();

            d2.EqualsWithinDeviationPercentage(d1, 1).Should().BeTrue();

            d1.EqualsWithinDeviationPercentage(d2, 1).Should().BeFalse();

            d1.EqualsWithinDeviationPercentage(d3, 1).Should().BeTrue();
        }

        [Test()]
        public void Equality_Constant_Zero()
        {
            //settings are always determined by the focus object. But in this case it doesn't matter

            Distance d1 = new Distance();
            Distance d2 = Distance.ThirtySecondInch;

            d2.EqualsWithinDeviationConstant(d1, Distance.ThirtySecondInch).Should().BeTrue();

            d1.EqualsWithinDeviationConstant(d2, Distance.ThirtySecondInch).Should().BeTrue();
        }

        [Test()]
        public void Equality_UserDefinedStrategy()
        {

            Distance d1 = new Distance();
            Distance d2 = Distance.ThirtySecondInch;

            DistanceEqualityStrategy userStrategy = delegate(Distance distance1, Distance distance2)
            {
                if (distance1.Feet == distance2.Feet && DateTime.Now == DateTime.Today)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            };

            d1.EqualsWithinDistanceEqualityStrategy(d2, userStrategy);
        }
    }
}
