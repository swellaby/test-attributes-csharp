using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swellaby.TestAttributes;

namespace Swellaby.TestAttributes.Tests
{
    [TestClass]
    public class TestCategoriesTests
    {
        [TestMethod]
        public void TestUnitCategory()
        {
            Assert.AreEqual(TestCategories.Unit, "Unit");
        }
    }
}
