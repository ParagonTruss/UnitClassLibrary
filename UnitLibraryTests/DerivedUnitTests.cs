using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.DistributedForceUnit;
using static UnitClassLibrary.DistributedForceUnit.PoundPerInch;
namespace UnitLibraryTests
{
    [TestFixture]
    class DerivedUnitTests
    {
        [Test]
        public void DistributedForceType_MultiplicationOperator()
        {
            var distributedForce = 100.0 * DistributedForce.PoundsPerInch;

            Assert.Pass();
        }
    }
}
