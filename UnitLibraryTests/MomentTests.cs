using NUnit.Framework;
using UnitClassLibrary;

namespace UnitLibraryTests
{
    [TestFixture()]
    public class MomentTests
    {
        [Test()]
        public void Moment_Constructor()
        {
            Moment m = new Moment(MomentType.PoundsInch, 17);

            Assert.IsTrue(m.PoundsInches == 17);
        }
    }
}
