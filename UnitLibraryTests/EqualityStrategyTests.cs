using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
 
using System.Text;
using System.Threading.Tasks;
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
            Broken d1 = new Broken();
            Broken d2 = new Broken(BrokenType.Inch, 1);
            Broken d3 = new Broken(BrokenType.Inch, 1.01);

            (d1 == d2).Should().BeFalse();
            (d3 == d2).Should().BeTrue();

            Broken miles = new Broken(BrokenType.Mile, 10.000001);
            Broken slightlyLargerMiles = new Broken(BrokenType.Mile, 10.000002);

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

            Broken d1 = new Broken();
            Broken d2 = new Broken(BrokenType.ThirtySecond, 1);
            Broken d3 = new Broken();

            d2.EqualsWithinDeviationPercentage(d1, 1).Should().BeTrue();

            d1.EqualsWithinDeviationPercentage(d2, 1).Should().BeFalse();

            d1.EqualsWithinDeviationPercentage(d3, 1).Should().BeTrue();
        }

        [Test()]
        public void Equality_Constant_Zero()
        {
            //settings are always determined by the focus object. But in this case it doesn't matter

            Broken d1 = new Broken();
            Broken d2 = new Broken(BrokenType.ThirtySecond, 1);

            d2.EqualsWithinDeviationConstant(d1, new Broken(BrokenType.ThirtySecond, 1)).Should().BeTrue();

            d1.EqualsWithinDeviationConstant(d2, new Broken(BrokenType.ThirtySecond, 1)).Should().BeTrue();
        }

        [Test()]
        public void Equality_UserDefinedStrategy()
        {

            Broken d1 = new Broken();
            Broken d2 = new Broken(BrokenType.ThirtySecond, 1);

            BrokenEqualityStrategy userStrategy = delegate(Broken Broken1, Broken Broken2)
            {
                if (Broken1.Feet == Broken2.Feet && DateTime.Now == DateTime.Today)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            };

            d1.EqualsWithinBrokenEqualityStrategy(d2, userStrategy);
        }
    }
}
