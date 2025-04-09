using NUnit.Framework;

namespace NUnitTest
{
    class Test2 : BaseTest
    {
        [Test, Category(TestCategory.Minor)]
        [TestCase(3, 3)]
        [TestCase(3, 4)]
        [TestCase(4, 5)]
        [TestCase(4, 4)]
        public void Test03(int a, int b)
        {
            Assert.That(a.Equals(b));
        }
    }
}

