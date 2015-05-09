using System;
using UnitClassLibrary;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using UnitClassLibrary.New_Attempt;



namespace UnitLibraryTests
{
    /// <summary>
    /// Test Class for all conversion functions 
    /// </summary>
    [TestFixture()]
    public class DistanceTests
    {
        [Test()]
        public void Generic_Tests()
        {
            Speed d = new Speed( new Distance(new Inch(), 2), new Time(new Second(), 4));
            Speed d2 = new Speed( new InchPerSecond(), 3);

            var x = d2.GetValue(new InchPerSecond());

            Speed negative = d2.Negate();

            var y = negative.GetValue(new InchPerSecond());
        }

    }
}
