using NUnitTest;
using Xunit;
using Xunit.Abstractions;

namespace XunitTest
{
    public class Test2 : BaseTest
    {
        public Test2(ITestOutputHelper output) : base(output)
        {
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(4, 4)]
        [Trait("Category", TestCategory.Minor)]
        public void Test03(int a, int b)
        {
            Assert.Equal(a, b);
        }
    }
}
